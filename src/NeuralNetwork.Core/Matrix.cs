// <copyright file="Matrix.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;
using System.Numerics.Tensors;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Managed.Mkl.Native;
using static Managed.Mkl.Native.MklCblas;

namespace NeuralNetwork;

[DebuggerDisplay("(r:{Rows}, c:{Cols})")]
public unsafe class Matrix : IDisposable
{
    private const int AlignmentBytes = 256 / 8;
    private const int AlignmentFloats = AlignmentBytes / sizeof(float);

    private readonly int _dataLength;
    private readonly int _stride;
    private readonly int _rows;
    private readonly int _cols;

    private float* _data;
    private bool _disposed;

    private Matrix(int rows, int cols)
    {
        Debug.Assert(rows > 0 && cols > 0);
        _rows = rows;
        _cols = cols;
        _stride = cols == 1
            ? 1
            : (cols + AlignmentFloats - 1) & ~(AlignmentFloats - 1);
        _dataLength = _stride * _rows;
        _data = (float*)NativeMemory.AlignedAlloc((nuint)_dataLength * sizeof(float), AlignmentBytes);
    }

    public static Matrix CreateVector(ReadOnlySpan<float> data)
    {
        Debug.Assert(data.Length > 0);
        var c = new Matrix(data.Length, 1);
        data.CopyTo(c.AsSpan());
        return c;
    }

    public static Matrix CreateZeros(int rows, int cols)
    {
        Debug.Assert(rows > 0 && cols > 0);
        var c = new Matrix(rows, cols);
        c.AsSpan().Clear();
        return c;
    }

    public static Matrix CreateOnes(int rows, int cols)
    {
        Debug.Assert(rows > 0 && cols > 0);
        var c = new Matrix(rows, cols);
        for (var row = 0; row < c.Rows; row++)
        {
            c.GetRow(row).Fill(1f);
        }
        return c;
    }

    public static Matrix CreateIdentity(int rows, int cols)
    {
        Debug.Assert(rows > 0 && cols > 0);
        Debug.Assert(rows == cols);
        var c = new Matrix(rows, cols);
        c.AsSpan().Clear();
        for (var row = 0; row < c.Rows; row++)
        {
            var rowC = c.GetRow(row);
            rowC[row] = 1f;
        }
        return c;
    }

    public static Matrix CreateRandom(int rows, int cols)
    {
        Debug.Assert(rows > 0 && cols > 0);
        var c = new Matrix(rows, cols);
        c.Randomize();
        return c;
    }

    public static Matrix CreateRandom(int rows, int cols, Func<float> nextSingle)
    {
        Debug.Assert(rows > 0 && cols > 0);
        var c = new Matrix(rows, cols);
        c.Randomize(nextSingle);
        return c;
    }

    public int Rows => _rows;

    public int Cols => _cols;

    public int Stride => _stride;

    internal float* Data => _data;

    public ref float this[int row, int col]
    {
        get
        {
            Debug.Assert(row >= 0 && col >= 0 && row < Rows && col < Cols);
            return ref _data[row * _stride + col];
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<float> AsSpan()
    {
        return new Span<float>(_data, _dataLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<float> GetRow(int row)
    {
        Debug.Assert(row >= 0 && row < Rows);
        return new Span<float>(GetRowPtr(row), Cols);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal float* GetRowPtr(int row)
    {
        Debug.Assert(row >= 0 && row < Rows);
        return _data + row * _stride;
    }

    public static Matrix Add(Matrix a, Matrix b)
    {
        Debug.Assert(a.Rows == b.Rows && a.Cols == b.Cols);
        var c = new Matrix(rows: a.Rows, cols: a.Cols);
        Add(a, b, c);
        return c;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Add(Matrix a, Matrix b, Matrix c)
    {
        Debug.Assert(a.Rows == b.Rows && a.Cols == b.Cols);
        Debug.Assert(a.Rows == c.Rows && a.Cols == c.Cols);
        for (int row = 0, rows = c.Rows; row < rows; row++)
        {
            var rowA = a.GetRow(row);
            var rowB = b.GetRow(row);
            var rowC = c.GetRow(row);
            TensorPrimitives.Add(rowA, rowB, rowC);
        }
    }

    public static void AddI(Matrix a, Matrix b)
    {
        Debug.Assert(a.Rows == b.Rows && a.Cols == b.Cols);
        Add(a, b, a);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Subtract(Matrix a, Matrix b, Matrix c)
    {
        Debug.Assert(a.Rows == b.Rows && a.Cols == b.Cols);
        Debug.Assert(a.Rows == c.Rows && a.Cols == c.Cols);
        for (int row = 0, rows = c.Rows; row < rows; row++)
        {
            var rowA = a.GetRow(row);
            var rowB = b.GetRow(row);
            var rowC = c.GetRow(row);
            TensorPrimitives.Subtract(rowA, rowB, rowC);
        }
    }

    public static Matrix Subtract(Matrix a, Matrix b)
    {
        Debug.Assert(a.Rows == b.Rows && a.Cols == b.Cols);
        var c = new Matrix(rows: a.Rows, cols: a.Cols);
        Subtract(a, b, c);
        return c;
    }

    public static void SubtractI(Matrix a, Matrix b)
    {
        Debug.Assert(a.Rows == b.Rows && a.Cols == b.Cols);
        Subtract(a, b, a);
    }

    public static Matrix Multiply(Matrix a, float alpha)
    {
        var c = new Matrix(rows: a.Rows, cols: a.Cols);
        if (a.Stride == 1 && c.Stride == 1)
        {
            TensorPrimitives.Multiply(a.AsSpan(), alpha, c.AsSpan());
        }
        else
        {
            for (var row = 0; row < c.Rows; row++)
            {
                var rowA = a.GetRow(row);
                var rowC = c.GetRow(row);
                TensorPrimitives.Multiply(rowA, alpha, rowC);
            }
        }
        return c;
    }

    public static Matrix Multiply(Matrix a, bool transposeA, Matrix b, bool transposeB)
    {
        var aRows = transposeA ? a.Cols : a.Rows;
        var aCols = transposeA ? a.Rows : a.Cols;
        var bRows = transposeB ? b.Cols : b.Rows;
        var bCols = transposeB ? b.Rows : b.Cols;
        if (aCols != bRows)
        {
            throw new ArgumentException("Non compatible matrix size");
        }

        var c = new Matrix(rows: aRows, cols: bCols);

        cblas_sgemm(CblasLayout.CblasRowMajor,
            transposeA ? CblasTranspose.CblasTrans : CblasTranspose.CblasNoTrans,
            transposeB ? CblasTranspose.CblasTrans : CblasTranspose.CblasNoTrans,
            aRows,
            bCols,
            aCols,
            1f,
            a.Data, a.Stride,
            b.Data, b.Stride,
            0,
            c.Data, c.Stride);
        return c;
    }

    public static Matrix MultiplyDirect(Matrix a, bool transposeA, Matrix b, bool transposeB)
    {
        var aRows = transposeA ? a.Cols : a.Rows;
        var aCols = transposeA ? a.Rows : a.Cols;
        var bRows = transposeB ? b.Cols : b.Rows;
        var bCols = transposeB ? b.Rows : b.Cols;

        if (aCols != bRows)
        {
            throw new ArgumentException("Non compatible matrix size");
        }

        a = transposeA ? Transpose(a) : a;
        b = transposeB ? b : Transpose(b);

        var c = new Matrix(rows: aRows, cols: bCols);
        for (int row = 0, rows = c.Rows; row < rows; row++)
        {
            var rowA = a.GetRow(row);
            var rowC = c.GetRow(row);
            for (int col = 0, cols = c.Cols; col < cols; col++)
            {
                var rowB = b.GetRow(col);
                rowC[col] = TensorPrimitives.Dot(rowA, rowB);
            }
        }
        if (transposeA)
        {
            a.Dispose();
        }
        if (!transposeB)
        {
            b.Dispose();
        }
        return c;
    }

    public static Matrix Hadamard(Matrix a, Matrix b)
    {
        Debug.Assert(a.Rows == b.Rows && a.Cols == b.Cols);

        var c = new Matrix(a.Rows, a.Cols);
        if (a.Stride == 1 && b.Stride == 1)
        {
            TensorPrimitives.Multiply(a.AsSpan(), b.AsSpan(), c.AsSpan());
        }
        else
        {
            for (var row = 0; row < a.Rows; row++)
            {
                var rowA = a.GetRow(row);
                var rowB = b.GetRow(row);
                var rowC = c.GetRow(row);
                TensorPrimitives.Multiply(rowA, rowB, rowC);
            }
        }
        return c;
    }

    public static Matrix Transpose(Matrix a)
    {
        var c = new Matrix(a.Cols, a.Rows);
        if (a.Stride == 1 && c.Stride == 1)
        {
            a.AsSpan().CopyTo(c.AsSpan());
        }
        else
        {
            var cSpan = c.AsSpan();
            for (var row = 0; row < a.Rows; row++)
            {
                var rowData = a.GetRow(row);
                for (int col = 0, offDst = row; col < a.Cols; col++, offDst += c.Stride)
                {
                    cSpan[offDst] = rowData[col];
                }
            }
        }
        return c;
    }

    public void Randomize()
    {
        Randomize((_, _) => Random.Shared.NextSingle());
    }

    public void Randomize(Func<int, int, float> nextSingle)
    {
        var scale = MathF.Sqrt(1.0f / Rows);
        for (int row = 0, rows = Rows; row < rows; row++)
        {
            var rowData = GetRow(row);
            for (int col = 0, cols = Cols; col < cols; col++)
            {
                rowData[col] = (nextSingle(row, col) * 2f - 1f) * scale;
            }
        }
    }

    public Matrix Map(Action<ReadOnlySpan<float>, Span<float>> func)
    {
        var c = new Matrix(Rows, Cols);
        for (var row = 0; row < Rows; row++)
        {
            var rowA = GetRow(row);
            var rowC = c.GetRow(row);
            func(rowA, rowC);
        }
        return c;
    }

    public (int row, int col) GetMaxIndex()
    {
        int maxRow = 0, maxCol = 0;
        var maxValue = this[0, 0];
        for (var row = 0; row < Rows; row++)
        {
            var rowData = GetRow(row);
            var col = TensorPrimitives.IndexOfMax(rowData);
            if (rowData[col] > maxValue)
            {
                maxValue = rowData[col];
                maxRow = row; maxCol = col;
            }
        }
        return (maxRow, maxCol);
    }

    public int GetPredictedClass()
    {
        (var row, var col) = GetMaxIndex();
        return row * Cols + col;
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
            if (_data != null)
            {
                NativeMemory.AlignedFree(_data);
                _data = null;
            }
        }
    }

    ~Matrix()
    {
        Dispose(false);
    }
}
