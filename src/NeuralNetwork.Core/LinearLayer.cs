// <copyright file="LinearLayer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

/// <summary>
/// Linear layer class
/// </summary>
public class LinearLayer : Layer
{
    private Matrix _lastInput = null!;
    private Matrix _weightGradients = null!;
    private Matrix _biasGradients = null!;

    public LinearLayer(int inputSize, int outputSize)
    {
        Weights = Matrix.CreateRandom(outputSize, inputSize);
        Biases = Matrix.CreateRandom(outputSize, 1);
    }

    public Matrix Weights { get; private set; }

    public Matrix Biases { get; private set; }

    public override object Forward(object input)
    {
        _lastInput = (Matrix)input;
        using var temp = Matrix.Multiply(Weights, false, (Matrix)input, false);
        return Matrix.Add(temp, Biases);
    }

    public override object Backward(object outputGradient)
    {
        //_weightGradients?.Dispose();
        // Градиент для весов: dE/dW = dE/dY * X^T
        _weightGradients = Matrix.Multiply((Matrix)outputGradient, false, _lastInput, true);

        //_biasGradients?.Dispose();
        // Градиент для смещений: dE/dB = dE/dY
        _biasGradients = (Matrix)outputGradient;

        // Градиент для передачи на предыдущий слой: dE/dX = W^T * dE/dY
        return Matrix.Multiply(Weights, true, (Matrix)outputGradient, false);
    }

    public override void UpdateParameters(float learningRate)
    {
        using var w = Matrix.Multiply(_weightGradients, learningRate);
        Matrix.SubtractI(Weights, w);
        using var b = Matrix.Multiply(_biasGradients, learningRate);
        Matrix.SubtractI(Biases, b);
    }
}
