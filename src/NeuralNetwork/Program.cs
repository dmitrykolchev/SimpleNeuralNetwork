// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

internal static class Program
{
    private static List<(Matrix, Matrix)> _trainingData = null!;
    private static List<(Matrix, Matrix)> _testData = null!;
    private static NeuralNetwork _network = null!;
    private static float _learningRate = 0.01f;

    static void Main()
    {
        Console.WriteLine("Press 'h' for help");

        var done = false;
        while (!done)
        {
            Console.Write("CNN>");
            try
            {
                var commandText = Console.ReadLine();
                var command = CommandInfo.Parse(commandText);
                switch (command.Command)
                {
                    case CommandType.Clear:
                        Console.Clear();
                        Console.WriteLine("Press 'h' for help");
                        break;
                    case CommandType.Help:
                        PrintHelp();
                        break;
                    case CommandType.SetLearningRate:
                        _learningRate = MathF.Min(1, MathF.Max(0, (float)command.Arguments[0]));
                        Console.WriteLine($"Learning rate: {_learningRate}");
                        break;
                    case CommandType.PrintImage:
                        if (_network == null)
                        {
                            throw new InvalidOperationException("Invalid NN state. Please train network first");
                        }
                        PrintImage(command.Arguments);
                        break;
                    case CommandType.RecognizeImage:
                        if (_network == null)
                        {
                            throw new InvalidOperationException("Invalid NN state. Please train network first");
                        }
                        RecognizeImage(_network, command.Arguments);
                        break;
                    case CommandType.Quit:
                        done = true;
                        break;
                    case CommandType.SaveNetwork:
                        if (_network == null)
                        {
                            throw new InvalidOperationException("Invalid NN state. Please train network first");
                        }
                        SaveNetwork(_network);
                        break;
                    case CommandType.LoadNetwork:
                        _network = LoadNetwork(command.Arguments);
                        break;
                    case CommandType.TrainNetwork:
                        _network = TrainNetwork(command.Arguments);
                        break;
                    case CommandType.None:
                        break;
                    case CommandType.Invalid:
                        throw new InvalidOperationException("Unknown command or invalid parameter");
                    default:
                        throw new InvalidOperationException($"Unknown command {command.Command}");
                }
            }
            catch (Exception ex)
            {
                var color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = color;
            }
        }
    }

    private static void LoadMnistDataset()
    {
        if (_trainingData == null)
        {
            Console.WriteLine("Loading MNIST data...");
            // Загружаем данные как обычно
            _trainingData = MnistLoader.LoadData("../../../../../../mnist-data/train-images.idx3-ubyte", "../../../../../../mnist-data/train-labels.idx1-ubyte");
            Console.WriteLine($"Traning dataset: {_trainingData.Count} images");
            _testData = MnistLoader.LoadData("../../../../../../mnist-data/t10k-images.idx3-ubyte", "../../../../../../mnist-data/t10k-labels.idx1-ubyte");
            Console.WriteLine($"Test dataset: {_testData.Count} images");
            Console.WriteLine("Data loaded.");
        }
    }

    private static NeuralNetwork LoadNetwork(List<object>? arguments)
    {
        throw new NotImplementedException();
    }

    private static NeuralNetwork TrainNetwork(List<object>? args)
    {
        LoadMnistDataset();

        Console.WriteLine("Initializing CNN");

        var network = new MnistCnn();

        Console.WriteLine("Starting CNN training... This will be slow!");

        // Преобразуем входные данные в тензоры
        var cnnTrainingData = new List<(object, Matrix)>();
        foreach (var (inputMatrix, target) in _trainingData)
        {
            var inputTensor = Tensor.FromMatrix(inputMatrix, 28, 28, 1);
            cnnTrainingData.Add((inputTensor, target));
        }

        if (args?.Count == 1)
        {
            network.Train(cnnTrainingData.Take((int)args[0]).ToList(), epochs: 5, learningRate: _learningRate);
        }
        else
        {
            network.Train(cnnTrainingData, epochs: 5, learningRate: _learningRate);
        }

        Console.WriteLine("Training complete.");

        // Тестируем сеть
        var correctPredictions = 0;
        // Возьмем подмножество для тестирования, чтобы было быстрее
        var cnnTestData = _testData.Take(1000).ToList();

        foreach (var (inputMatrix, target) in cnnTestData)
        {
            var inputTensor = Tensor.FromMatrix(inputMatrix, 28, 28, 1);
            // Убедимся, что Predict в NeuralNetwork также работает с object
            var prediction = (Matrix)network.Predict(inputTensor);
            if (prediction.GetPredictedClass() == target.GetPredictedClass())
            {
                correctPredictions++;
            }
        }

        var accuracy = (float)correctPredictions / cnnTestData.Count;
        Console.WriteLine($"Test Accuracy on 1000 samples: {accuracy:P2}");
        return network;
    }

    private static void SaveNetwork(NeuralNetwork _)
    {
        Console.WriteLine("saving isn't implemented");
    }

    private static void RecognizeImage(NeuralNetwork network, List<object>? args)
    {
        if (args?.Count == 1)
        {
            var imageIndex = PrintImage(args);
            RecognizeImage(network, imageIndex);
        }
        else
        {
            var imageIndex = PrintImage([]);
            if (imageIndex >= 0)
            {
                RecognizeImage(network, imageIndex);
            }
        }
    }

    private static void RecognizeImage(NeuralNetwork network, int imageIndex)
    {
        var (inputMatrix, target) = _testData[imageIndex];
        var inputTensor = Tensor.FromMatrix(inputMatrix, 28, 28, 1);
        // Убедимся, что Predict в NeuralNetwork также работает с object
        var prediction = (Matrix)network.Predict(inputTensor);
        var predictedValue = prediction.GetPredictedClass();
        if (predictedValue == target.GetPredictedClass())
        {
            Console.WriteLine($"Predicted value: {predictedValue} (valid)");
        }
        else
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Predicted value: {predictedValue} (invalid)");
            Console.ForegroundColor = color;
        }
    }

    private static int PrintImage(List<object>? args)
    {
        if (args?.Count == 1)
        {
            PrintImage((int)args[0]);
            return (int)args[0];
        }
        else
        {
            Console.Write($"Image index (0 to {_testData.Count - 1}): ");
            var text = Console.ReadLine();
            if (int.TryParse(text, out var value))
            {
                if (value >= 0 && value < _testData.Count)
                {
                    PrintImage(value);
                    return value;
                }
            }
        }
        return -1;
    }

    private static void PrintImage(Matrix image)
    {
        Console.WriteLine("+--------------------------------------------------------+");
        for (var y = 0; y < 28; y++)
        {
            Console.Write("|");
            for (var x = 0; x < 28; x++)
            {
                var offset = y * 28 + x;
                var pixel = image[offset, 0];
                if (pixel > 0.75f)
                {
                    Console.Write("@@");
                }
                else if (pixel > 0.5f)
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
    }

    private static void PrintImage(int imageIndex)
    {
        var (image, label) = _testData[imageIndex];
        Console.WriteLine($"Label: {label.GetMaxIndex().row}");
        PrintImage(image);
    }

    private static void PrintHelp()
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(" H                  - Print [H]elp information");
        Console.WriteLine(" C                  - [C]lear screen");
        Console.WriteLine(" P [ImageIndex]     - [P]rint image");
        Console.WriteLine(" R [ImageIndex]     - [R]ecognize image");
        Console.WriteLine(" T [NumberOfImages] - [T]rain neural network");
        Console.WriteLine(" S [Filename]       - [S]ave NN parameters");
        Console.WriteLine(" L [FileName]       - [L]oad NN parameters");
        Console.WriteLine(" LR [0.01]          - Set [L]earning [R]ate");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(" Q                  - [Q]uit");
        Console.WriteLine("-----------------------------------------------");
        Console.ForegroundColor = color;
    }
}
