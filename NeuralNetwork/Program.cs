namespace NeuralNetwork;

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // ВАЖНО: убедитесь, что все классы слоев обновлены для работы с `object`

        Console.WriteLine("Loading MNIST data...");
        // Загружаем данные как обычно
        var trainingData = MnistLoader.LoadData("../../../../mnist-data/train-images.idx3-ubyte", "../../../../mnist-data/train-labels.idx1-ubyte");
        var testData = MnistLoader.LoadData("../../../../mnist-data/t10k-images.idx3-ubyte", "../../../../mnist-data/t10k-labels.idx1-ubyte");
        Console.WriteLine("Data loaded.");

        var network = new NeuralNetwork();

        // Архитектура CNN (похожая на LeNet)
        // Вход: 28x28x1
        network.AddLayer(new ConvolutionalLayer(filterCount: 6, filterSize: 5, stride: 1, inputDepth: 1)); // Выход: 24x24x6
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        network.AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Выход: 12x12x6

        network.AddLayer(new ConvolutionalLayer(filterCount: 16, filterSize: 5, stride: 1, inputDepth: 6)); // Выход: 8x8x16
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));
        network.AddLayer(new MaxPoolingLayer(poolSize: 2, stride: 2)); // Выход: 4x4x16

        network.AddLayer(new FlattenLayer()); // Выход: Matrix (256x1)

        network.AddLayer(new LinearLayer(inputSize: 4 * 4 * 16, outputSize: 120));
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        network.AddLayer(new LinearLayer(inputSize: 120, outputSize: 84));
        network.AddLayer(new ActivationLayer(ActivationFunctions.ReLU, ActivationFunctions.ReLUDerivative));

        network.AddLayer(new LinearLayer(inputSize: 84, outputSize: 10));

        network.SetLossFunction(new MeanSquaredError());

        Console.WriteLine("Starting CNN training... This will be slow!");

        // Преобразуем входные данные в тензоры
        var cnnTrainingData = new List<(object, Matrix)>();
        foreach (var (inputMatrix, target) in trainingData)
        {
            var inputTensor = Tensor.FromMatrix(inputMatrix, 28, 28, 1);
            cnnTrainingData.Add((inputTensor, target));
        }

        // Для простоты примера, обучимся на небольшой части данных
        network.Train(cnnTrainingData, epochs: 5, learningRate: 0.01f);

        Console.WriteLine("Training complete.");

        // Тестируем сеть
        int correctPredictions = 0;
        // Возьмем подмножество для тестирования, чтобы было быстрее
        var cnnTestData = testData.Take(1000).ToList();

        foreach (var (inputMatrix, target) in cnnTestData)
        {
            var inputTensor = Tensor.FromMatrix(inputMatrix, 28, 28, 1);
            // Убедимся, что Predict в NeuralNetwork также работает с object
            Matrix prediction = (Matrix)network.Predict(inputTensor);
            if (prediction.GetPredictedClass() == target.GetPredictedClass())
            {
                correctPredictions++;
            }
        }

        float accuracy = (float)correctPredictions / cnnTestData.Count;
        Console.WriteLine($"Test Accuracy on 1000 samples: {accuracy:P2}");
    }
}