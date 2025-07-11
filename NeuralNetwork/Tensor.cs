// Tensor.cs
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace NeuralNetwork;

/// <summary>
/// Представляет 3D-тензор, использующий неуправляемую выровненную память для высокой производительности.
/// КРИТИЧЕСКИ ВАЖНО: Объекты этого класса ДОЛЖНЫ быть освобождены через Dispose() или блок using,
/// чтобы избежать утечек нативной памяти.
/// </summary>
public sealed unsafe class Tensor : IDisposable
{
    public readonly int Width;
    public readonly int Height;
    public readonly int Depth;
    public readonly int Size;

    // Указатель на начало блока неуправляемой, выровненной памяти.
    // Сделан internal для эффективного взаимодействия с другими unsafe классами (Matrix).
    internal readonly float* _data;
    private bool _disposed = false;

    /// <summary>
    /// Индексатор для доступа к элементам тензора. В debug-сборке выполняет проверку границ.
    /// Память организована в формате HWC (Height-Width-Channel).
    /// </summary>
    public float this[int w, int h, int d]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
#if DEBUG
            if (w < 0 || w >= Width || h < 0 || h >= Height || d < 0 || d >= Depth)
                throw new IndexOutOfRangeException();
#endif
            return _data[(h * Width + w) * Depth + d];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
#if DEBUG
            if (w < 0 || w >= Width || h < 0 || h >= Height || d < 0 || d >= Depth)
                throw new IndexOutOfRangeException();
#endif
            _data[(h * Width + w) * Depth + d] = value;
        }
    }

    public Tensor(int width, int height, int depth)
    {
        if (width < 0 || height < 0 || depth < 0)
            throw new ArgumentOutOfRangeException("Tensor dimensions cannot be negative.");

        Width = width;
        Height = height;
        Depth = depth;
        Size = width * height * depth;

        if (Size == 0)
        {
            _data = null;
            return;
        }

        // Выравнивание на 32 байта для AVX2. 16 байт - для SSE. 32 байта покрывают оба случая.
        const nuint alignment = 32;
        nuint byteCount = (nuint)(Size * sizeof(float));

        _data = (float*)NativeMemory.AlignedAlloc(byteCount, alignment);
        NativeMemory.Fill(_data, byteCount, 0);
    }

    #region Вспомогательные и статические методы

    /// <summary>
    /// Преобразует тензор в плоскую матрицу-вектор. Не копирует данные, а создает новую матрицу.
    /// </summary>
    public Matrix ToMatrix()
    {
        var matrix = new Matrix(Size, 1);
        if (this._data != null)
        {
            Buffer.MemoryCopy(this._data, matrix._data, matrix.Size * sizeof(float), this.Size * sizeof(float));
        }
        return matrix;
    }

    /// <summary>
    /// Создает тензор из плоской матрицы-вектора. Не копирует данные, а создает новый тензор.
    /// </summary>
    public static Tensor FromMatrix(Matrix matrix, int width, int height, int depth)
    {
        if (matrix.Size != width * height * depth)
            throw new ArgumentException("Matrix size does not match target tensor dimensions.");

        var tensor = new Tensor(width, height, depth);
        if (tensor._data != null)
        {
            Buffer.MemoryCopy(matrix._data, tensor._data, tensor.Size * sizeof(float), matrix.Size * sizeof(float));
        }
        return tensor;
    }

    /// <summary>
    /// Заполняет тензор случайными значениями с использованием инициализации Xavier/Glorot.
    /// </summary>
    public void Randomize(int fanIn)
    {
        if (_data == null) return;
        var rand = new Random();
        var scale = (float)Math.Sqrt(1.0 / fanIn);
        for (int i = 0; i < Size; i++)
        {
            _data[i] = (rand.NextSingle() * 2f - 1f) * scale;
        }
    }

    /// <summary>
    /// Применяет функцию к каждому элементу тензора, возвращая новый тензор.
    /// Эта операция не векторизована, т.к. Func<T, T> не может быть транслирован в SIMD.
    /// Для стандартных операций (ReLU) следует писать отдельные векторизованные методы.
    /// </summary>
    public Tensor Map(Func<float, float> func)
    {
        var result = new Tensor(Width, Height, Depth);
        if (_data == null) return result;

        for (int i = 0; i < Size; i++)
        {
            result._data[i] = func(this._data[i]);
        }
        return result;
    }

    /// <summary>
    /// Векторизованная реализация ReLU.
    /// </summary>
    public void ReLUInPlace()
    {
        if (_data == null) return;

        int i = 0;
        if (Avx.IsSupported)
        {
            var vZero = Vector256<float>.Zero;
            int vecSize = Vector256<float>.Count;
            for (; i <= Size - vecSize; i += vecSize)
            {
                var v = Avx.LoadAlignedVector256(_data + i);
                var vResult = Avx.Max(v, vZero);
                // Для ReLU можно использовать обычный Store, т.к. данные скорее всего понадобятся в backward pass.
                Avx.StoreAligned(_data + i, vResult);
            }
        }
        // Остаток
        for (; i < Size; i++)
        {
            _data[i] = Math.Max(0, _data[i]);
        }
    }

    /// <summary>
    /// Выполняет поэлементное умножение (произведение Адамара) двух тензоров.
    /// Оптимизировано с использованием AVX.
    /// </summary>
    public static Tensor Hadamard(Tensor a, Tensor b)
    {
        if (a.Width != b.Width || a.Height != b.Height || a.Depth != b.Depth)
            throw new ArgumentException("Tensors must have same dimensions for Hadamard product.");

        var result = new Tensor(a.Width, a.Height, a.Depth);
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
                // Используем Non-Temporal Store для записи, не загрязняя кэш L1/L2,
                // так как эти данные (градиенты) будут использоваться следующим слоем и не сразу.
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

    ~Tensor()
    {
        Dispose(false);
    }

    #endregion
}