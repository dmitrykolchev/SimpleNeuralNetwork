// <copyright file="ConvolutionalLayer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Numerics.Tensors;

namespace NeuralNetwork;

public enum PaddingType
{
    /// <summary>
    /// Без паддинга. Размер выхода будет меньше входа.
    /// </summary>
    Valid,
    /// <summary>
    /// Паддинг для сохранения размеров входа при stride=1.
    /// </summary>
    Same
}

/// <summary>
/// Convolutional layer class
/// </summary>
public sealed unsafe class ConvolutionalLayer : Layer
{
    private readonly int _filterCount;
    private readonly int _filterSize;
    private readonly int _stride;
    private readonly PaddingType _paddingType;
    private readonly int _padding; // Рассчитанное значение паддинга

    private List<SimpleTensor> _filterGradients = null!;
    private float[] _biasGradients = null!;
    private SimpleTensor _lastInput = null!;

    public ConvolutionalLayer(int filterCount, int filterSize, int stride, int inputDepth, PaddingType paddingType)
    {
        _filterCount = filterCount;
        _filterSize = filterSize;
        _stride = stride;
        _paddingType = paddingType;

        // Рассчитываем паддинг
        if (_paddingType == PaddingType.Same)
        {
            // Формула для 'same' паддинга: P = (F - 1) / 2
            // Это работает корректно для нечетных размеров фильтра (3, 5, 7...)
            if (filterSize % 2 == 0)
            {
                Console.WriteLine("Warning: 'Same' padding with an even filter size may not perfectly preserve dimensions.");
            }
            _padding = (filterSize - 1) / 2;
        }
        else // Valid
        {
            _padding = 0;
        }

        Filters = [];
        Biases = new float[filterCount];

        for (var i = 0; i < filterCount; i++)
        {
            var filter = new SimpleTensor(filterSize, filterSize, inputDepth);
            filter.Randomize(fanIn: filterSize * filterSize * inputDepth);
            Filters.Add(filter);
            Biases[i] = 0; // Инициализация смещений нулями - частая практика
        }
    }

    public List<SimpleTensor> Filters { get; private set; }

    public float[] Biases { get; private set; }

    public override object Forward(object input)
    {
        _lastInput = (SimpleTensor)input;

        // Формула выхода с учетом паддинга: W_out = (W_in - F + 2P) / S + 1
        var outputHeight = (_lastInput.Height - _filterSize + 2 * _padding) / _stride + 1;
        var outputWidth = (_lastInput.Width - _filterSize + 2 * _padding) / _stride + 1;

        var output = new SimpleTensor(outputWidth, outputHeight, _filterCount);

        //for (var f = 0; f < _filterCount; f++) // Для каждого фильтра
        Parallel.For(0, _filterCount, f =>
        {
            var filterData = Filters[f]._data;
            for (var y_out = 0; y_out < outputHeight; y_out++)
            {
                var y_out1 = y_out * _stride - _padding;
                for (var x_out = 0; x_out < outputWidth; x_out++)
                {
                    var x_out1 = x_out * _stride - _padding;
                    var sum = 0f;
                    // Итерация по окну свертки
                    for (var fy = 0; fy < _filterSize; fy++)
                    {
                        var inputY = y_out1 + fy;

                        for (var fx = 0; fx < _filterSize; fx++)
                        {
                            // Рассчитываем координаты в исходном тензоре
                            var inputX = x_out1 + fx;

                            // Логический паддинг: проверяем, находимся ли мы в границах исходного изображения
                            if (inputY >= 0 && inputY < _lastInput.Height && inputX >= 0 && inputX < _lastInput.Width)
                            {
                                var lastInput = _lastInput[inputX, inputY];
                                var depth = _lastInput.Depth;
                                var filter = filterData.AsSpan((fy * _filterSize + fx) * depth, depth);
                                // Итерация по глубине (каналам)
                                if (depth < 4)
                                {
                                    for (var d = 0; d < depth; d++)
                                    {
                                        var inputValue = lastInput[d];
                                        var filterValue = filter[d];
                                        sum += inputValue * filterValue;
                                    }
                                }
                                else
                                {
                                    sum += TensorPrimitives.Dot(lastInput, filter);
                                }
                            }
                            // Если мы за границами, ничего не добавляем (эквивалентно умножению на 0)
                        }
                    }
                    output[x_out, y_out, f] = sum + Biases[f];
                }
            }
        });
        return output;
    }

    public override object Backward(object outputGradientObj)
    {
        var outputGradient = (SimpleTensor)outputGradientObj;
        var inputGradient = new SimpleTensor(_lastInput.Width, _lastInput.Height, _lastInput.Depth);

        _filterGradients = [];
        for (var i = 0; i < _filterCount; i++)
        {
            var gradTensor = new SimpleTensor(_filterSize, _filterSize, _lastInput.Depth);
            _filterGradients.Add(gradTensor);
        }
        _biasGradients = new float[_filterCount];

        //for (var f = 0; f < _filterCount; f++)
        Parallel.For(0, _filterCount, f =>
        {
            var filterData = Filters[f]._data;
            var filterGradData = _filterGradients[f]._data;

            for (var y_out = 0; y_out < outputGradient.Height; y_out++)
            {
                var y_out1 = y_out * _stride - _padding;

                for (var x_out = 0; x_out < outputGradient.Width; x_out++)
                {
                    var grad = outputGradient[x_out, y_out, f];
                    _biasGradients[f] += grad;

                    var x_out1 = x_out * _stride - _padding;

                    for (var fy = 0; fy < _filterSize; fy++)
                    {
                        var inputY = y_out1 + fy;

                        for (var fx = 0; fx < _filterSize; fx++)
                        {
                            var inputX = x_out1 + fx;

                            if (inputY >= 0 && inputY < _lastInput.Height && inputX >= 0 && inputX < _lastInput.Width)
                            {
                                var lastInput = _lastInput[inputX, inputY];
                                var input = inputGradient[inputX, inputY];
                                var dataIndex = (fy * _filterSize + fx) * _lastInput.Depth;
                                var depth = _lastInput.Depth;
                                if (depth < 4)
                                {
                                    for (var d = 0; d < depth; d++)
                                    {
                                        // Обновляем градиент для фильтра
                                        filterGradData[dataIndex + d] += lastInput[d] * grad;
                                        // Обновляем градиент для входа
                                        input[d] += filterData[dataIndex + d] * grad;
                                    }
                                }
                                else
                                {
                                    var dst = filterGradData.AsSpan(dataIndex, depth);
                                    TensorPrimitives.MultiplyAdd(lastInput, grad, dst, dst);
                                    var src = filterData.AsSpan(dataIndex, depth);
                                    TensorPrimitives.MultiplyAdd(src, grad, input, input);
                                }
                            }
                        }
                    }
                }
            }
        });
        return inputGradient;
    }

    public override void UpdateParameters(float learningRate)
    {
        var lr = (float)learningRate;
        for (var f = 0; f < _filterCount; f++)
        {
            // Обновляем веса фильтров
            var filterData = Filters[f]._data;
            var filterGradData = _filterGradients[f]._data;
            var size = Filters[f].Size;
            TensorPrimitives.MultiplyAdd(filterGradData, -lr, filterData, filterData);
        }
        // Обновляем смещения
        TensorPrimitives.MultiplyAdd(_biasGradients, -lr, Biases, Biases);
    }
}
