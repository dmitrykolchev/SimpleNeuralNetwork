using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork;

// ILossFunction.cs
public interface ILossFunction
{
    float Calculate(Matrix predicted, Matrix actual);
    Matrix CalculateDerivative(Matrix predicted, Matrix actual);
}