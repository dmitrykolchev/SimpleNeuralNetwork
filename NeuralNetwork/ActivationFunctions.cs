namespace NeuralNetwork;
// Вспомогательный класс с популярными функциями активации
public static class ActivationFunctions
{
    public static float Sigmoid(float x) => 1.0f / (1.0f + MathF.Exp(-x));
    public static float SigmoidDerivative(float x) => Sigmoid(x) * (1 - Sigmoid(x));
    public static float ReLU(float x) => MathF.Max(0, x);
    public static float ReLUDerivative(float x) => x > 0 ? 1 : 0;
}