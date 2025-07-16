namespace NeuralNetwork;
// CompositeLayer.cs

public class SequentialLayer : Layer
{
    private readonly List<Layer> _layers = new List<Layer>();

    public void AddLayer(Layer layer)
    {
        _layers.Add(layer);
    }

    public override object Forward(object input)
    {
        foreach (var layer in _layers)
        {
            input = layer.Forward(input);
        }
        return input;
    }

    public override object Backward(object outputGradient)
    {
        // Проходим в обратном порядке
        for (int i = _layers.Count - 1; i >= 0; i--)
        {
            outputGradient = _layers[i].Backward(outputGradient);
        }
        return outputGradient;
    }

    public override void UpdateParameters(float learningRate)
    {
        foreach (var layer in _layers)
        {
            layer.UpdateParameters(learningRate);
        }
    }
}