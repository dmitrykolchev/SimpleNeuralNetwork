// <copyright file="MeanSquaredError.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

/// <summary>
/// Mean Square Error Loss Function
/// </summary>
public class MeanSquaredError : ILossFunction
{
    public float Calculate(Matrix predicted, Matrix actual)
    {
        using var diff = Matrix.Subtract(predicted, actual);
        float sum = 0;
        for (var i = 0; i < diff.Rows; i++)
        {
            sum += MathF.Pow(diff[i, 0], 2f);
        }
        return sum / diff.Rows;
    }

    public Matrix CalculateDerivative(Matrix predicted, Matrix actual)
    {
        // Производная MSE: 2 * (predicted - actual) / n
        using var diff = Matrix.Subtract(predicted, actual);
        return Matrix.Multiply(diff, 2.0f / actual.Rows);
    }
}
