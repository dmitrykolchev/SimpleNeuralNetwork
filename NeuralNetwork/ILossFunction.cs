// <copyright file="ILossFunction.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

// ILossFunction.cs
public interface ILossFunction
{
    float Calculate(Matrix predicted, Matrix actual);
    Matrix CalculateDerivative(Matrix predicted, Matrix actual);
}