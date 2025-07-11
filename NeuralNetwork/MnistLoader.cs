using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork;
// MnistLoader.cs
using System.IO;

public static class MnistLoader
{
    public static List<(Matrix, Matrix)> LoadData(string imageFile, string labelFile)
    {
        var data = new List<(Matrix, Matrix)>();

        using var imageStream = new FileStream(imageFile, FileMode.Open);
        using var labelStream = new FileStream(labelFile, FileMode.Open);
        using var imageReader = new BinaryReader(imageStream);
        using var labelReader = new BinaryReader(labelStream);

        // Пропускаем заголовки
        imageReader.ReadInt32(); // magic number
        int numImages = SwapEndianness(imageReader.ReadInt32());
        int rows = SwapEndianness(imageReader.ReadInt32());
        int cols = SwapEndianness(imageReader.ReadInt32());

        labelReader.ReadInt32(); // magic number
        int numLabels = SwapEndianness(labelReader.ReadInt32());

        if (numImages != numLabels)
            throw new IOException("Image and label file counts do not match.");

        for (int i = 0; i < numImages; i++)
        {
            // Читаем изображение
            var pixels = new float[rows * cols];
            for (int j = 0; j < rows * cols; j++)
            {
                // Нормализуем пиксели от 0-255 до 0-1
                pixels[j] = imageReader.ReadByte() / 255.0f;
            }
            Matrix input = Matrix.CreateVector(pixels);

            // Читаем метку и преобразуем в one-hot вектор
            byte label = labelReader.ReadByte();
            var targetData = new float[10];
            targetData[label] = 1.0f;
            Matrix target = Matrix.CreateVector(targetData);

            data.Add((input, target));
        }

        return data;
    }

    // Данные в файлах MNIST хранятся в формате big-endian
    private static int SwapEndianness(int value)
    {
        var b1 = (value >> 0) & 0xff;
        var b2 = (value >> 8) & 0xff;
        var b3 = (value >> 16) & 0xff;
        var b4 = (value >> 24) & 0xff;
        return b1 << 24 | b2 << 16 | b3 << 8 | b4 << 0;
    }
}