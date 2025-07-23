// <copyright file="NeuralNetwork.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

/// <summary>
/// Neural network class
/// </summary>
public abstract class NeuralNetwork
{
    private readonly List<Layer> _layers = new();
    private ILossFunction _lossFunction;

    public NeuralNetwork(ILossFunction lossFunction)
    {
        ArgumentNullException.ThrowIfNull(lossFunction);
        _lossFunction = lossFunction;
    }

    public List<Layer> Layers => _layers;

    public void AddLayer(Layer layer)
    {
        _layers.Add(layer);
    }

    public void SetLossFunction(ILossFunction lossFunction)
    {
        _lossFunction = lossFunction;
    }

    public ILossFunction LossFunction => _lossFunction;

    public object Predict(object input)
    {
        var output = input;
        foreach (var layer in _layers)
        {
            output = layer.Forward(output);
        }
        return output;
    }

    public abstract void Train(List<(object input, Matrix target)> trainingData, int epochs, float learningRate);
}
