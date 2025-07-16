// <copyright file="Sequential.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

/// <summary>
/// Sequential layer class 
/// Implements sequential set of different layers
/// </summary>
public class Sequential : Layer
{
    private readonly List<Layer> _layers = new();

    public Sequential() { }

    public void Add(Layer layer)
    {
        _layers.Add(layer);
    }

    public void RemoveAt(int index)
    {
        _layers.RemoveAt(index);
    }

    public void Clear()
    {
        _layers.Clear();
    }

    public int Count => _layers.Count;

    public Layer this[int index] => _layers[index];

    public override object Forward(object input)
    {
        foreach (var layer in _layers)
        {
            input = layer.Forward(input);
        }
        return input;
    }

    public override object Backward(object outputGradient)
    {
        // Проходим в обратном порядке
        for (var i = _layers.Count - 1; i >= 0; i--)
        {
            outputGradient = _layers[i].Backward(outputGradient);
        }
        return outputGradient;
    }

    public override void UpdateParameters(float learningRate)
    {
        foreach (var layer in _layers)
        {
            layer.UpdateParameters(learningRate);
        }
    }
}