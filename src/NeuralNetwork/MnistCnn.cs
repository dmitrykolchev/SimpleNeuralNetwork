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
        // Вход: 28x28x1
        AddLayer(new ConvolutionalLayer(
            filterCount: 6,
            filterSize: 5,
            stride: 1,
            inputDepth: 1,
            paddingType: PaddingType.Same)); // Выход: 24x24x6
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Выход: 12x12x6

        AddLayer(new ConvolutionalLayer(
            filterCount: 16,
            filterSize: 5,
            stride: 1,
            inputDepth: 6,
            paddingType: PaddingType.Same)); // Выход: 8x8x16
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Выход: 4x4x16

        AddLayer(new FlattenLayer()); // Выход: Matrix (256x1)

        AddLayer(new LinearLayer(
            inputSize: 7 * 7 * 16,
            outputSize: 131));
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        AddLayer(new LinearLayer(inputSize: 131, outputSize: 73));
        AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        AddLayer(new LinearLayer(inputSize: 73, outputSize: 10));
    }
}
