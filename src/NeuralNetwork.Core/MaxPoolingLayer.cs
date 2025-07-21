// <copyright file="MaxPoolingLayer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;

namespace NeuralNetwork;

/// <summary>
/// MaxPooling layer class
/// </summary>
public class MaxPoolingLayer : Layer
{
    private readonly int _poolSize;
    private readonly int _stride;
    private SimpleTensor _lastInput = null!;
    private SimpleTensor _maxIndices = null!; // Сохраняем индексы для обратного прохода

    public MaxPoolingLayer(int poolSize, int stride)
    {
        _poolSize = poolSize;
        _stride = stride;
    }

    public override object Forward(object input)
    {
        _lastInput = (SimpleTensor)input;

        var outputWidth = (_lastInput.Width - _poolSize) / _stride + 1;
        var outputHeight = (_lastInput.Height - _poolSize) / _stride + 1;
        var output = new SimpleTensor(outputWidth, outputHeight, _lastInput.Depth);
        _maxIndices = new SimpleTensor(outputWidth, outputHeight, _lastInput.Depth);

        for (var d = 0; d < _lastInput.Depth; d++)
        {
            for (var y = 0; y < outputHeight; y++)
            {
                for (var x = 0; x < outputWidth; x++)
                {
                    var maxVal = float.MinValue;
                    int maxIndexX = -1, maxIndexY = -1;

                    for (var py = 0; py < _poolSize; py++)
                    {
                        for (var px = 0; px < _poolSize; px++)
                        {
                            var inputY = y * _stride + py;
                            var inputX = x * _stride + px;
                            if (_lastInput[inputX, inputY, d] > maxVal)
                            {
                                maxVal = _lastInput[inputX, inputY, d];
                                maxIndexX = inputX;
                                maxIndexY = inputY;
                            }
                        }
                    }
                    Debug.Assert(maxIndexX >= 0 && maxIndexY >= 0);
                    output[x, y, d] = maxVal;
                    // Сохраняем одномерный индекс для простоты
                    _maxIndices[x, y, d] = maxIndexY * _lastInput.Width + maxIndexX;
                }
            }
        }
        return output;
    }

    public override object Backward(object outputGradientObj)
    {
        var outputGradient = (SimpleTensor)outputGradientObj;
        var inputGradient = new SimpleTensor(_lastInput.Width, _lastInput.Height, _lastInput.Depth);

        for (var d = 0; d < outputGradient.Depth; d++)
        {
            for (var y = 0; y < outputGradient.Height; y++)
            {
                for (var x = 0; x < outputGradient.Width; x++)
                {
                    var grad = outputGradient[x, y, d];
                    var flatIndex = (int)_maxIndices[x, y, d];
                    var maxIndexY = flatIndex / _lastInput.Width;
                    var maxIndexX = flatIndex % _lastInput.Width;

                    // Передаем градиент только на тот нейрон, который был максимальным
                    inputGradient[maxIndexX, maxIndexY, d] += grad;
                }
            }
        }
        return inputGradient;
    }
}
