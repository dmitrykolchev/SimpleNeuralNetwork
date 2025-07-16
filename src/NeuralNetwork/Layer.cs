// <copyright file="Layer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

/// <summary>
/// Layer class. The base for all kinds of layers.
/// </summary>
public abstract class Layer
{
    public abstract object Forward(object input);

    public abstract object Backward(object outputGradient);

    public virtual void UpdateParameters(float learningRate)
    {
    }
}