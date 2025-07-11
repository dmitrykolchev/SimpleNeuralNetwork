using System.Buffers;
using System.Numerics.Tensors;

namespace NeuralNetwork;
// Вспомогательный класс с популярными функциями активации
public static class ActivationFunctions
{
    public static void Sigmoid(ReadOnlySpan<float> x, Span<float> y)
    {
        TensorPrimitives.Sigmoid(x, y);
    }

    public static void SigmoidDerivative(ReadOnlySpan<float> x, Span<float> y)
    {
        var temp = ArrayPool<float>.Shared.Rent(y.Length);
        var t = temp.AsSpan(0, y.Length);
        TensorPrimitives.Sigmoid(x, y);
        TensorPrimitives.Subtract(1f, y, t);
        TensorPrimitives.Multiply(y, t, y);
        ArrayPool<float>.Shared.Return(temp);
    }

    public static void ReLU(ReadOnlySpan<float> x, Span<float> y)
    {
        TensorPrimitives.Max(x, 0f, y);
    }

    public unsafe static void ReLUDerivative(ReadOnlySpan<float> x, Span<float> y)
    {
        fixed(float* px = x, py = y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                py[i] = px[i] > 0f ? 1f : 0f;   
            }
        }
    }
}