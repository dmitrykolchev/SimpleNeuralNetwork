using System.Numerics.Tensors;

namespace NeuralNetwork;
// ActivationLayer.cs
// ActivationLayer.cs
public class ActivationLayer : ILayer
{
    // ... (конструктор тот же)
    private readonly Action<ReadOnlySpan<float>, Span<float>> _activation;
    private readonly Action<ReadOnlySpan<float>, Span<float>> _activationDerivative;
    private object _lastInput;

    public ActivationLayer(
        Action<ReadOnlySpan<float>, Span<float>> activation, 
        Action<ReadOnlySpan<float>, Span<float>> activationDerivative)
    {
        _activation = activation;
        _activationDerivative = activationDerivative;
    }

    public override object Forward(object input)
    {
        _lastInput = input;
        if (input is Matrix m)
        {
            return m.Map(_activation);
        }
        if (input is Tensor t)
        {
            return t.Map(_activation);
        }
        throw new ArgumentException("Unsupported input type for ActivationLayer");
    }

    public override object Backward(object outputGradient)
    {
        if (_lastInput is Matrix lastInputM && outputGradient is Matrix gradM)
        {
            Matrix activationDerivative = lastInputM.Map(_activationDerivative);
            return Matrix.Hadamard(gradM, activationDerivative);
        }
        if (_lastInput is Tensor lastInputT && outputGradient is Tensor gradT)
        {
            var result = lastInputT.Map(_activationDerivative);
            Tensor.Hadamard(gradT, result, result);
            return result;
        }
        throw new ArgumentException("Unsupported input type for ActivationLayer backward pass");
    }
}