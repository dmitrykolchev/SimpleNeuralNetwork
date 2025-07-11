using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork;

// LinearLayer.cs
public class LinearLayer : ILayer
{
    public Matrix Weights { get; private set; }
    public Matrix Biases { get; private set; }

    private Matrix _lastInput;
    private Matrix _weightGradients;
    private Matrix _biasGradients;

    public LinearLayer(int inputSize, int outputSize)
    {
        Weights = new Matrix(outputSize, inputSize);
        Biases = new Matrix(outputSize, 1);
        Weights.Randomize();
        Biases.Randomize();
    }

    public override object Forward(object input)
    {
        _lastInput = (Matrix)input;
        return (Weights * (Matrix)input) + Biases;
    }

    public override object Backward(object outputGradient)
    {
        // Градиент для весов: dE/dW = dE/dY * X^T
        _weightGradients = (Matrix)outputGradient * Matrix.Transpose(_lastInput);

        // Градиент для смещений: dE/dB = dE/dY
        _biasGradients = (Matrix)outputGradient;

        // Градиент для передачи на предыдущий слой: dE/dX = W^T * dE/dY
        Matrix inputGradient = Matrix.Transpose(Weights) * (Matrix)outputGradient;

        return inputGradient;
    }

    public override void UpdateParameters(float learningRate)
    {
        Weights -= (_weightGradients * learningRate);
        Biases -= (_biasGradients * learningRate);
    }
}