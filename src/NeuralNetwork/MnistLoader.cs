// <copyright file="MnistLoader.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>
using System.Numerics;

namespace NeuralNetwork;

/// <summary>
/// Loader for MNIST dataset
/// </summary>
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
        var numImages = SwapEndianness(imageReader.ReadInt32());
        var rows = SwapEndianness(imageReader.ReadInt32());
        var cols = SwapEndianness(imageReader.ReadInt32());

        labelReader.ReadInt32(); // magic number
        var numLabels = SwapEndianness(labelReader.ReadInt32());

        if (numImages != numLabels)
        {
            throw new IOException("Image and label file counts do not match.");
        }

        for (var i = 0; i < numImages; i++)
        {
            // Читаем изображение
            var pixels = new float[rows * cols];
            for (var j = 0; j < rows * cols; j++)
            {
                // Нормализуем пиксели от 0-255 до 0-1
                pixels[j] = imageReader.ReadByte() / 255.0f;
            }
            var input = Matrix.CreateVector(pixels);

            // Читаем метку и преобразуем в one-hot вектор
            var label = labelReader.ReadByte();
            var targetData = new float[10];
            targetData[label] = 1.0f;
            var target = Matrix.CreateVector(targetData);

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
