// Matrix.cs
using System.Diagnostics;
using System.Numerics.Tensors;
using System.Runtime.CompilerServices;

namespace NeuralNetwork;

/// <summary>
/// Представляет матрицу, использующую неуправляемую выровненную память для высокой производительности.
/// КРИТИЧЕСКИ ВАЖНО: Объекты этого класса ДОЛЖНЫ быть освобождены через Dispose() или блок using,
/// чтобы избежать утечек нативной памяти.
/// </summary>
[DebuggerDisplay("(r:{Rows}, c:{Cols}), size:{Size}")]
public sealed unsafe class Matrix : IDisposable
{
    public readonly int Rows;
    public readonly int Cols;
    public readonly int Size;

    // Сделан internal для прямого доступа из других unsafe-классов (Tensor) без копирования.
    internal readonly float[] _data;
    private bool _disposed = false;

    public float this[int row, int col]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
#if DEBUG
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                throw new IndexOutOfRangeException();
#endif
            return _data[row * Cols + col];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
#if DEBUG
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                throw new IndexOutOfRangeException();
#endif
            _data[row * Cols + col] = value;
        }
    }

    public Matrix(int rows, int cols)
    {
        if (rows < 0 || cols < 0)
            throw new ArgumentOutOfRangeException("Matrix dimensions cannot be negative.");

        Rows = rows;
        Cols = cols;
        Size = rows * cols;

        if (Size == 0)
        {
            return;
        }
        _data = new float[Size];
    }

    public static Matrix FromArray(float[,] data)
    {
        int rows = data.GetLength(0);
        int cols = data.GetLength(1);
        var m = new Matrix(rows, cols);
        if (m._data == null) return m;

        var ptr = m._data;
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                ptr[k++] = data[i, j];
            }
        }
        return m;
    }

    public static Matrix CreateVector(float[] data)
    {
        var m = new Matrix(data.Length, 1);
        if (m._data == null) return m;
        Array.Copy(data, 0, m._data, 0, data.Length);
        return m;
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Matrices must have same dimensions.");

        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;

        TensorPrimitives.Add(
            a._data,
            b._data,
            result._data);
        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Matrices must have same dimensions.");

        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;

        TensorPrimitives.Subtract(
            a._data,
            b._data,
            result._data);
        return result;
    }

    public static Matrix operator *(Matrix a, float scalar)
    {
        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;
        TensorPrimitives.Multiply(a._data, scalar, result._data);
        return result;
    }

    public static Matrix Multiply(Matrix a, bool aTransposed, Matrix b, bool bTransposed)
    {
        bool aDispose = false, bDispose = false;
        if (aTransposed)
        {
            a = Transpose(a);
            aDispose = true;
        }
        if (!bTransposed)
        {
            b = Transpose(b);
            bDispose = true;
        }

        var result = new Matrix(a.Rows, b.Rows);
        if (result._data == null) return result;
        try
        {
            int aCols = a.Cols;
            //for (int i = 0; i < a.Rows; i++)
            Parallel.For(0, a.Rows, i =>
            {
                var rowA = a._data.AsSpan(i * aCols, aCols);
                for (int j = 0; j < b.Rows; j++)
                {
                    var rowB = b._data.AsSpan(j * aCols, aCols);
                    result._data[i * result.Cols + j] = TensorPrimitives.Dot(rowA, rowB);
                }
            });
            return result;
        }
        finally
        {
            if (aDispose)
            {
                a.Dispose();
            }
            if (bDispose)
            {
                b.Dispose();
            }
        }
    }

    /// <summary>
    /// Выполняет поэлементное умножение матриц (произведение Адамара).
    /// </summary>
    public static Matrix Hadamard(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Matrices must have the same dimensions for Hadamard product.");

        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;

        TensorPrimitives.Multiply(
            a._data,
            b._data,
            result._data);
        return result;
    }

    #region Другие методы

    public static Matrix Transpose(Matrix m)
    {
        var result = new Matrix(m.Cols, m.Rows);
        if (result._data == null) return result;

        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                result._data[j * result.Cols + i] = m._data[i * m.Cols + j];
            }
        }
        return result;
    }

    public void Randomize()
    {
        if (_data == null) return;
        var rand = new Random();
        var scale = (float)Math.Sqrt(1.0 / Rows);
        for (int i = 0; i < Size; i++)
        {
            _data[i] = (rand.NextSingle() * 2f - 1f) * scale;
        }
    }

    public int GetPredictedClass()
    {
        if (_data == null || Size == 0) return -1;
        int maxIndex = 0;
        float maxValue = _data[0];
        for (int i = 1; i < Size; i++)
        {
            if (_data[i] > maxValue)
            {
                maxValue = _data[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    /// <summary>
    /// Применяет произвольную функцию к каждому элементу матрицы и возвращает новую матрицу.
    /// ВНИМАНИЕ: Этот метод не векторизован и может быть медленным из-за вызова делегата в цикле.
    /// Для стандартных функций активации (ReLU, Sigmoid) следует создавать специализированные
    /// векторизованные методы для максимальной производительности.
    /// </summary>
    public Matrix Map(Action<ReadOnlySpan<float>, Span<float>> func)
    {
        var result = new Matrix(Rows, Cols);
        if (result._data == null) return result;
        func(_data.AsSpan(), result._data.AsSpan());
        return result;
    }

    #endregion

    #region IDisposable

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            _disposed = true;
        }
    }

    ~Matrix()
    {
        Dispose(false);
    }

    #endregion
}