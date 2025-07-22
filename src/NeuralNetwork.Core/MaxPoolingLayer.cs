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
    private Tensor _lastInput = null!;
    private Tensor _maxIndices = null!; // Сохраняем индексы для обратного прохода

    public MaxPoolingLayer(int poolSize, int stride)
    {
        _poolSize = poolSize;
        _stride = stride;
    }

    public override object Forward(object input)
    {
        _lastInput = (Tensor)input;

        var outputWidth = (_lastInput.Width - _poolSize) / _stride + 1;
        var outputHeight = (_lastInput.Height - _poolSize) / _stride + 1;
        var output = new Tensor(outputWidth, outputHeight, _lastInput.Depth);
        _maxIndices = new Tensor(outputWidth, outputHeight, _lastInput.Depth);

        for (var d = 0; d < _lastInput.Depth; d++)
        //Parallel.For(0, _lastInput.Depth, (d) =>
        {
            for (var y = 0; y < outputHeight; y++)
            {
                for (var x = 0; x < outputWidth; x++)
                {
                    var maxVal = float.MinValue;
                    int maxIndexX = -1, maxIndexY = -1;
                    var sx = x * _stride;
                    var sy = y * _stride;
                    for (var py = 0; py < _poolSize; py++)
                    {
                        var inputY = sy + py;

                        for (var px = 0; px < _poolSize; px++)
                        {
                            var inputX = sx + px;
                            var value = _lastInput[inputX, inputY, d];
                            if (value > maxVal)
                            {
                                maxVal = value;
                                maxIndexX = inputX;
                                maxIndexY = inputY;
                            }
                        }
                    }
                    Debug.Assert(maxIndexX >= 0 && maxIndexY >= 0);
                    var index = (x * output.Width + y) * output.Depth + d;
                    output[index] = maxVal;
                    // Сохраняем одномерный индекс для простоты
                    _maxIndices[index] = maxIndexY * _lastInput.Width + maxIndexX;
                }
            }
        }//);
        return output;
    }

    public override object Backward(object outputGradientObj)
    {
        var outputGradient = (Tensor)outputGradientObj;
        var inputGradient = new Tensor(_lastInput.Width, _lastInput.Height, _lastInput.Depth);

        for (var d = 0; d < outputGradient.Depth; d++)
        //Parallel.For(0, outputGradient.Depth, (d) =>
        {
            for (var y = 0; y < outputGradient.Height; y++)
            {
                for (var x = 0; x < outputGradient.Width; x++)
                {
                    var index = (x * outputGradient.Width + y) * outputGradient.Depth + d;
                    var grad = outputGradient[index];
                    var flatIndex = (int)_maxIndices[index];
                    var (maxIndexY, maxIndexX) = Math.DivRem(flatIndex, _lastInput.Width);
                    // Передаем градиент только на тот нейрон, который был максимальным
                    inputGradient[maxIndexX, maxIndexY, d] += grad;
                }
            }
        }//);
        return inputGradient;
    }
}
