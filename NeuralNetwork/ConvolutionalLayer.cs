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

        Filters = new List<SimpleTensor>();
        Biases = new float[filterCount];

        for (int i = 0; i < filterCount; i++)
        {
            var filter = new SimpleTensor(filterSize, filterSize, inputDepth);
            filter.Randomize(fanIn: filterSize * filterSize * inputDepth);
            Filters.Add(filter);
            Biases[i] = 0; // Инициализация смещений нулями - частая практика
        }
    }

    // Используем наши высокопроизводительные классы
    public List<SimpleTensor> Filters { get; private set; }
    public float[] Biases { get; private set; }

    public override object Forward(object input)
    {
        _lastInput = (SimpleTensor)input;

        // Формула выхода с учетом паддинга: W_out = (W_in - F + 2P) / S + 1
        int outputHeight = (_lastInput.Height - _filterSize + 2 * _padding) / _stride + 1;
        int outputWidth = (_lastInput.Width - _filterSize + 2 * _padding) / _stride + 1;

        var output = new SimpleTensor(outputWidth, outputHeight, _filterCount);

        //for (int f = 0; f < _filterCount; f++) // Для каждого фильтра
        Parallel.For(0, _filterCount, f =>
        {
            var filterData = Filters[f]._data;
            for (int y_out = 0; y_out < outputHeight; y_out++)
            {
                for (int x_out = 0; x_out < outputWidth; x_out++)
                {
                    float sum = 0;
                    // Итерация по окну свертки
                    for (int fy = 0; fy < _filterSize; fy++)
                    {
                        for (int fx = 0; fx < _filterSize; fx++)
                        {
                            // Рассчитываем координаты в исходном тензоре
                            int inputY = y_out * _stride + fy - _padding;
                            int inputX = x_out * _stride + fx - _padding;

                            // Логический паддинг: проверяем, находимся ли мы в границах исходного изображения
                            if (inputY >= 0 && inputY < _lastInput.Height && inputX >= 0 && inputX < _lastInput.Width)
                            {
                                // Итерация по глубине (каналам)
                                for (int d = 0; d < _lastInput.Depth; d++)
                                {
                                    float inputValue = _lastInput[inputX, inputY, d];
                                    float filterValue = filterData[(fy * _filterSize + fx) * _lastInput.Depth + d];
                                    sum += inputValue * filterValue;
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

        _filterGradients = new List<SimpleTensor>();
        for (int i = 0; i < _filterCount; i++)
        {
            var gradTensor = new SimpleTensor(_filterSize, _filterSize, _lastInput.Depth);
            _filterGradients.Add(gradTensor);
        }
        _biasGradients = new float[_filterCount];

        //for (int f = 0; f < _filterCount; f++)
        Parallel.For(0, _filterCount, f =>
        {
            var filterData = Filters[f]._data;
            var filterGradData = _filterGradients[f]._data;

            for (int y_out = 0; y_out < outputGradient.Height; y_out++)
            {
                for (int x_out = 0; x_out < outputGradient.Width; x_out++)
                {
                    float grad = outputGradient[x_out, y_out, f];
                    _biasGradients[f] += grad;

                    for (int fy = 0; fy < _filterSize; fy++)
                    {
                        for (int fx = 0; fx < _filterSize; fx++)
                        {
                            int inputY = y_out * _stride + fy - _padding;
                            int inputX = x_out * _stride + fx - _padding;

                            if (inputY >= 0 && inputY < _lastInput.Height && inputX >= 0 && inputX < _lastInput.Width)
                            {
                                for (int d = 0; d < _lastInput.Depth; d++)
                                {
                                    // Обновляем градиент для фильтра
                                    filterGradData[(fy * _filterSize + fx) * _lastInput.Depth + d] += _lastInput[inputX, inputY, d] * grad;
                                    // Обновляем градиент для входа
                                    inputGradient[inputX, inputY, d] += filterData[(fy * _filterSize + fx) * _lastInput.Depth + d] * grad;
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
        float lr = (float)learningRate;
        for (int f = 0; f < _filterCount; f++)
        {
            // Обновляем веса фильтров
            var filterData = Filters[f]._data;
            var filterGradData = _filterGradients[f]._data;
            int size = Filters[f].Size;
            TensorPrimitives.MultiplyAdd(filterGradData, -lr, filterData, filterData);
        }
        // Обновляем смещения
        TensorPrimitives.MultiplyAdd(_biasGradients, -lr, Biases, Biases);
    }
}