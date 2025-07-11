// Matrix.cs
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace NeuralNetwork;

/// <summary>
/// Представляет матрицу, использующую неуправляемую выровненную память для высокой производительности.
/// КРИТИЧЕСКИ ВАЖНО: Объекты этого класса ДОЛЖНЫ быть освобождены через Dispose() или блок using,
/// чтобы избежать утечек нативной памяти.
/// </summary>
public sealed unsafe class Matrix : IDisposable
{
    public readonly int Rows;
    public readonly int Cols;
    public readonly int Size;

    // Сделан internal для прямого доступа из других unsafe-классов (Tensor) без копирования.
    internal readonly float* _data;
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
            _data = null;
            return;
        }

        const nuint alignment = 32;
        nuint byteCount = (nuint)(Size * sizeof(float));
        _data = (float*)NativeMemory.AlignedAlloc(byteCount, alignment);
        NativeMemory.Fill(_data, byteCount, 0);
    }

    #region Статические методы создания и AVX-операторы

    public static Matrix FromArray(float[,] data)
    {
        int rows = data.GetLength(0);
        int cols = data.GetLength(1);
        var m = new Matrix(rows, cols);
        if (m._data == null) return m;

        float* ptr = m._data;
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

        fixed (float* pSource = data)
        {
            Buffer.MemoryCopy(pSource, m._data, m.Size * sizeof(float), m.Size * sizeof(float));
        }
        return m;
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Matrices must have same dimensions.");

        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;

        float* ptrA = a._data;
        float* ptrB = b._data;
        float* ptrResult = result._data;
        int i = 0;

        if (Avx.IsSupported)
        {
            int vecSize = Vector256<float>.Count;
            for (; i <= a.Size - vecSize; i += vecSize)
            {
                var va = Avx.LoadAlignedVector256(ptrA + i);
                var vb = Avx.LoadAlignedVector256(ptrB + i);
                var vr = Avx.Add(va, vb);
                Avx.StoreAlignedNonTemporal(ptrResult + i, vr);
            }
        }
        for (; i < a.Size; i++)
        {
            ptrResult[i] = ptrA[i] + ptrB[i];
        }
        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Matrices must have same dimensions.");

        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;

        float* ptrA = a._data;
        float* ptrB = b._data;
        float* ptrResult = result._data;
        int i = 0;

        if (Avx.IsSupported)
        {
            int vecSize = Vector256<float>.Count;
            for (; i <= a.Size - vecSize; i += vecSize)
            {
                var va = Avx.LoadAlignedVector256(ptrA + i);
                var vb = Avx.LoadAlignedVector256(ptrB + i);
                var vr = Avx.Subtract(va, vb);
                Avx.StoreAlignedNonTemporal(ptrResult + i, vr);
            }
        }
        for (; i < a.Size; i++)
        {
            ptrResult[i] = ptrA[i] - ptrB[i];
        }
        return result;
    }

    public static Matrix operator *(Matrix a, float scalar)
    {
        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;

        float* ptrA = a._data;
        float* ptrResult = result._data;
        int i = 0;

        if (Avx.IsSupported)
        {
            var vscalar = Vector256.Create(scalar);
            int vecSize = Vector256<float>.Count;
            for (; i <= a.Size - vecSize; i += vecSize)
            {
                var va = Avx.LoadAlignedVector256(ptrA + i);
                var vr = Avx.Multiply(va, vscalar);
                Avx.StoreAlignedNonTemporal(ptrResult + i, vr);
            }
        }
        for (; i < a.Size; i++)
        {
            ptrResult[i] = ptrA[i] * scalar;
        }
        return result;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Cols != b.Rows)
            throw new ArgumentException("Matrix dimensions are not compatible for multiplication.");

        var result = new Matrix(a.Rows, b.Cols);
        if (result._data == null) return result;

        using var bT = Transpose(b);

        float* ptrA = a._data;
        float* ptrBT = bT._data;
        float* ptrResult = result._data;
        int aCols = a.Cols;

        for (int i = 0; i < a.Rows; i++)
        {
            float* rowA = ptrA + i * aCols;
            for (int j = 0; j < bT.Rows; j++)
            {
                float* rowBT = ptrBT + j * aCols;

                float sum = 0;
                int k = 0;
                if (Avx.IsSupported)
                {
                    var vsum = Vector256<float>.Zero;
                    int vecSize = Vector256<float>.Count;
                    for (; k <= aCols - vecSize; k += vecSize)
                    {
                        var va = Avx.LoadVector256(rowA + k);
                        var vb = Avx.LoadVector256(rowBT + k);
                        vsum = Fma.IsSupported ? Fma.MultiplyAdd(va, vb, vsum) : Avx.Add(vsum, Avx.Multiply(va, vb));
                    }

                    vsum = Avx.HorizontalAdd(vsum, vsum);
                    vsum = Avx.HorizontalAdd(vsum, vsum);
                    sum += vsum.GetElement(0) + vsum.GetElement(4);
                }

                for (; k < aCols; k++)
                {
                    sum += rowA[k] * rowBT[k];
                }
                ptrResult[i * result.Cols + j] = sum;
            }
        }
        return result;
    }

    /// <summary>
    /// Выполняет поэлементное умножение матриц (произведение Адамара).
    /// Оптимизировано с использованием AVX-инструкций.
    /// </summary>
    public static Matrix Hadamard(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Matrices must have the same dimensions for Hadamard product.");

        var result = new Matrix(a.Rows, a.Cols);
        if (result._data == null) return result;

        float* ptrA = a._data;
        float* ptrB = b._data;
        float* ptrResult = result._data;
        int i = 0;

        if (Avx.IsSupported)
        {
            int vecSize = Vector256<float>.Count; // 8
            for (; i <= a.Size - vecSize; i += vecSize)
            {
                var va = Avx.LoadAlignedVector256(ptrA + i);
                var vb = Avx.LoadAlignedVector256(ptrB + i);
                var vr = Avx.Multiply(va, vb);
                Avx.StoreAlignedNonTemporal(ptrResult + i, vr);
            }
        }
        // Обрабатываем остаток
        for (; i < a.Size; i++)
        {
            ptrResult[i] = ptrA[i] * ptrB[i];
        }
        return result;
    }

    #endregion

    #region Другие методы

    public static Matrix Transpose(Matrix m)
    {
        var result = new Matrix(m.Cols, m.Rows);
        if (result._data == null) return result;

        float* ptrM = m._data;
        float* ptrResult = result._data;

        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                ptrResult[j * result.Cols + i] = ptrM[i * m.Cols + j];
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
            _data[i] = ((float)rand.NextDouble() * 2f - 1f) * scale;
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
    public Matrix Map(Func<float, float> func)
    {
        var result = new Matrix(Rows, Cols);
        if (result._data == null) return result;

        float* ptrSource = this._data;
        float* ptrDest = result._data;

        for (int i = 0; i < Size; i++)
        {
            ptrDest[i] = func(ptrSource[i]);
        }
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
            if (_data != null)
            {
                NativeMemory.AlignedFree(_data);
            }
            _disposed = true;
        }
    }

    ~Matrix()
    {
        Dispose(false);
    }

    #endregion
}