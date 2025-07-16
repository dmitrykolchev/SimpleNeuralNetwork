namespace NeuralNetwork;
// MaxPoolingLayer.cs
public class MaxPoolingLayer : Layer
{
    private readonly int _poolSize;
    private readonly int _stride;
    private SimpleTensor _lastInput = null!;
    private SimpleTensor _maxIndices = null!; // Сохраняем индексы для обратного прохода

    public MaxPoolingLayer(int poolSize, int stride)
    {
        _poolSize = poolSize;
        _stride = stride;
    }

    public override object Forward(object input)
    {
        _lastInput = (SimpleTensor)input;

        int outputWidth = (_lastInput.Width - _poolSize) / _stride + 1;
        int outputHeight = (_lastInput.Height - _poolSize) / _stride + 1;
        var output = new SimpleTensor(outputWidth, outputHeight, _lastInput.Depth);
        _maxIndices = new SimpleTensor(outputWidth, outputHeight, _lastInput.Depth);

        for (int d = 0; d < _lastInput.Depth; d++)
        {
            for (int y = 0; y < outputHeight; y++)
            {
                for (int x = 0; x < outputWidth; x++)
                {
                    float maxVal = float.MinValue;
                    int maxIndexX = -1, maxIndexY = -1;

                    for (int py = 0; py < _poolSize; py++)
                    {
                        for (int px = 0; px < _poolSize; px++)
                        {
                            int inputY = y * _stride + py;
                            int inputX = x * _stride + px;
                            if (_lastInput[inputX, inputY, d] > maxVal)
                            {
                                maxVal = _lastInput[inputX, inputY, d];
                                maxIndexX = inputX;
                                maxIndexY = inputY;
                            }
                        }
                    }
                    output[x, y, d] = maxVal;
                    // Сохраняем одномерный индекс для простоты
                    _maxIndices[x, y, d] = maxIndexY * _lastInput.Width + maxIndexX;
                }
            }
        }
        return output;
    }

    public override object Backward(object outputGradientObj)
    {
        var outputGradient = (SimpleTensor)outputGradientObj;
        var inputGradient = new SimpleTensor(_lastInput.Width, _lastInput.Height, _lastInput.Depth);

        for (int d = 0; d < outputGradient.Depth; d++)
        {
            for (int y = 0; y < outputGradient.Height; y++)
            {
                for (int x = 0; x < outputGradient.Width; x++)
                {
                    float grad = outputGradient[x, y, d];
                    int flatIndex = (int)_maxIndices[x, y, d];
                    int maxIndexY = flatIndex / _lastInput.Width;
                    int maxIndexX = flatIndex % _lastInput.Width;

                    // Передаем градиент только на тот нейрон, который был максимальным
                    inputGradient[maxIndexX, maxIndexY, d] += grad;
                }
            }
        }
        return inputGradient;
    }
}