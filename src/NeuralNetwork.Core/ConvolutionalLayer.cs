// <copyright file="ConvolutionalLayer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Numerics.Tensors;
using System.Runtime.InteropServices;

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

    private Matrix _filterGradients = null!;
    private float[] _biasGradients = null!;
    private Tensor _lastInput = null!;

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

        var fanIn = filterSize * filterSize * inputDepth;
        var scale = MathF.Sqrt(1.0f / fanIn);
        Filters = Matrix.CreateRandom(filterCount, fanIn, (_, _) =>
        {
            return (Random.Shared.NextSingle() * 2f - 1f) * scale;
        });
        // Инициализация смещений нулями - частая практика
        Biases = new float[filterCount];
    }

    public Matrix Filters { get; private set; }

    public float[] Biases { get; private set; }

    public override object Forward(object input)
    {
        _lastInput = (Tensor)input;

        // Формула выхода с учетом паддинга: W_out = (W_in - F + 2P) / S + 1
        var outputHeight = (_lastInput.Height - _filterSize + 2 * _padding) / _stride + 1;
        var outputWidth = (_lastInput.Width - _filterSize + 2 * _padding) / _stride + 1;

        var output = new Tensor(outputWidth, outputHeight, _filterCount);

        //for (var f = 0; f < _filterCount; f++) // Для каждого фильтра
        Parallel.For(0, _filterCount, f =>
        {
            var filterData = Filters.GetRow(f);
            var windowData = (float*)NativeMemory.AlignedAlloc((nuint)filterData.Length * sizeof(float), 32);
            var windowDataSpan = new ReadOnlySpan<float>(windowData, filterData.Length);

            for (int y_out = 0, y_out1 = -_padding; y_out < outputHeight; y_out++, y_out1 += _stride)
            {
                for (int x_out = 0, x_out1 = -_padding; x_out < outputWidth; x_out++, x_out1 += _stride)
                {
                    _lastInput.GetWindow(x_out1, y_out1, _filterSize, _filterSize, windowData);
                    var sum = TensorPrimitives.Dot(windowDataSpan, filterData);
                    output[x_out, y_out, f] = sum + Biases[f];
                }
            }
            NativeMemory.AlignedFree(windowData);
        });
        return output;
    }

    public override object Backward(object outputGradientObj)
    {
        var outputGradient = (Tensor)outputGradientObj;
        var inputGradient = new Tensor(_lastInput.Width, _lastInput.Height, _lastInput.Depth);

        _filterGradients = Matrix.CreateZeros(_filterCount, _filterSize * _filterSize * _lastInput.Depth);
        _biasGradients = new float[_filterCount];

        //for (var f = 0; f < _filterCount; f++)
        Parallel.For(0, _filterCount, f =>
        {
            var filterData = Filters.GetRow(f);
            var filterGradData = _filterGradients.GetRow(f);

            var size = _filterSize * _filterSize * _lastInput.Depth;

            var lastInput = (float*)NativeMemory.AlignedAlloc((nuint)size * sizeof(float), 32);
            var lastInputSpan = new Span<float>(lastInput, size);

            var input = (float*)NativeMemory.AlignedAlloc((nuint)size * sizeof(float), 32);
            var inputSpan = new Span<float>(input, size);
            inputSpan.Clear();
            for (int y_out = 0, y_out1 = -_padding; y_out < outputGradient.Height; y_out++, y_out1 += _stride)
            {
                for (int x_out = 0, x_out1 = -_padding; x_out < outputGradient.Width; x_out++, x_out1 += _stride)
                {
                    var grad = outputGradient[x_out, y_out, f];
                    _biasGradients[f] += grad;

                    _lastInput.GetWindow(x_out1, y_out1, _filterSize, _filterSize, lastInputSpan);
                    TensorPrimitives.MultiplyAdd(lastInputSpan, grad, filterGradData, filterGradData);

                    inputGradient.GetWindow(x_out1, y_out1, _filterSize, _filterSize, inputSpan);
                    TensorPrimitives.MultiplyAdd(filterData, grad, inputSpan, inputSpan);

                    inputGradient.SetWindow(x_out1, y_out1, _filterSize, _filterSize, input);
                }
            }

            NativeMemory.AlignedFree(lastInput);
            NativeMemory.AlignedFree(input);
        });
        return inputGradient;
    }

    public override void UpdateParameters(float lr)
    {
        for (var f = 0; f < _filterCount; f++)
        {
            // Обновляем веса фильтров
            var filterData = Filters.GetRow(f);
            var filterGradData = _filterGradients.GetRow(f);
            TensorPrimitives.MultiplyAdd(filterGradData, -lr, filterData, filterData);
        }
        // Обновляем смещения
        TensorPrimitives.MultiplyAdd(_biasGradients, -lr, Biases, Biases);
    }
}
