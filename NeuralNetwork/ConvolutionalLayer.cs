namespace NeuralNetwork;
// ConvolutionalLayer.cs

public class ConvolutionalLayer : ILayer
{
    private readonly int _filterCount;
    private readonly int _filterSize;
    private readonly int _stride;

    public List<Tensor> Filters { get; private set; }
    public float[] Biases { get; private set; }

    private List<Tensor> _filterGradients;
    private float[] _biasGradients;
    private Tensor _lastInput;

    public ConvolutionalLayer(int filterCount, int filterSize, int stride, int inputDepth)
    {
        _filterCount = filterCount;
        _filterSize = filterSize;
        _stride = stride;

        Filters = new List<Tensor>();
        Biases = new float[filterCount];
        var rand = new Random();

        for (int i = 0; i < filterCount; i++)
        {
            var filter = new Tensor(filterSize, filterSize, inputDepth);
            // Инициализация Ксавье/Глорота
            filter.Randomize(filterSize * filterSize * inputDepth);
            Filters.Add(filter);
            Biases[i] = (rand.NextSingle() * 2 - 1) * MathF.Sqrt(1.0f / (filterSize * filterSize * inputDepth));
        }
    }

    public override object Forward(object input)
    {
        _lastInput = (Tensor)input;

        int outputWidth = (_lastInput.Width - _filterSize) / _stride + 1;
        int outputHeight = (_lastInput.Height - _filterSize) / _stride + 1;
        var output = new Tensor(outputWidth, outputHeight, _filterCount);

        for (int f = 0; f < _filterCount; f++) // Для каждого фильтра
        {
            for (int y = 0; y < outputHeight; y++)
            {
                for (int x = 0; x < outputWidth; x++)
                {
                    // Выполняем свертку
                    float sum = 0;
                    for (int d = 0; d < _lastInput.Depth; d++)
                        for (int fy = 0; fy < _filterSize; fy++)
                            for (int fx = 0; fx < _filterSize; fx++)
                            {
                                int inputY = y * _stride + fy;
                                int inputX = x * _stride + fx;
                                sum += _lastInput[inputX, inputY, d] * Filters[f][fx, fy, d];
                            }

                    output[x, y, f] = sum + Biases[f];
                }
            }
        }
        return output;
    }

    public override object Backward(object outputGradientObj)
    {
        var outputGradient = (Tensor)outputGradientObj;
        var inputGradient = new Tensor(_lastInput.Width, _lastInput.Height, _lastInput.Depth);

        _filterGradients = new List<Tensor>();
        for (int i = 0; i < _filterCount; i++)
            _filterGradients.Add(new Tensor(_filterSize, _filterSize, _lastInput.Depth));
        _biasGradients = new float[_filterCount];

        for (int f = 0; f < _filterCount; f++)
        {
            for (int y = 0; y < outputGradient.Height; y++)
            {
                for (int x = 0; x < outputGradient.Width; x++)
                {
                    float grad = outputGradient[x, y, f];

                    // Обновляем градиенты для фильтров и смещений
                    for (int d = 0; d < _lastInput.Depth; d++)
                        for (int fy = 0; fy < _filterSize; fy++)
                            for (int fx = 0; fx < _filterSize; fx++)
                            {
                                int inputY = y * _stride + fy;
                                int inputX = x * _stride + fx;
                                _filterGradients[f][fx, fy, d] += _lastInput[inputX, inputY, d] * grad;
                                inputGradient[inputX, inputY, d] += Filters[f][fx, fy, d] * grad;
                            }

                    _biasGradients[f] += grad;
                }
            }
        }
        return inputGradient;
    }

    public override void UpdateParameters(float learningRate)
    {
        for (int f = 0; f < _filterCount; f++)
        {
            for (int d = 0; d < Filters[f].Depth; d++)
                for (int y = 0; y < _filterSize; y++)
                    for (int x = 0; x < _filterSize; x++)
                        Filters[f][x, y, d] -= _filterGradients[f][x, y, d] * learningRate;

            Biases[f] -= _biasGradients[f] * learningRate;
        }
    }
}