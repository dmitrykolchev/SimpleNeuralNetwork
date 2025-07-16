// <copyright file="ActivationLayer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

/// <summary>
/// Activation layer class
/// </summary>
public class ActivationLayer : Layer
{
    private readonly Action<ReadOnlySpan<float>, Span<float>> _activation;
    private readonly Action<ReadOnlySpan<float>, Span<float>> _activationDerivative;
    private object _lastInput = null!;

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
        if (input is SimpleTensor t)
        {
            return t.Map(_activation);
        }
        throw new ArgumentException("Unsupported input type for ActivationLayer");
    }

    public override object Backward(object outputGradient)
    {
        if (_lastInput is Matrix lastInputM && outputGradient is Matrix gradM)
        {
            var activationDerivative = lastInputM.Map(_activationDerivative);
            return Matrix.Hadamard(gradM, activationDerivative);
        }
        if (_lastInput is SimpleTensor lastInputT && outputGradient is SimpleTensor gradT)
        {
            var result = lastInputT.Map(_activationDerivative);
            SimpleTensor.Hadamard(gradT, result, result);
            return result;
        }
        throw new ArgumentException("Unsupported input type for ActivationLayer backward pass");
    }
}