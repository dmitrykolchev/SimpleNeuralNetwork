using System.Runtime.InteropServices;

namespace Managed.Mkl.Native
{
    public static unsafe partial class MklVml
    {
        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAbs([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAbs([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAbs([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAbs([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAbs([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAbs([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAbs([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAbs([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcArg([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzArg([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcArg([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzArg([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAdd([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAdd([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAdd([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAdd([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAdd([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAdd([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAdd([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAdd([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSub([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSub([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSub([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSub([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSub([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSub([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSub([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSub([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqr([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqr([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqr([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqr([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcExp([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzExp([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcExp([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzExp([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp10([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp10([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp10([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp10([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpm1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpm1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpm1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpm1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLn([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLn([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLn([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLn([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLn([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLn([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLn([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLn([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog10([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog10([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog10([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog10([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLog10([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLog10([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLog10([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLog10([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog1p([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog1p([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog1p([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog1p([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLogb([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLogb([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLogb([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLogb([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCos([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCos([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCos([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCos([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSin([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSin([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSin([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSin([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTan([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTan([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTan([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTan([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCospi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCospi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCospi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCospi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosd([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosd([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosd([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosd([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSind([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSind([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSind([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSind([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTand([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTand([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTand([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTand([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcos([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcos([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcos([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcos([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcos([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsin([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsin([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsin([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsin([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsin([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtan([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcospi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcospi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcospi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcospi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanpi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanpi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErf([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErf([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErf([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErf([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsHypot([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdHypot([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsHypot([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdHypot([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfc([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfc([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfc([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfc([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcx([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcx([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcx([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcx([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNorm([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNorm([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNorm([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNorm([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNormInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNormInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNormInv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNormInv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLGamma([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLGamma([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLGamma([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLGamma([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTGamma([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTGamma([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTGamma([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTGamma([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI0([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI0([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI0([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI0([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ0([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ0([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ0([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ0([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY0([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY0([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY0([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY0([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJn([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJn([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJn([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJn([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsYn([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdYn([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsYn([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdYn([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2pi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2pi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2pi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2pi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMul([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMul([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMul([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMul([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMul([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMul([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMul([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMul([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsDiv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdDiv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsDiv([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdDiv([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcDiv([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzDiv([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcDiv([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzDiv([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPow([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPow([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPow([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPow([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow3o2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow3o2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow3o2([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow3o2([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow2o3([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow2o3([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow2o3([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow2o3([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowx([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowx([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowx([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowx([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPowx([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPowx([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPowx([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPowx([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowr([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowr([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowr([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowr([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCos([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCos([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCos([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCos([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCospi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCospi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCospi([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCospi([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLinearFrac([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLinearFrac([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLinearFrac([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLinearFrac([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCeil([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCeil([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCeil([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCeil([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFloor([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFloor([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFloor([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFloor([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFrac([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFrac([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFrac([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFrac([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsModf([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdModf([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsModf([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdModf([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmod([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmod([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmod([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmod([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRemainder([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRemainder([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRemainder([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRemainder([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNextAfter([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNextAfter([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNextAfter([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNextAfter([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCopySign([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCopySign([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCopySign([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCopySign([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFdim([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFdim([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFdim([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFdim([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmax([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmax([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmax([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmax([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmin([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmin([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmin([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmin([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMaxMag([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMaxMag([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMaxMag([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMaxMag([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMinMag([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMinMag([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMinMag([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMinMag([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNearbyInt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNearbyInt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNearbyInt([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNearbyInt([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRint([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRint([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRint([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRint([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRound([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRound([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRound([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRound([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTrunc([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTrunc([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTrunc([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTrunc([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMulByConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMulByConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMulByConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMulByConj([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCIS([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCIS([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCIS([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCIS([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpInt1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpInt1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpInt1([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpInt1([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcArg_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzArg_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcArg_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzArg_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpm1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpm1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpm1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpm1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog1p_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog1p_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog1p_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog1p_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLogb_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLogb_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLogb_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLogb_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSind_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSind_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSind_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSind_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTand_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTand_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTand_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTand_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsHypot_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdHypot_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsHypot_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdHypot_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNorm_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNorm_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNorm_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNorm_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNormInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNormInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNormInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNormInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI0_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI0_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI0_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI0_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI1_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI1_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI1_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI1_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsYn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdYn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsYn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdYn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2pi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2pi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2pi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2pi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow3o2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow3o2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow3o2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow3o2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow2o3_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow2o3_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow2o3_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow2o3_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float")] float b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double")] double b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLinearFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLinearFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLinearFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLinearFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCeil_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCeil_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCeil_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCeil_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFloor_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFloor_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFloor_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFloor_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsModf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdModf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsModf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdModf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmod_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmod_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmod_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmod_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRemainder_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRemainder_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRemainder_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRemainder_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNextAfter_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNextAfter_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNextAfter_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNextAfter_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCopySign_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCopySign_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCopySign_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCopySign_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFdim_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFdim_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFdim_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFdim_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmax_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmax_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmax_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmax_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMaxMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMaxMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMaxMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMaxMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMinMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMinMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMinMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const float[]")] float* b, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMinMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const double[]")] double* b, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNearbyInt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNearbyInt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNearbyInt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNearbyInt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRint_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRint_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRint_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRint_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRound_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRound_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRound_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRound_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTrunc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTrunc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTrunc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTrunc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMulByConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMulByConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMulByConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMulByConj_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCIS_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCIS_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("MKL_Complex16[]")] Complex* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCIS_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCIS_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpInt1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpInt1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpInt1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpInt1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* r, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcArgI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzArgI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcArgI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzArgI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAddI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAddI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAddI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAddI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAddI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* param5, [NativeTypeName("const int")] int param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAddI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* param5, [NativeTypeName("const int")] int param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAddI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAddI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSubI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSubI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSubI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSubI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSubI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSubI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSubI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSubI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqrI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqrI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqrI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqrI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp10I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp10I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp10I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp10I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpm1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpm1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpm1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpm1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcExpI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzExpI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcExpI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzExpI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLnI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLnI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLnI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLnI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLnI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLnI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLnI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLnI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog1pI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog1pI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog1pI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog1pI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLogbI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLogbI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLogbI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLogbI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosdI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosdI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosdI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosdI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSindI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSindI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSindI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSindI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTandI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTandI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTandI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTandI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcospiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcospiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcospiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcospiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsHypotI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdHypotI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsHypotI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdHypotI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcxI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcxI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcxI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcxI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNormI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNormI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNormI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNormI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNormInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNormInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNormInvI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNormInvI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI0I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI0I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI0I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI0I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ0I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ0I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ0I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ0I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY0I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY0I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY0I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY0I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJnI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJnI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJnI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJnI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsYnI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdYnI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsYnI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdYnI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2piI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2piI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2piI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2piI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMulI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMulI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMulI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMulI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMulI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMulI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMulI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMulI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsDivI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdDivI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsDivI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdDivI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcDivI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzDivI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcDivI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzDivI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFdimI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFdimI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFdimI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFdimI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmodI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmodI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmodI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmodI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmaxI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmaxI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmaxI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmaxI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFminI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFminI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFminI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFminI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPowI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPowI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPowI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPowI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowrI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowrI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowrI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowrI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow3o2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow3o2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow3o2I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow3o2I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow2o3I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow2o3I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow2o3I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow2o3I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCosI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCosI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCosI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCosI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLinearFracI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLinearFracI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLinearFracI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLinearFracI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCeilI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCeilI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCeilI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCeilI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFloorI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFloorI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFloorI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFloorI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFracI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFracI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFracI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFracI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsModfI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdModfI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsModfI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdModfI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNearbyIntI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNearbyIntI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNearbyIntI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNearbyIntI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNextAfterI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNextAfterI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNextAfterI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNextAfterI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMinMagI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMinMagI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMinMagI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMinMagI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMaxMagI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMaxMagI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMaxMagI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMaxMagI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRintI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRintI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRintI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRintI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRoundI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRoundI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRoundI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRoundI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTruncI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTruncI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTruncI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTruncI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMulByConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMulByConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMulByConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMulByConjI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const int")] int incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCISI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCISI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCISI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCISI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpInt1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpInt1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpInt1I([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpInt1I([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCopySignI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCopySignI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCopySignI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCopySignI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRemainderI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRemainderI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRemainderI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const int")] int incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRemainderI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const int")] int incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcArgI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzArgI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcArgI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzArgI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* param5, [NativeTypeName("const long long")] long param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* param5, [NativeTypeName("const long long")] long param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsInvCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdInvCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsInvCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdInvCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSqrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSqrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSqrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSqrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExp10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExp10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExp10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExp10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpm1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpm1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpm1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpm1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLog1pI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLog1pI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLog1pI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLog1pI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLogbI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLogbI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLogbI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLogbI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCosdI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCosdI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCosdI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCosdI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSindI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSindI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSindI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSindI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTandI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTandI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTandI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTandI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsHypotI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdHypotI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsHypotI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdHypotI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsErfcxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdErfcxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsErfcxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdErfcxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNormI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNormI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNormI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNormI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCdfNormInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCdfNormInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCdfNormInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCdfNormInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsI1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdI1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsI1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdI1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJ1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJ1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJ1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJ1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY0I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsY1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdY1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsY1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdY1I_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsJnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdJnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsJnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdJnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsYnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdYnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsYnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdYnI_64([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsAtan2piI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdAtan2piI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsAtan2piI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdAtan2piI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFdimI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFdimI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFdimI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFdimI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmodI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmodI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmodI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmodI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFmaxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFmaxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFmaxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFmaxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFminI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFminI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFminI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFminI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow3o2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow3o2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow3o2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow3o2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPow2o3I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPow2o3I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPow2o3I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPow2o3I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float")] float param3, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double")] double param3, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8")] ComplexF b, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16")] Complex b, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsSinCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdSinCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsSinCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdSinCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsLinearFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdLinearFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsLinearFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("const float")] float scalea, [NativeTypeName("const float")] float shifta, [NativeTypeName("const float")] float scaleb, [NativeTypeName("const float")] float shiftb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdLinearFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("const double")] double scalea, [NativeTypeName("const double")] double shifta, [NativeTypeName("const double")] double scaleb, [NativeTypeName("const double")] double shiftb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCeilI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCeilI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCeilI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCeilI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFloorI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFloorI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFloorI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFloorI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsModfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdModfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsModfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("float[]")] float* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdModfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("double[]")] double* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNearbyIntI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNearbyIntI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNearbyIntI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNearbyIntI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsNextAfterI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdNextAfterI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsNextAfterI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdNextAfterI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMinMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMinMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMinMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMinMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsMaxMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdMaxMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsMaxMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdMaxMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRintI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRintI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRintI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRintI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRoundI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRoundI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRoundI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRoundI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsTruncI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdTruncI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsTruncI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdTruncI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcMulByConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzMulByConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcMulByConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex8[]")] ComplexF* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzMulByConjI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const MKL_Complex16[]")] Complex* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcCISI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzCISI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmcCISI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex8[]")] ComplexF* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmzCISI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("MKL_Complex16[]")] Complex* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsExpInt1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdExpInt1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsExpInt1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdExpInt1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsCopySignI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdCopySignI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsCopySignI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdCopySignI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsRemainderI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdRemainderI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmsRemainderI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const float[]")] float* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("float[]")] float* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmdRemainderI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const double[]")] double* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("double[]")] double* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAbs([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAbs([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAdd([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAdd([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSub([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSub([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvSqrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvCbrt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqr([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqr([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp10([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp10([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpm1([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpm1([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLn([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLn([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog10([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog10([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog1p([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog1p([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLogb([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLogb([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCos([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCos([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSin([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSin([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTan([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTan([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCospi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCospi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosd([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosd([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSind([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSind([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTand([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTand([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcos([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcos([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsin([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsin([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcospi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcospi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanpi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcosh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanh([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErf([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErf([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhHypot([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhHypot([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfc([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfc([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNorm([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNorm([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNormInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNormInv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLGamma([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLGamma([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTGamma([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTGamma([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2pi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2pi([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMul([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMul([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhDiv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhDiv([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow3o2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow3o2([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow2o3([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow2o3([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowx([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowx([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowr([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowr([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinCos([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinCos([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLinearFrac([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLinearFrac([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCeil([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCeil([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFloor([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFloor([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFrac([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFrac([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhModf([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhModf([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmod([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmod([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRemainder([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRemainder([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNextAfter([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNextAfter([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCopySign([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCopySign([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFdim([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFdim([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmax([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmax([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmin([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmin([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMaxMag([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMaxMag([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMinMag([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMinMag([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNearbyInt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNearbyInt([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRint([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRint([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRound([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRound([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTrunc([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTrunc([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpInt1([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpInt1([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcx([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcx([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI0([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI0([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI1([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI1([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ0([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ0([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ1([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ1([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY0([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY0([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY1([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY1([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJn([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJn([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhYn([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhYn([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAbs_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAdd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSub_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvSqrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvCbrt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpm1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpm1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog10_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog1p_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog1p_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLogb_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLogb_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosd_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSind_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSind_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTand_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTand_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcospi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanpi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcosh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanh_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhHypot_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhHypot_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNorm_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNorm_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNormInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNormInv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTGamma_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2pi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2pi_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMul_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhDiv_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow3o2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow3o2_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow2o3_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow2o3_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowr_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinCos_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLinearFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLinearFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCeil_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCeil_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFloor_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFloor_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFrac_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhModf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhModf_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmod_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmod_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRemainder_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRemainder_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNextAfter_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNextAfter_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCopySign_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCopySign_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFdim_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFdim_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmax_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmax_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmin_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMaxMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMaxMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMinMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMinMag_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNearbyInt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNearbyInt_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRint_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRint_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRound_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRound_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTrunc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTrunc_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpInt1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpInt1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcx_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY0_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY1_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhYn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhYn_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const unsigned short")] ushort b, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAbsI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAddI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAddI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSubI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSubI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvSqrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvCbrtI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqrI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqrI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp10I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp10I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpm1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpm1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLnI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLnI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog10I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog1pI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog1pI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLogbI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLogbI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCoshI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosdI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosdI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCospiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSindI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSindI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTandI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTandI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcosI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcospiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcospiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanpiI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcoshI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanhI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhHypotI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhHypotI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNormI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNormI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNormInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNormInvI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTGammaI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2piI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2piI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMulI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMulI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhDivI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhDivI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFdimI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFdimI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmodI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmodI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmaxI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmaxI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFminI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFminI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowrI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowrI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow3o2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow3o2I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow2o3I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow2o3I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowxI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinCosI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinCosI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLinearFracI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLinearFracI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCeilI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCeilI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFloorI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFloorI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFracI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFracI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhModfI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const int")] int incr2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhModfI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const int")] int incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const int")] int incr2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNearbyIntI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNearbyIntI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNextAfterI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNextAfterI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMinMagI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMinMagI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMaxMagI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMaxMagI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRintI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRintI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRoundI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRoundI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTruncI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTruncI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpInt1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpInt1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCopySignI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCopySignI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRemainderI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRemainderI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const int")] int incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vErfcxI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcxI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI0I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI0I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ0I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ0I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY0I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY0I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY1I([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJnI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJnI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhYnI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhYnI([NativeTypeName("const int")] int n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const int")] int inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const int")] int incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAbsI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAddI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSubI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvSqrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhInvCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhInvCbrtI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSqrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSqrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExp10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExp10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpm1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpm1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog10I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLog1pI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLog1pI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLogbI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLogbI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCosdI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCosdI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSindI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSindI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTandI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTandI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcospiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanpiI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAcoshI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAsinhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtanhI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhHypotI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhHypotI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNormI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNormI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCdfNormInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCdfNormInvI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTGammaI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhAtan2piI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhAtan2piI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMulI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhDivI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFdimI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFdimI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmodI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmodI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFmaxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFmaxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFminI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFminI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowrI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow3o2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow3o2I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPow2o3I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPow2o3I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhPowxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhSinCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhSinCosI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhLinearFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhLinearFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("const unsigned short")] ushort scalea, [NativeTypeName("const unsigned short")] ushort shifta, [NativeTypeName("const unsigned short")] ushort scaleb, [NativeTypeName("const unsigned short")] ushort shiftb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCeilI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCeilI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFloorI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFloorI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhFracI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhModfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const long long")] long incr2);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhModfI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r1, [NativeTypeName("const long long")] long incr1, [NativeTypeName("unsigned short[]")] ushort* r2, [NativeTypeName("const long long")] long incr2, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNearbyIntI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNearbyIntI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhNextAfterI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhNextAfterI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMinMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMinMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhMaxMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhMaxMagI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRintI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRintI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRoundI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRoundI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhTruncI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhTruncI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhExpInt1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhExpInt1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhCopySignI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhCopySignI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhRemainderI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhRemainderI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short[]")] ushort* b, [NativeTypeName("const long long")] long incb, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhErfcxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long inc6r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhErfcxI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI0I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long inc6r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI0I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhI1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long inc6r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhI1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ0I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long inc6r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ0I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJ1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long inc6r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJ1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY0I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long inc6r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY0I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhY1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long inc6r);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhY1I_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhJnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhJnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vhYnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr);

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vmhYnI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const unsigned short[]")] ushort* a, [NativeTypeName("const long long")] long inca, [NativeTypeName("const unsigned short")] ushort param3, [NativeTypeName("unsigned short[]")] ushort* r, [NativeTypeName("const long long")] long incr, [NativeTypeName("long long")] long mode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPackI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int")] int incra, [NativeTypeName("float[]")] float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPackI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int")] int incra, [NativeTypeName("double[]")] double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPackI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int")] int incra, [NativeTypeName("MKL_Complex8[]")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPackI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int")] int incra, [NativeTypeName("MKL_Complex16[]")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPackV([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int[]")] int* ia, [NativeTypeName("float[]")] float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPackV([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int[]")] int* ia, [NativeTypeName("double[]")] double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPackV([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int[]")] int* ia, [NativeTypeName("MKL_Complex8[]")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPackV([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int[]")] int* ia, [NativeTypeName("MKL_Complex16[]")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPackM([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const int[]")] int* ma, [NativeTypeName("float[]")] float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPackM([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const int[]")] int* ma, [NativeTypeName("double[]")] double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPackM([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const int[]")] int* ma, [NativeTypeName("MKL_Complex8[]")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPackM([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const int[]")] int* ma, [NativeTypeName("MKL_Complex16[]")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsUnpackI([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* y, [NativeTypeName("const int")] int incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdUnpackI([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* y, [NativeTypeName("const int")] int incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcUnpackI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* y, [NativeTypeName("const int")] int incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzUnpackI([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* y, [NativeTypeName("const int")] int incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsUnpackV([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* y, [NativeTypeName("const int[]")] int* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdUnpackV([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* y, [NativeTypeName("const int[]")] int* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcUnpackV([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* y, [NativeTypeName("const int[]")] int* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzUnpackV([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* y, [NativeTypeName("const int[]")] int* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsUnpackM([NativeTypeName("const int")] int n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* y, [NativeTypeName("const int[]")] int* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdUnpackM([NativeTypeName("const int")] int n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* y, [NativeTypeName("const int[]")] int* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcUnpackM([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* y, [NativeTypeName("const int[]")] int* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzUnpackM([NativeTypeName("const int")] int n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* y, [NativeTypeName("const int[]")] int* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long")] long incra, [NativeTypeName("float[]")] float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long")] long incra, [NativeTypeName("double[]")] double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long")] long incra, [NativeTypeName("MKL_Complex8[]")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long")] long incra, [NativeTypeName("MKL_Complex16[]")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long[]")] long* ia, [NativeTypeName("float[]")] float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long[]")] long* ia, [NativeTypeName("double[]")] double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long[]")] long* ia, [NativeTypeName("MKL_Complex8[]")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long[]")] long* ia, [NativeTypeName("MKL_Complex16[]")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsPackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("const long long[]")] long* ma, [NativeTypeName("float[]")] float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdPackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("const long long[]")] long* ma, [NativeTypeName("double[]")] double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcPackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("const long long[]")] long* ma, [NativeTypeName("MKL_Complex8[]")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzPackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("const long long[]")] long* ma, [NativeTypeName("MKL_Complex16[]")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsUnpackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* y, [NativeTypeName("const long long")] long incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdUnpackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* y, [NativeTypeName("const long long")] long incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcUnpackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* y, [NativeTypeName("const long long")] long incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzUnpackI_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* y, [NativeTypeName("const long long")] long incry);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsUnpackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* y, [NativeTypeName("const long long[]")] long* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdUnpackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* y, [NativeTypeName("const long long[]")] long* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcUnpackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* y, [NativeTypeName("const long long[]")] long* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzUnpackV_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* y, [NativeTypeName("const long long[]")] long* iy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vsUnpackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const float[]")] float* a, [NativeTypeName("float[]")] float* y, [NativeTypeName("const long long[]")] long* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vdUnpackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const double[]")] double* a, [NativeTypeName("double[]")] double* y, [NativeTypeName("const long long[]")] long* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vcUnpackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex8[]")] ComplexF* a, [NativeTypeName("MKL_Complex8[]")] ComplexF* y, [NativeTypeName("const long long[]")] long* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vzUnpackM_64([NativeTypeName("const long long")] long n, [NativeTypeName("const MKL_Complex16[]")] Complex* a, [NativeTypeName("MKL_Complex16[]")] Complex* y, [NativeTypeName("const long long[]")] long* my);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vmlSetErrStatus([NativeTypeName("const int")] int status);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vmlGetErrStatus();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vmlClearErrStatus();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VMLErrorCallBack")]
        public static extern delegate* unmanaged[Cdecl]<nint, int> vmlSetErrorCallBack([NativeTypeName("const VMLErrorCallBack")] delegate* unmanaged[Cdecl]<nint, int> func);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VMLErrorCallBack")]
        public static extern delegate* unmanaged[Cdecl]<nint, int> vmlGetErrorCallBack();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VMLErrorCallBack")]
        public static extern delegate* unmanaged[Cdecl]<nint, int> vmlClearErrorCallBack();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long vmlSetErrStatus_64([NativeTypeName("const long long")] long status);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long vmlGetErrStatus_64();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long vmlClearErrStatus_64();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VMLErrorCallBack")]
        public static extern delegate* unmanaged[Cdecl]<nint, int> vmlSetErrorCallBack_64([NativeTypeName("const VMLErrorCallBack")] delegate* unmanaged[Cdecl]<nint, int> func);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VMLErrorCallBack")]
        public static extern delegate* unmanaged[Cdecl]<nint, int> vmlGetErrorCallBack_64();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VMLErrorCallBack")]
        public static extern delegate* unmanaged[Cdecl]<nint, int> vmlClearErrorCallBack_64();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint vmlSetMode([NativeTypeName("const unsigned int")] uint newmode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint vmlGetMode();

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKLFreeTls([NativeTypeName("const unsigned int")] uint fdwReason);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong vmlSetMode_64([NativeTypeName("const unsigned long long")] ulong newmode);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong vmlGetMode_64();

        [DllImport("unknown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKLFreeTls_64([NativeTypeName("const unsigned long long")] ulong fdwReason);
    }
}
