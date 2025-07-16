namespace NeuralNetwork;

/// <summary>
/// Layer class. The base for all kinds of layers.
/// </summary>
public abstract class Layer
{
    public abstract object Forward(object input);

    public abstract object Backward(object outputGradient);

    public virtual void UpdateParameters(float learningRate) 
    { 
    }
}