namespace NeuralNetwork;
// FlattenLayer.cs
public class FlattenLayer : ILayer
{
    private int _lastInputWidth, _lastInputHeight, _lastInputDepth;

    public override object Forward(object input)
    {
        if (input is Tensor t)
        {
            _lastInputWidth = t.Width;
            _lastInputHeight = t.Height;
            _lastInputDepth = t.Depth;
            return t.ToMatrix();
        }
        throw new ArgumentException("FlattenLayer only accepts Tensors.");
    }

    public override object Backward(object outputGradient)
    {
        if (outputGradient is Matrix m)
        {
            return Tensor.FromMatrix(m, _lastInputWidth, _lastInputHeight, _lastInputDepth);
        }
        throw new ArgumentException("FlattenLayer backward pass only accepts Matrices.");
    }
}