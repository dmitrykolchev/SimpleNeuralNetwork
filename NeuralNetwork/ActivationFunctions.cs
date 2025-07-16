// <copyright file="ActivationFunctions.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Buffers;
using System.Numerics.Tensors;

namespace NeuralNetwork;

/// <summary>
///     Вспомогательный класс с популярными функциями активации
/// </summary>
public static class ActivationFunctions
{
    public static void Sigmoid(ReadOnlySpan<float> x, Span<float> y)
    {
        TensorPrimitives.Sigmoid(x, y);
    }

    public static void SigmoidDerivative(ReadOnlySpan<float> x, Span<float> y)
    {
        var temp = ArrayPool<float>.Shared.Rent(y.Length);
        try
        {
            var t = temp.AsSpan(0, y.Length);
            TensorPrimitives.Sigmoid(x, y);
            TensorPrimitives.Subtract(1f, y, t);
            TensorPrimitives.Multiply(y, t, y);
        }
        finally
        {
            ArrayPool<float>.Shared.Return(temp);
        }
    }

    public static void ReLU(ReadOnlySpan<float> x, Span<float> y)
    {
        TensorPrimitives.Max(x, 0f, y);
    }

    public static unsafe void ReLUDerivative(ReadOnlySpan<float> x, Span<float> y)
    {
        fixed (float* px = x, py = y)
        {
            for (var i = 0; i < x.Length; i++)
            {
                py[i] = px[i] > 0f ? 1f : 0f;
            }
        }
    }
}