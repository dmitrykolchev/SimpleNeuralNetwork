// <copyright file="NeuralNetwork.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;

namespace NeuralNetwork;

/// <summary>
/// Neural network class
/// </summary>
public class NeuralNetwork
{
    private readonly List<Layer> _layers = new();
    private ILossFunction _lossFunction;

    public NeuralNetwork(ILossFunction lossFunction)
    {
        ArgumentNullException.ThrowIfNull(lossFunction);
        _lossFunction = lossFunction;
    }

    public void AddLayer(Layer layer)
    {
        _layers.Add(layer);
    }

    public void SetLossFunction(ILossFunction lossFunction)
    {
        _lossFunction = lossFunction;
    }

    public object Predict(object input)
    {
        var output = input;
        foreach (var layer in _layers)
        {
            output = layer.Forward(output);
        }
        return output;
    }

    public void Train(List<(object input, Matrix target)> trainingData, int epochs, float learningRate)
    {
        if (_lossFunction == null)
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
                totalLoss += _lossFunction.Calculate((Matrix)output, (Matrix)target);
                object gradient = _lossFunction.CalculateDerivative((Matrix)output, (Matrix)target);

                // 3. Backward pass
                for (var j = _layers.Count - 1; j >= 0; j--)
                {
                    gradient = _layers[j].Backward(gradient);
                }

                // 4. Update weights and biases
                foreach (var layer in _layers)
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
