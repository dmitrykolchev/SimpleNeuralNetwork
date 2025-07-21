// <copyright file="SimpleTensor.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;
using System.Numerics.Tensors;
using System.Runtime.CompilerServices;

namespace NeuralNetwork;

/// <summary>
/// Представляет 3D-тензор, использующий неуправляемую выровненную память для высокой производительности.
/// КРИТИЧЕСКИ ВАЖНО: Объекты этого класса ДОЛЖНЫ быть освобождены через Dispose() или блок using,
/// чтобы избежать утечек нативной памяти.
/// </summary>
[DebuggerDisplay("(w:{Width}, h:{Height}, d:{Depth}), size:{Size}")]
public sealed unsafe class SimpleTensor : IDisposable
{
    // Сделан internal для эффективного взаимодействия с другими unsafe классами (Matrix).
    internal readonly float[] _data = null!;
    private bool _disposed;

    public SimpleTensor(int width, int height, int depth)
    {
        if (width <= 0 || height <= 0 || depth <= 0)
        {
            throw new ArgumentException("Tensor dimensions cannot be negative.");
        }

        Width = width;
        Height = height;
        Depth = depth;
        Size = width * height * depth;
        _data = new float[Size];
    }

    public readonly int Width;
    public readonly int Height;
    public readonly int Depth;
    public readonly int Size;

    public Span<float> this[int w, int h]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _data.AsSpan((h * Width + w) * Depth, Depth);
        }
    }
    /// <summary>
    /// Индексатор для доступа к элементам тензора. В debug-сборке выполняет проверку границ.
    /// Память организована в формате HWC (Height-Width-Channel).
    /// </summary>
    public ref float this[int w, int h, int d]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Debug.Assert(w >= 0 && h >= 0 && d >= 0 && w < Width && h < Height && d < Depth);
            return ref _data[(h * Width + w) * Depth + d];
        }
    }
    internal void GetWindow(int x, int y, int sizex, int sizey, Span<float> dst)
    {
        Debug.Assert(sizex > 0 && sizey > 0);
        Debug.Assert(sizex * sizey * Depth == dst.Length);
        fixed (float* dstPtr = dst)
        {
            GetWindow(x, y, sizex, sizey, dstPtr);
        }
    }
    /// <summary>
    /// Copies tensor window to one dimensional array
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="sizex"></param>
    /// <param name="sizey"></param>
    /// <param name="dst"></param>
    internal unsafe void GetWindow(int x, int y, int sizex, int sizey, float* dst)
    {
        Debug.Assert(sizex > 0 && sizey > 0);
        fixed (float* ptrSrc = _data)
        {
            for (int iy = y, ycount = y + sizey, i = 0; iy < ycount; ++iy)
            {
                var offsety = iy * Width;
                for (int ix = x, xcount = x + sizex; ix < xcount; ++ix)
                {
                    var offsetx = (offsety + ix) * Depth;
                    if (ix < 0 || iy < 0 || ix >= Width || iy >= Height)
                    {
                        for (var iz = 0; iz < Depth; ++iz, ++i)
                        {
                            dst[i] = 0f;
                        }
                    }
                    else
                    {
                        for (var iz = 0; iz < Depth; ++iz, ++i)
                        {
                            dst[i] = ptrSrc[offsetx + iz];
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// Преобразует тензор в плоскую матрицу-вектор. Не копирует данные, а создает новую матрицу.
    /// </summary>
    public Matrix ToMatrix()
    {
        return Matrix.CreateVector(AsSpan());
    }

    public Span<float> AsSpan()
    {
        return new Span<float>(_data, 0, Size);
    }

    /// <summary>
    /// Создает тензор из плоской матрицы-вектора. Не копирует данные, а создает новый тензор.
    /// </summary>
    public static SimpleTensor FromMatrix(Matrix matrix, int width, int height, int depth)
    {
        if (matrix.Rows * matrix.Cols != width * height * depth)
        {
            throw new ArgumentException("Matrix size does not match target tensor dimensions.");
        }

        var tensor = new SimpleTensor(width, height, depth);
        if (matrix.Stride == 1)
        {
            matrix.AsSpan().CopyTo(tensor.AsSpan());
        }
        else
        {
            var dest = tensor._data.AsSpan();
            var offset = 0;
            for (var row = 0; row < matrix.Rows; ++row)
            {
                var rowData = matrix.GetRow(row);
                rowData.CopyTo(dest.Slice(offset));
                offset += matrix.Cols;
            }
        }
        return tensor;
    }

    /// <summary>
    /// Заполняет тензор случайными значениями с использованием инициализации Xavier/Glorot.
    /// </summary>
    public void Randomize(int fanIn)
    {
        var scale = MathF.Sqrt(1.0f / fanIn);
        for (var i = 0; i < Size; i++)
        {
            _data[i] = (Random.Shared.NextSingle() * 2f - 1f) * scale;
        }
    }

    /// <summary>
    /// Применяет функцию к каждому элементу тензора, возвращая новый тензор.
    /// Эта операция не векторизована, т.к. Func<T, T> не может быть транслирован в SIMD.
    /// Для стандартных операций (ReLU) следует писать отдельные векторизованные методы.
    /// </summary>
    public SimpleTensor Map(Action<ReadOnlySpan<float>, Span<float>> func)
    {
        var c = new SimpleTensor(Width, Height, Depth);
        func(_data, c._data);
        return c;
    }

    /// <summary>
    /// Выполняет поэлементное умножение (произведение Адамара) двух тензоров.
    /// Оптимизировано с использованием AVX.
    /// </summary>
    public static SimpleTensor Hadamard(SimpleTensor a, SimpleTensor b)
    {
        Debug.Assert(a.Width == b.Width && a.Height == b.Height && a.Depth == b.Depth);
        var c = new SimpleTensor(a.Width, a.Height, a.Depth);
        Hadamard(a, b, c);
        return c;
    }

    public static void Hadamard(SimpleTensor a, SimpleTensor b, SimpleTensor c)
    {
        Debug.Assert(a.Width == b.Width && a.Height == b.Height && a.Depth == b.Depth);
        Debug.Assert(a.Width == c.Width && a.Height == c.Height && a.Depth == c.Depth);
        TensorPrimitives.Multiply(a._data, b._data, c._data);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool _)
    {
        if (!_disposed)
        {
            _disposed = true;
        }
    }
}
