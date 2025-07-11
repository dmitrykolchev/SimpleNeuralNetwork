using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork;

// ILayer.cs
public abstract class ILayer
{
    public abstract object Forward(object input);
    public abstract object Backward(object outputGradient);
    public virtual void UpdateParameters(float learningRate) { }
}