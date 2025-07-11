namespace NeuralNetwork;
// ActivationLayer.cs
// ActivationLayer.cs
public class ActivationLayer : ILayer
{
    // ... (конструктор тот же)
    private readonly Func<float, float> _activation;
    private readonly Func<float, float> _activationDerivative;
    private object _lastInput;

    public ActivationLayer(Func<float, float> activation, Func<float, float> activationDerivative)
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
            var result = new Tensor(lastInputT.Width, lastInputT.Height, lastInputT.Depth);
            for (int d = 0; d < lastInputT.Depth; d++)
                for (int h = 0; h < lastInputT.Height; h++)
                    for (int w = 0; w < lastInputT.Width; w++)
                    {
                        var derivative = _activationDerivative(lastInputT[w, h, d]);
                        result[w, h, d] = gradT[w, h, d] * derivative;
                    }
            return result;
        }
        throw new ArgumentException("Unsupported input type for ActivationLayer backward pass");
    }
}