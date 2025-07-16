using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace NeuralNetwork;

// LinearLayer.cs
public class LinearLayer : Layer
{
    private Matrix _lastInput = null!;
    private Matrix _weightGradients = null!;
    private Matrix _biasGradients = null!;

    public LinearLayer(int inputSize, int outputSize)
    {
        Weights = new Matrix(outputSize, inputSize);
        Biases = new Matrix(outputSize, 1);
        Weights.Randomize();
        Biases.Randomize();
    }

    public Matrix Weights { get; private set; }

    public Matrix Biases { get; private set; }

    public override object Forward(object input)
    {
        _lastInput = (Matrix)input;
        return Matrix.Multiply(Weights, false, (Matrix)input, false) + Biases;
    }

    public override object Backward(object outputGradient)
    {
        // Градиент для весов: dE/dW = dE/dY * X^T
        _weightGradients = Matrix.Multiply((Matrix)outputGradient, false, _lastInput, true);

        // Градиент для смещений: dE/dB = dE/dY
        _biasGradients = (Matrix)outputGradient;

        // Градиент для передачи на предыдущий слой: dE/dX = W^T * dE/dY
        Matrix inputGradient = Matrix.Multiply(Weights, true, (Matrix)outputGradient, false);

        return inputGradient;
    }

    public override void UpdateParameters(float learningRate)
    {
        Weights -= (_weightGradients * learningRate);
        Biases -= (_biasGradients * learningRate);
    }
}