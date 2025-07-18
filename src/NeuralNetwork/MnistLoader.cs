// <copyright file="MnistLoader.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>
using System.Buffers.Binary;
using System.Numerics.Tensors;

namespace NeuralNetwork;

/// <summary>
/// Loader for MNIST dataset
/// </summary>
public static class MnistLoader
{
    // Данные в файлах MNIST хранятся в формате big-endian
    public static List<(Matrix, Matrix)> LoadData(string imageFile, string labelFile)
    {
        var data = new List<(Matrix, Matrix)>();

        using var imageStream = new FileStream(imageFile, FileMode.Open);
        using var labelStream = new FileStream(labelFile, FileMode.Open);
        using var imageReader = new BinaryReader(imageStream);
        using var labelReader = new BinaryReader(labelStream);

        // Пропускаем заголовки
        imageReader.ReadInt32(); // magic number
        var numImages = BinaryPrimitives.ReverseEndianness(imageReader.ReadInt32());
        var rows = BinaryPrimitives.ReverseEndianness(imageReader.ReadInt32());
        var cols = BinaryPrimitives.ReverseEndianness(imageReader.ReadInt32());

        labelReader.ReadInt32(); // magic number
        var numLabels = BinaryPrimitives.ReverseEndianness(labelReader.ReadInt32());

        if (numImages != numLabels)
        {
            throw new IOException("Image and label file counts do not match.");
        }

        var pixels = new float[rows * cols];
        var bytes = new byte[rows * cols];
        for (var i = 0; i < numImages; i++)
        {
            // Читаем изображение
            imageReader.Read(bytes, 0, bytes.Length);
            TensorPrimitives.ConvertSaturating<byte, float>(bytes, pixels);
            TensorPrimitives.Divide(pixels, 255f, pixels);
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
}
