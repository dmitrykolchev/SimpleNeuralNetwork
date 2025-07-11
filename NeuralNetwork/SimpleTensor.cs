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
    private bool _disposed = false;

    public SimpleTensor(int width, int height, int depth)
    {
        if (width < 0 || height < 0 || depth < 0)
        {
            throw new ArgumentOutOfRangeException("Tensor dimensions cannot be negative.");
        }

        Width = width;
        Height = height;
        Depth = depth;
        Size = width * height * depth;

        if (Size == 0)
        {
            return;
        }

        _data = new float[Size];
    }

    public readonly int Width;
    public readonly int Height;
    public readonly int Depth;
    public readonly int Size;

    /// <summary>
    /// Индексатор для доступа к элементам тензора. В debug-сборке выполняет проверку границ.
    /// Память организована в формате HWC (Height-Width-Channel).
    /// </summary>
    public ref float this[int w, int h, int d]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
#if DEBUG
            if (w < 0 || w >= Width || h < 0 || h >= Height || d < 0 || d >= Depth)
                throw new IndexOutOfRangeException();
#endif
            return ref _data[(h * Width + w) * Depth + d];
        }
        //        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //        set
        //        {
        //#if DEBUG
        //            if (w < 0 || w >= Width || h < 0 || h >= Height || d < 0 || d >= Depth)
        //                throw new IndexOutOfRangeException();
        //#endif
        //            _data[(h * Width + w) * Depth + d] = value;
        //        }
    }

    /// <summary>
    /// Преобразует тензор в плоскую матрицу-вектор. Не копирует данные, а создает новую матрицу.
    /// </summary>
    public Matrix ToMatrix()
    {
        var matrix = new Matrix(Size, 1);
        if (this._data != null)
        {
            Array.Copy(_data, 0, matrix._data, 0, matrix.Size);
        }
        return matrix;
    }

    /// <summary>
    /// Создает тензор из плоской матрицы-вектора. Не копирует данные, а создает новый тензор.
    /// </summary>
    public static SimpleTensor FromMatrix(Matrix matrix, int width, int height, int depth)
    {
        if (matrix.Size != width * height * depth)
            throw new ArgumentException("Matrix size does not match target tensor dimensions.");

        var tensor = new SimpleTensor(width, height, depth);
        if (tensor._data != null)
        {
            Array.Copy(matrix._data, 0, tensor._data, 0, tensor.Size);

        }
        return tensor;
    }

    /// <summary>
    /// Заполняет тензор случайными значениями с использованием инициализации Xavier/Glorot.
    /// </summary>
    public void Randomize(int fanIn)
    {
        if (_data == null) return;
        var scale = MathF.Sqrt(1.0f / fanIn);
        for (int i = 0; i < Size; i++)
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
        var result = new SimpleTensor(Width, Height, Depth);
        if (_data == null) return result;
        func(_data, result._data);
        return result;
    }

    /// <summary>
    /// Выполняет поэлементное умножение (произведение Адамара) двух тензоров.
    /// Оптимизировано с использованием AVX.
    /// </summary>
    public static SimpleTensor Hadamard(SimpleTensor a, SimpleTensor b)
    {
        if (a.Width != b.Width || a.Height != b.Height || a.Depth != b.Depth)
            throw new ArgumentException("Tensors must have same dimensions for Hadamard product.");

        var result = new SimpleTensor(a.Width, a.Height, a.Depth);
        if (result._data == null) return result;

        TensorPrimitives.Multiply(a._data, b._data, result._data);
        return result;
    }

    public static void Hadamard(SimpleTensor a, SimpleTensor b, SimpleTensor result)
    {
        if (a.Width != b.Width || a.Height != b.Height || a.Depth != b.Depth)
            throw new ArgumentException("Tensors must have same dimensions for Hadamard product.");
        TensorPrimitives.Multiply(a._data, b._data, result._data);
    }

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
}