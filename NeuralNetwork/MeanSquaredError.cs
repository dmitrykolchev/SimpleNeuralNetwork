using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork;
// MeanSquaredError.cs
public class MeanSquaredError : ILossFunction
{
    public float Calculate(Matrix predicted, Matrix actual)
    {
        Matrix diff = predicted - actual;
        float sum = 0;
        for (int i = 0; i < diff.Rows; i++)
        {
            sum += MathF.Pow(diff[i, 0], 2f);
        }
        return sum / diff.Rows;
    }

    public Matrix CalculateDerivative(Matrix predicted, Matrix actual)
    {
        // Производная MSE: 2 * (predicted - actual) / n
        return (predicted - actual) * (2.0f / actual.Rows);
    }
}