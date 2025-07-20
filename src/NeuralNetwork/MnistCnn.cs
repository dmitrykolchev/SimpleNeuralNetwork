// <copyright file="MnistCnn.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

internal class MnistCnn : NeuralNetwork
{
    public MnistCnn() : base(new MeanSquaredError())
    {
        // Архитектура CNN (похожая на LeNet)
        // Вход: 28x28x1 (784)
        AddLayer(new ConvolutionalLayer(
            filterCount: 6,
            filterSize: 5,
            stride: 1,
            inputDepth: 1,
            paddingType: PaddingType.Same)); // Выход: 28x28x6
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Вход: 28x28x6 -> Выход: 14x14x6

        AddLayer(new ConvolutionalLayer(
            filterCount: 16,
            filterSize: 5,
            stride: 1,
            inputDepth: 6,
            paddingType: PaddingType.Same)); // Выход: 14x14x16
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Вход: 14x14x16 -> Выход: 7x7x16

        AddLayer(new FlattenLayer()); // Вход: 7x7x16 -> Выход: Matrix (784x1)

        AddLayer(new LinearLayer(
            inputSize: 7 * 7 * 16,
            outputSize: 131));
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        AddLayer(new LinearLayer(inputSize: 131, outputSize: 73));
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        AddLayer(new LinearLayer(inputSize: 73, outputSize: 10));
    }
}
