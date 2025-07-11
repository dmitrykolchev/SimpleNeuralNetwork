namespace NeuralNetwork;
// NeuralNetwork.cs
public class NeuralNetwork
{
    private readonly List<ILayer> _layers = new();
    private ILossFunction _lossFunction;

    public NeuralNetwork(ILossFunction lossFunction)
    {
        _lossFunction = lossFunction;
    }

    public void AddLayer(ILayer layer)
    {
        _layers.Add(layer);
    }

    public void SetLossFunction(ILossFunction lossFunction)
    {
        _lossFunction = lossFunction;
    }

    public object Predict(object input)
    {
        object output = input;
        foreach (var layer in _layers)
        {
            output = layer.Forward(output);
        }
        return output;
    }

    public void Train(List<(object input, Matrix target)> trainingData, int epochs, float learningRate)
    {
        if (_lossFunction == null)
            throw new InvalidOperationException("Loss function must be set before training.");

        for (int i = 0; i < epochs; i++)
        {
            float totalLoss = 0;
            // Перемешиваем данные для стохастичности
            trainingData = trainingData.OrderBy(x => Guid.NewGuid()).ToList();
            int count = 0;
            foreach (var (input, target) in trainingData)
            {
                // 1. Forward pass
                object output = Predict(input);

                // 2. Calculate loss and its derivative
                totalLoss += _lossFunction.Calculate((Matrix)output, (Matrix)target);
                object gradient = _lossFunction.CalculateDerivative((Matrix)output, (Matrix)target);

                // 3. Backward pass
                for (int j = _layers.Count - 1; j >= 0; j--)
                {
                    gradient = _layers[j].Backward(gradient);
                }

                // 4. Update weights and biases
                foreach (var layer in _layers)
                {
                    layer.UpdateParameters(learningRate);
                }
                if (count % 1000 == 999)
                {
                    Console.Write(".");
                }
                ++count;
            }
            Console.WriteLine($"Epoch {i + 1}/{epochs}, Loss: {totalLoss / trainingData.Count}");
        }
    }
}