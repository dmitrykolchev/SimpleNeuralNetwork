// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

internal static class Program
{
    private static List<(Matrix, Matrix)> _trainingData = null!;
    private static List<(Matrix, Matrix)> _testData = null!;

    static void Main()
    {
        Console.WriteLine("Loading MNIST data...");
        // Загружаем данные как обычно
        _trainingData = MnistLoader.LoadData("../../../../../mnist-data/train-images.idx3-ubyte", "../../../../../mnist-data/train-labels.idx1-ubyte");
        _testData = MnistLoader.LoadData("../../../../../mnist-data/t10k-images.idx3-ubyte", "../../../../../mnist-data/t10k-labels.idx1-ubyte");

        Console.WriteLine("Data loaded.");

        var network = new NeuralNetwork(new MeanSquaredError());

        // Архитектура CNN (похожая на LeNet)
        // Вход: 28x28x1
        network.AddLayer(new ConvolutionalLayer(
            filterCount: 6,
            filterSize: 5,
            stride: 1,
            inputDepth: 1,
            paddingType: PaddingType.Same)); // Выход: 24x24x6
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        network.AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Выход: 12x12x6

        network.AddLayer(new ConvolutionalLayer(
            filterCount: 16,
            filterSize: 5,
            stride: 1,
            inputDepth: 6,
            paddingType: PaddingType.Same)); // Выход: 8x8x16
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        network.AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Выход: 4x4x16

        network.AddLayer(new FlattenLayer()); // Выход: Matrix (256x1)

        network.AddLayer(new LinearLayer(
            inputSize: 7 * 7 * 16,
            outputSize: 120));
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        network.AddLayer(new LinearLayer(inputSize: 120, outputSize: 84));
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        network.AddLayer(new LinearLayer(inputSize: 84, outputSize: 10));

        //network.SetLossFunction();

        Console.WriteLine("Starting CNN training... This will be slow!");

        // Преобразуем входные данные в тензоры
        var cnnTrainingData = new List<(object, Matrix)>();
        foreach (var (inputMatrix, target) in _trainingData)
        {
            var inputTensor = SimpleTensor.FromMatrix(inputMatrix, 28, 28, 1);
            cnnTrainingData.Add((inputTensor, target));
        }

        // Для простоты примера, обучимся на небольшой части данных
        network.Train(cnnTrainingData.Take(2000).ToList(), epochs: 5, learningRate: 0.01f);

        Console.WriteLine("Training complete.");

        // Тестируем сеть
        var correctPredictions = 0;
        // Возьмем подмножество для тестирования, чтобы было быстрее
        var cnnTestData = _testData.Take(1000).ToList();

        foreach (var (inputMatrix, target) in cnnTestData)
        {
            var inputTensor = SimpleTensor.FromMatrix(inputMatrix, 28, 28, 1);
            // Убедимся, что Predict в NeuralNetwork также работает с object
            var prediction = (Matrix)network.Predict(inputTensor);
            if (prediction.GetPredictedClass() == target.GetPredictedClass())
            {
                correctPredictions++;
            }
        }

        var accuracy = (float)correctPredictions / cnnTestData.Count;
        Console.WriteLine($"Test Accuracy on 1000 samples: {accuracy:P2}");

        Console.WriteLine("Press 'h' for help");
        var done = false;
        var valid = true;
        while (!done)
        {
            if (valid)
            {
                Console.Write(">");
            }
            var keyInfo = Console.ReadKey(true);
            valid = true;
            switch (keyInfo.Key)
            {
                case ConsoleKey.H:
                    Console.WriteLine();
                    PrintHelp();
                    break;
                case ConsoleKey.P:
                    Console.WriteLine();
                    PrintImage();
                    break;
                case ConsoleKey.R:
                    Console.WriteLine();
                    RecognizeImage(network);
                    break;
                case ConsoleKey.Q:
                    Console.WriteLine();
                    done = true;
                    break;
                case ConsoleKey.S:
                    Console.WriteLine();
                    SaveNetwork(network);
                    break;
                case ConsoleKey.Enter:
                    Console.WriteLine();
                    break;
                default:
                    valid = false;  
                    break;
            }
        }
    }

    private static void SaveNetwork(NeuralNetwork network)
    {
        Console.WriteLine("saving isn't implemented");
    }

    private static void RecognizeImage(NeuralNetwork network)
    {
        var image = PrintImage();
        if (image >= 0)
        {
            var (inputMatrix, target) = _testData[image];
            var inputTensor = SimpleTensor.FromMatrix(inputMatrix, 28, 28, 1);
            // Убедимся, что Predict в NeuralNetwork также работает с object
            var prediction = (Matrix)network.Predict(inputTensor);
            var predictedValue = prediction.GetPredictedClass();
            if (predictedValue == target.GetPredictedClass())
            {
                Console.WriteLine($"Predicted value: {predictedValue} (valid)");
            }
            else
            {
                Console.WriteLine($"Predicted value: {predictedValue} (invalid)");
            }
        }
    }

    private static int PrintImage()
    {
        Console.Write($"Print image index from 0 to {_testData.Count - 1}: ");
        var text = Console.ReadLine();
        if (int.TryParse(text, out var value))
        {
            if (value >= 0 && value < _testData.Count)
            {
                (Matrix image, Matrix label) item = _testData[value];
                Console.WriteLine($"Label: {item.label.GetMaxIndex().row}");
                Console.WriteLine("+--------------------------------------------------------+");
                for(var y = 0; y < 28; y++)
                {
                    Console.Write("|");
                    for(var x = 0; x < 28; x++)
                    {
                        var offset = y * 28 + x;
                        var pixel = item.image[offset, 0];
                        if(pixel > 0.75f)
                        {
                            Console.Write("@@");
                        }
                        else if(pixel > 0.5f)
                        {
                            Console.Write("oo");
                        }
                        else if (pixel > 0.25f)
                        {
                            Console.Write("..");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("+--------------------------------------------------------+");
                return value;
            }
        }
        return -1;
    }

    private static void PrintHelp()
    {
        Console.WriteLine("Q - Quit");
        Console.WriteLine("H - Help");
        Console.WriteLine("P - Print image");
        Console.WriteLine("R - Recognize image");
    }
}
