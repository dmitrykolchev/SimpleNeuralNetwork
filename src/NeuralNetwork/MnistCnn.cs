// <copyright file="MnistCnn.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;

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

    public override void Train(List<(object input, Matrix target)> trainingData, int epochs, float learningRate)
    {
        if (LossFunction == null)
        {
            throw new InvalidOperationException("Loss function must be set before training.");
        }

        for (var i = 0; i < epochs; i++)
        {
            float totalLoss = 0;
            // Перемешиваем данные для стохастичности
            trainingData = trainingData.OrderBy(x => Guid.NewGuid()).ToList();
            var count = 0;
            var stopwatch = Stopwatch.StartNew();
            foreach (var (input, target) in trainingData)
            {
                // 1. Forward pass
                var output = Predict(input);

                // 2. Calculate loss and its derivative
                totalLoss += LossFunction.Calculate((Matrix)output, (Matrix)target);
                object gradient = LossFunction.CalculateDerivative((Matrix)output, (Matrix)target);

                // 3. Backward pass
                for (var j = Layers.Count - 1; j >= 0; j--)
                {
                    gradient = Layers[j].Backward(gradient);
                }

                // 4. Update weights and biases
                foreach (var layer in Layers)
                {
                    layer.UpdateParameters(learningRate);
                }
                ++count;
                if (count % 578 == 577)
                {
                    var remainingTime = (double)((trainingData.Count - count) * stopwatch.ElapsedMilliseconds) / count / 1000.0;
                    var elapsedTime = (double)(stopwatch.ElapsedMilliseconds) / 1000.0;
                    Console.Write($"\r{count,6}, {(double)stopwatch.ElapsedMilliseconds / count:f2} ms per image, ET: {TimeSpan.FromSeconds(elapsedTime)}, RT: {TimeSpan.FromSeconds(remainingTime)}");
                }
            }
            Console.Write($"\r{count,6}, {(double)stopwatch.ElapsedMilliseconds / count:f2} ms per image, ET: {TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds)}");
            Console.WriteLine($" -> Epoch {i + 1}/{epochs}, Loss: {totalLoss / trainingData.Count}");
        }
    }

}
