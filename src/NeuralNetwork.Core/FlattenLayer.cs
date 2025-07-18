// <copyright file="FlattenLayer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

/// <summary>
/// Flatten layer class
/// </summary>
public class FlattenLayer : Layer
{
    private int _lastInputWidth, _lastInputHeight, _lastInputDepth;

    /// <inheritdoc/>
    public override object Forward(object input)
    {
        if (input is SimpleTensor t)
        {
            _lastInputWidth = t.Width;
            _lastInputHeight = t.Height;
            _lastInputDepth = t.Depth;
            return t.ToMatrix();
        }
        throw new ArgumentException("FlattenLayer only accepts Tensors.");
    }

    /// <inheritdoc/>
    public override object Backward(object outputGradient)
    {
        if (outputGradient is Matrix m)
        {
            return SimpleTensor.FromMatrix(m, _lastInputWidth, _lastInputHeight, _lastInputDepth);
        }
        throw new ArgumentException("FlattenLayer backward pass only accepts Matrices.");
    }
}
