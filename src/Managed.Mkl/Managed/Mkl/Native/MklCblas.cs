using System.Runtime.InteropServices;

namespace Managed.Mkl.Native
{
    public enum CblasLayout
    {
        CblasRowMajor = 101,
        CblasColMajor = 102,
    }

    public enum CblasTranspose
    {
        CblasNoTrans = 111,
        CblasTrans = 112,
        CblasConjTrans = 113,
    }

    public enum CblasUpLo
    {
        CblasUpper = 121,
        CblasLower = 122,
    }

    public enum CblasDiag
    {
        CblasNonUnit = 131,
        CblasUnit = 132,
    }

    public enum CblasSide
    {
        CblasLeft = 141,
        CblasRight = 142,
    }

    public enum CblasStorage
    {
        CblasPacked = 151,
    }

    public enum CblasIdentifier
    {
        CblasAMatrix = 161,
        CblasBMatrix = 162,
    }

    public enum CblasOffset
    {
        CblasRowOffset = 171,
        CblasColOffset = 172,
        CblasFixOffset = 173,
    }

    public static unsafe partial class MklCblas
    {
        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dcabs1([NativeTypeName("const void *")] void* z);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_scabs1([NativeTypeName("const void *")] void* c);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sdot([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sdoti([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const float *")] float* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_ddot([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_ddoti([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const double *")] double* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dsdot([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sdsdot([NativeTypeName("const int")] int N, [NativeTypeName("const float")] float sb, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotu_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* dotu);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotui_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotc_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* dotc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotci_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotu_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* dotu);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotui_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotc_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* dotc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotci_sub([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_snrm2([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sasum([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dnrm2([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dasum([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_scnrm2([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_scasum([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dznrm2([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dzasum([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_isamax([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_idamax([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_icamax([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_izamax([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_isamin([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_idamin([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_icamin([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_izamin([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sswap([NativeTypeName("const int")] int N, float* X, [NativeTypeName("const int")] int incX, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_scopy([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpy([NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpby([NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpyi([NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int *")] int* indx, float* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgthr([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* Y, float* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgthrz([NativeTypeName("const int")] int N, float* Y, float* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssctr([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int *")] int* indx, float* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_srotg(float* a, float* b, float* c, float* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dswap([NativeTypeName("const int")] int N, double* X, [NativeTypeName("const int")] int incX, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dcopy([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpy([NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpby([NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpyi([NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int *")] int* indx, double* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgthr([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* Y, double* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgthrz([NativeTypeName("const int")] int N, double* Y, double* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsctr([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int *")] int* indx, double* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_drotg(double* a, double* b, double* c, double* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cswap([NativeTypeName("const int")] int N, void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ccopy([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpy([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpby([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpyi([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgthr([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* Y, void* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgthrz([NativeTypeName("const int")] int N, void* Y, void* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csctr([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_crotg(void* a, [NativeTypeName("const void *")] void* b, float* c, void* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zswap([NativeTypeName("const int")] int N, void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zcopy([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpy([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpby([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpyi([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgthr([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* Y, void* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgthrz([NativeTypeName("const int")] int N, void* Y, void* X, [NativeTypeName("const int *")] int* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsctr([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int *")] int* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zrotg(void* a, [NativeTypeName("const void *")] void* b, double* c, void* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_srotmg(float* d1, float* d2, float* b1, [NativeTypeName("const float")] float b2, float* P);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sroti([NativeTypeName("const int")] int N, float* X, [NativeTypeName("const int *")] int* indx, float* Y, [NativeTypeName("const float")] float c, [NativeTypeName("const float")] float s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_srotm([NativeTypeName("const int")] int N, float* X, [NativeTypeName("const int")] int incX, float* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const float *")] float* P);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_drotmg(double* d1, double* d2, double* b1, [NativeTypeName("const double")] double b2, double* P);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_drotm([NativeTypeName("const int")] int N, double* X, [NativeTypeName("const int")] int incX, double* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const double *")] double* P);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_droti([NativeTypeName("const int")] int N, double* X, [NativeTypeName("const int *")] int* indx, double* Y, [NativeTypeName("const double")] double c, [NativeTypeName("const double")] double s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sscal([NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dscal([NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cscal([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zscal([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csscal([NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdscal([NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_srot([NativeTypeName("const int")] int N, float* X, [NativeTypeName("const int")] int incX, float* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const float")] float c, [NativeTypeName("const float")] float s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_drot([NativeTypeName("const int")] int N, double* X, [NativeTypeName("const int")] int incX, double* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const double")] double c, [NativeTypeName("const double")] double s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_crot([NativeTypeName("const int")] int N, void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const float")] float c, [NativeTypeName("const void *")] void* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zrot([NativeTypeName("const int")] int N, void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const double")] double c, [NativeTypeName("const void *")] void* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csrot([NativeTypeName("const int")] int N, void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const float")] float c, [NativeTypeName("const float")] float s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdrot([NativeTypeName("const int")] int N, void* X, [NativeTypeName("const int")] int incX, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const double")] double c, [NativeTypeName("const double")] double s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int KL, [NativeTypeName("const int")] int KU, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stpmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* Ap, float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stbsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stpsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* Ap, float* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int KL, [NativeTypeName("const int")] int KU, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtpmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* Ap, double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtbsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtpsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* Ap, double* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int KL, [NativeTypeName("const int")] int KU, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctpmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctbsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctpsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int KL, [NativeTypeName("const int")] int KU, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztpmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztbsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztpsv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const int")] int incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssymv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sspmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* Ap, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sger([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const int")] int incY, float* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyr([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, float* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sspr([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, float* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyr2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const int")] int incY, float* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sspr2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const int")] int incY, float* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsymv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dspmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* Ap, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dger([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const int")] int incY, double* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyr([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, double* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dspr([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, double* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyr2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const int")] int incY, double* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dspr2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const int")] int incY, double* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chemv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chpmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* Ap, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgeru([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgerc([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cher([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chpr([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cher2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chpr2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhemv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhbmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhpmv([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* Ap, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgeru([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgerc([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zher([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhpr([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, void* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zher2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* A, [NativeTypeName("const int")] int lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhpr2([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const int")] int incY, void* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const int *")] int* K_Array, [NativeTypeName("const float *")] float* alpha_Array, [NativeTypeName("const float **")] float** A_Array, [NativeTypeName("const int *")] int* lda_Array, [NativeTypeName("const float **")] float** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const float *")] float* beta_Array, float** C_Array, [NativeTypeName("const int *")] int* ldc_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemmt([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssymm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyrk([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyrk_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyrk_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const int *")] int* N_array, [NativeTypeName("const int *")] int* K_array, [NativeTypeName("const float *")] float* alpha_array, [NativeTypeName("const float **")] float** A_array, [NativeTypeName("const int *")] int* lda_array, [NativeTypeName("const float *")] float* beta_array, float** C_array, [NativeTypeName("const int *")] int* ldc_array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyr2k([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strmm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, float* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strmm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, float* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const float *")] float* alpha_Array, [NativeTypeName("const float **")] float** A_Array, [NativeTypeName("const int *")] int* lda_Array, float** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const int *")] int* K_Array, [NativeTypeName("const double *")] double* alpha_Array, [NativeTypeName("const double **")] double** A_Array, [NativeTypeName("const int *")] int* lda_Array, [NativeTypeName("const double **")] double** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const double *")] double* beta_Array, double** C_Array, [NativeTypeName("const int *")] int* ldc_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemmt([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsymm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyrk([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyrk_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const int *")] int* N_array, [NativeTypeName("const int *")] int* K_array, [NativeTypeName("const double *")] double* alpha_array, [NativeTypeName("const double **")] double** A_array, [NativeTypeName("const int *")] int* lda_array, [NativeTypeName("const double *")] double* beta_array, double** C_array, [NativeTypeName("const int *")] int* ldc_array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyrk_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyr2k([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrmm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, double* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrmm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, double* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Transa_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const double *")] double* alpha_Array, [NativeTypeName("const double **")] double** A_Array, [NativeTypeName("const int *")] int* lda_Array, double** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm3m([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const int *")] int* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const int *")] int* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const int *")] int* ldc_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm3m_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const int *")] int* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const int *")] int* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const int *")] int* ldc_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm3m_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemmt([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csymm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyrk([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyrk_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const int *")] int* N_array, [NativeTypeName("const int *")] int* K_array, [NativeTypeName("const void *")] void* alpha_array, [NativeTypeName("const void **")] void** A_array, [NativeTypeName("const int *")] int* lda_array, [NativeTypeName("const void *")] void* beta_array, void** C_array, [NativeTypeName("const int *")] int* ldc_array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyrk_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyr2k([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrmm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrmm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Transa_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const int *")] int* lda_Array, void** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm3m([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const int *")] int* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const int *")] int* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const int *")] int* ldc_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm3m_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const int *")] int* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const int *")] int* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const int *")] int* ldc_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm3m_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemmt([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsymm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyrk([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyrk_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const int *")] int* N_array, [NativeTypeName("const int *")] int* K_array, [NativeTypeName("const void *")] void* alpha_array, [NativeTypeName("const void **")] void** A_array, [NativeTypeName("const int *")] int* lda_array, [NativeTypeName("const void *")] void* beta_array, void** C_array, [NativeTypeName("const int *")] int* ldc_array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyrk_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyr2k([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrmm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrmm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, void* B, [NativeTypeName("const int")] int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm_oop([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Transa_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const int *")] int* M_Array, [NativeTypeName("const int *")] int* N_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const int *")] int* lda_Array, void** B_Array, [NativeTypeName("const int *")] int* ldb_Array, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const int")] int strideb, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chemm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cherk([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float")] float beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cher2k([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhemm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zherk([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double")] double beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zher2k([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, void* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_sgemm_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* src, [NativeTypeName("const int")] int ld, float* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_dgemm_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* src, [NativeTypeName("const int")] int ld, double* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_hgemm([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const unsigned short")] ushort alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const unsigned short")] ushort beta, [NativeTypeName("unsigned short *")] ushort* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_hgemm_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_hgemm_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const unsigned short")] ushort alpha, [NativeTypeName("const unsigned short *")] ushort* src, [NativeTypeName("const int")] int ld, [NativeTypeName("unsigned short *")] ushort* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_hgemm_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const unsigned short")] ushort beta, [NativeTypeName("unsigned short *")] ushort* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s16s16s32([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset OffsetC, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const short *")] short* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const short")] short ao, [NativeTypeName("const short *")] short* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const short")] short bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int *")] int* cb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s8u8s32([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset OffsetC, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const char")] sbyte ao, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const char")] sbyte bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int *")] int* cb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_bf16bf16f32([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_f16f16f32([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e5m2e5m2f32([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e4m3e4m3f32([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_s8u8s32_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_s16s16s32_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_bf16bf16f32_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_f16f16f32_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_e5m2e5m2f32_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_e4m3e4m3f32_pack_get_size([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s8u8s32_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const void *")] void* src, [NativeTypeName("const int")] int ld, void* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s16s16s32_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const short *")] short* src, [NativeTypeName("const int")] int ld, short* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_bf16bf16f32_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const unsigned short *")] ushort* src, [NativeTypeName("const int")] int ld, [NativeTypeName("unsigned short *")] ushort* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_f16f16f32_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const unsigned short *")] ushort* src, [NativeTypeName("const int")] int ld, [NativeTypeName("unsigned short *")] ushort* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e5m2e5m2f32_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const unsigned char *")] byte* src, [NativeTypeName("const int")] int ld, [NativeTypeName("unsigned char *")] byte* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e4m3e4m3f32_pack([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const unsigned char *")] byte* src, [NativeTypeName("const int")] int ld, [NativeTypeName("unsigned char *")] byte* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s8u8s32_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset offsetc, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const char")] sbyte ao, [NativeTypeName("const void *")] void* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const char")] sbyte bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int *")] int* co);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s16s16s32_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset offsetc, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const short *")] short* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const short")] short ao, [NativeTypeName("const short *")] short* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const short")] short bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int *")] int* co);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_bf16bf16f32_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_f16f16f32_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e5m2e5m2f32_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e4m3e4m3f32_compute([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const int")] int TransA, [NativeTypeName("const int")] int TransB, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const int")] int K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_dgemm(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const int")] int k, [NativeTypeName("const double")] double alpha, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double beta, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_sgemm(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const int")] int k, [NativeTypeName("const float")] float alpha, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float beta, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_cgemm(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const int")] int k, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_zgemm(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const int")] int k, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int ldb, [NativeTypeName("const void *")] void* beta, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("dgemm_jit_kernel_t")]
        public static extern delegate* unmanaged[Cdecl]<void*, double*, double*, double*, void> mkl_jit_get_dgemm_ptr([NativeTypeName("const void *")] void* jitter);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("sgemm_jit_kernel_t")]
        public static extern delegate* unmanaged[Cdecl]<void*, float*, float*, float*, void> mkl_jit_get_sgemm_ptr([NativeTypeName("const void *")] void* jitter);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("cgemm_jit_kernel_t")]
        public static extern delegate* unmanaged[Cdecl]<void*, ComplexF*, ComplexF*, ComplexF*, void> mkl_jit_get_cgemm_ptr([NativeTypeName("const void *")] void* jitter);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("zgemm_jit_kernel_t")]
        public static extern delegate* unmanaged[Cdecl]<void*, Complex*, Complex*, Complex*, void> mkl_jit_get_zgemm_ptr([NativeTypeName("const void *")] void* jitter);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_jit_destroy(void* jitter);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const float **")] float** x, [NativeTypeName("const int *")] int* incx, float** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const double **")] double** x, [NativeTypeName("const int *")] int* incx, double** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** x, [NativeTypeName("const int *")] int* incx, void** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** x, [NativeTypeName("const int *")] int* incx, void** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, float* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, double* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_scopy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const float **")] float** x, [NativeTypeName("const int *")] int* incx, float** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dcopy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const double **")] double** x, [NativeTypeName("const int *")] int* incx, double** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ccopy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const void **")] void** x, [NativeTypeName("const int *")] int* incx, void** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zcopy_batch([NativeTypeName("const int *")] int* n, [NativeTypeName("const void **")] void** x, [NativeTypeName("const int *")] int* incx, void** y, [NativeTypeName("const int *")] int* incy, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_scopy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, float* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dcopy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, double* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ccopy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zcopy_batch_strided([NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemv_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const int *")] int* M, [NativeTypeName("const int *")] int* N, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const float **")] float** A, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const float **")] float** X, [NativeTypeName("const int *")] int* incX, [NativeTypeName("const float *")] float* beta, float** Y, [NativeTypeName("const int *")] int* incY, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemv_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const float *")] float* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemv_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const int *")] int* M, [NativeTypeName("const int *")] int* N, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const double **")] double** A, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const double **")] double** X, [NativeTypeName("const int *")] int* incX, [NativeTypeName("const double *")] double* beta, double** Y, [NativeTypeName("const int *")] int* incY, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemv_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const double *")] double* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemv_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const int *")] int* M, [NativeTypeName("const int *")] int* N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** A, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const void **")] void** X, [NativeTypeName("const int *")] int* incX, [NativeTypeName("const void *")] void* beta, void** Y, [NativeTypeName("const int *")] int* incY, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemv_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemv_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const int *")] int* M, [NativeTypeName("const int *")] int* N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** A, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const void **")] void** X, [NativeTypeName("const int *")] int* incX, [NativeTypeName("const void *")] void* beta, void** Y, [NativeTypeName("const int *")] int* incY, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemv_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const int")] int M, [NativeTypeName("const int")] int N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* X, [NativeTypeName("const int")] int incX, [NativeTypeName("const int")] int stridex, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const int")] int incY, [NativeTypeName("const int")] int stridey, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sdgmm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float **")] float** a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const float **")] float** x, [NativeTypeName("const int *")] int* incx, float** c, [NativeTypeName("const int *")] int* ldc, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sdgmm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const float *")] float* x, [NativeTypeName("const int")] int incx, [NativeTypeName("const int")] int stridex, float* c, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ddgmm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double **")] double** a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const double **")] double** x, [NativeTypeName("const int *")] int* incx, double** c, [NativeTypeName("const int *")] int* ldc, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ddgmm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int")] int incx, [NativeTypeName("const int")] int stridex, double* c, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdgmm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const void **")] void** a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const void **")] void** x, [NativeTypeName("const int *")] int* incx, void** c, [NativeTypeName("const int *")] int* ldc, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdgmm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* x, [NativeTypeName("const int")] int incx, [NativeTypeName("const int")] int stridex, void* c, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdgmm_batch([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const void **")] void** a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const void **")] void** x, [NativeTypeName("const int *")] int* incx, void** c, [NativeTypeName("const int *")] int* ldc, [NativeTypeName("const int")] int group_count, [NativeTypeName("const int *")] int* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdgmm_batch_strided([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const int")] int m, [NativeTypeName("const int")] int n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const int")] int lda, [NativeTypeName("const int")] int stridea, [NativeTypeName("const void *")] void* x, [NativeTypeName("const int")] int incx, [NativeTypeName("const int")] int stridex, void* c, [NativeTypeName("const int")] int ldc, [NativeTypeName("const int")] int stridec, [NativeTypeName("const int")] int batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sdot_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sdoti_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const float *")] float* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_ddot_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_ddoti_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const double *")] double* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dsdot_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sdsdot_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float sb, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotu_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* dotu);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotui_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotc_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* dotc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdotci_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotu_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* dotu);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotui_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotc_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* dotc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdotci_sub_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const void *")] void* Y, void* dotui);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_snrm2_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_sasum_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dnrm2_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dasum_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_scnrm2_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float cblas_scasum_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dznrm2_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double cblas_dzasum_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_isamax_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_idamax_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_icamax_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_izamax_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_isamin_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_idamin_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_icamin_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong cblas_izamin_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sswap_64([NativeTypeName("const long long")] long N, float* X, [NativeTypeName("const long long")] long incX, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_scopy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpby_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpyi_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long *")] long* indx, float* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgthr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* Y, float* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgthrz_64([NativeTypeName("const long long")] long N, float* Y, float* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssctr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long *")] long* indx, float* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dswap_64([NativeTypeName("const long long")] long N, double* X, [NativeTypeName("const long long")] long incX, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dcopy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpby_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpyi_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long *")] long* indx, double* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgthr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* Y, double* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgthrz_64([NativeTypeName("const long long")] long N, double* Y, double* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsctr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long *")] long* indx, double* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cswap_64([NativeTypeName("const long long")] long N, void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ccopy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpby_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpyi_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgthr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* Y, void* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgthrz_64([NativeTypeName("const long long")] long N, void* Y, void* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csctr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zswap_64([NativeTypeName("const long long")] long N, void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zcopy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpy_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpby_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpyi_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgthr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* Y, void* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgthrz_64([NativeTypeName("const long long")] long N, void* Y, void* X, [NativeTypeName("const long long *")] long* indx);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsctr_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long *")] long* indx, void* Y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sroti_64([NativeTypeName("const long long")] long N, float* X, [NativeTypeName("const long long *")] long* indx, float* Y, [NativeTypeName("const float")] float c, [NativeTypeName("const float")] float s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_srotm_64([NativeTypeName("const long long")] long N, float* X, [NativeTypeName("const long long")] long incX, float* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const float *")] float* P);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_drotm_64([NativeTypeName("const long long")] long N, double* X, [NativeTypeName("const long long")] long incX, double* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const double *")] double* P);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_droti_64([NativeTypeName("const long long")] long N, double* X, [NativeTypeName("const long long *")] long* indx, double* Y, [NativeTypeName("const double")] double c, [NativeTypeName("const double")] double s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sscal_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dscal_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cscal_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zscal_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csscal_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdscal_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_srot_64([NativeTypeName("const long long")] long N, float* X, [NativeTypeName("const long long")] long incX, float* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const float")] float c, [NativeTypeName("const float")] float s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_drot_64([NativeTypeName("const long long")] long N, double* X, [NativeTypeName("const long long")] long incX, double* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const double")] double c, [NativeTypeName("const double")] double s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_crot_64([NativeTypeName("const long long")] long N, void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const float")] float c, [NativeTypeName("const void *")] void* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zrot_64([NativeTypeName("const long long")] long N, void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const double")] double c, [NativeTypeName("const void *")] void* s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csrot_64([NativeTypeName("const long long")] long N, void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const float")] float c, [NativeTypeName("const float")] float s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdrot_64([NativeTypeName("const long long")] long N, void* X, [NativeTypeName("const long long")] long incX, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const double")] double c, [NativeTypeName("const double")] double s);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long KL, [NativeTypeName("const long long")] long KU, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stpmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* Ap, float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stbsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_stpsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* Ap, float* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long KL, [NativeTypeName("const long long")] long KU, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtpmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* Ap, double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtbsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtpsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* Ap, double* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long KL, [NativeTypeName("const long long")] long KU, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctpmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctbsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctpsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long KL, [NativeTypeName("const long long")] long KU, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztpmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztbsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztpsv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* Ap, void* X, [NativeTypeName("const long long")] long incX);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssymv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sspmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* Ap, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sger_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const long long")] long incY, float* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyr_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, float* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sspr_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, float* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyr2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const long long")] long incY, float* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sspr2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const float *")] float* Y, [NativeTypeName("const long long")] long incY, float* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsymv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dspmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* Ap, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dger_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const long long")] long incY, double* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyr_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, double* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dspr_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, double* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyr2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const long long")] long incY, double* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dspr2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const double *")] double* Y, [NativeTypeName("const long long")] long incY, double* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chemv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chpmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* Ap, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgeru_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgerc_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cher_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chpr_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cher2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chpr2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhemv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhbmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhpmv_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* Ap, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgeru_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgerc_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zher_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhpr_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, void* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zher2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* A, [NativeTypeName("const long long")] long lda);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhpr2_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const void *")] void* Y, [NativeTypeName("const long long")] long incY, void* Ap);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const long long *")] long* K_Array, [NativeTypeName("const float *")] float* alpha_Array, [NativeTypeName("const float **")] float** A_Array, [NativeTypeName("const long long *")] long* lda_Array, [NativeTypeName("const float **")] float** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const float *")] float* beta_Array, float** C_Array, [NativeTypeName("const long long *")] long* ldc_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemmt_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssymm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyrk_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyrk_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyrk_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const long long *")] long* N_array, [NativeTypeName("const long long *")] long* K_array, [NativeTypeName("const float *")] float* alpha_array, [NativeTypeName("const float **")] float** A_array, [NativeTypeName("const long long *")] long* lda_array, [NativeTypeName("const float *")] float* beta_array, float** C_array, [NativeTypeName("const long long *")] long* ldc_array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ssyr2k_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strmm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, float* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strmm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, float* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const float *")] float* alpha_Array, [NativeTypeName("const float **")] float** A_Array, [NativeTypeName("const long long *")] long* lda_Array, float** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_strsm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const long long *")] long* K_Array, [NativeTypeName("const double *")] double* alpha_Array, [NativeTypeName("const double **")] double** A_Array, [NativeTypeName("const long long *")] long* lda_Array, [NativeTypeName("const double **")] double** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const double *")] double* beta_Array, double** C_Array, [NativeTypeName("const long long *")] long* ldc_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemmt_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsymm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyrk_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyrk_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const long long *")] long* N_array, [NativeTypeName("const long long *")] long* K_array, [NativeTypeName("const double *")] double* alpha_array, [NativeTypeName("const double **")] double** A_array, [NativeTypeName("const long long *")] long* lda_array, [NativeTypeName("const double *")] double* beta_array, double** C_array, [NativeTypeName("const long long *")] long* ldc_array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyrk_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dsyr2k_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrmm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, double* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrmm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, double* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Transa_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const double *")] double* alpha_Array, [NativeTypeName("const double **")] double** A_Array, [NativeTypeName("const long long *")] long* lda_Array, double** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dtrsm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm3m_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const long long *")] long* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const long long *")] long* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const long long *")] long* ldc_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm3m_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const long long *")] long* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const long long *")] long* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const long long *")] long* ldc_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemm3m_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemmt_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csymm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyrk_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyrk_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const long long *")] long* N_array, [NativeTypeName("const long long *")] long* K_array, [NativeTypeName("const void *")] void* alpha_array, [NativeTypeName("const void **")] void** A_array, [NativeTypeName("const long long *")] long* lda_array, [NativeTypeName("const void *")] void* beta_array, void** C_array, [NativeTypeName("const long long *")] long* ldc_array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyrk_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_csyr2k_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrmm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrmm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Transa_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const long long *")] long* lda_Array, void** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ctrsm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm3m_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const long long *")] long* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const long long *")] long* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const long long *")] long* ldc_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm3m_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransB_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const long long *")] long* K_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const long long *")] long* lda_Array, [NativeTypeName("const void **")] void** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const void *")] void* beta_Array, void** C_Array, [NativeTypeName("const long long *")] long* ldc_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemm3m_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemmt_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsymm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyrk_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyrk_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Trans_array, [NativeTypeName("const long long *")] long* N_array, [NativeTypeName("const long long *")] long* K_array, [NativeTypeName("const void *")] void* alpha_array, [NativeTypeName("const void **")] void** A_array, [NativeTypeName("const long long *")] long* lda_array, [NativeTypeName("const void *")] void* beta_array, void** C_array, [NativeTypeName("const long long *")] long* ldc_array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyrk_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zsyr2k_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrmm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrmm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, void* B, [NativeTypeName("const long long")] long ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm_oop_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* Side_Array, [NativeTypeName("const CBLAS_UPLO *")] CblasUpLo* Uplo_Array, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* Transa_Array, [NativeTypeName("const CBLAS_DIAG *")] CblasDiag* Diag_Array, [NativeTypeName("const long long *")] long* M_Array, [NativeTypeName("const long long *")] long* N_Array, [NativeTypeName("const void *")] void* alpha_Array, [NativeTypeName("const void **")] void** A_Array, [NativeTypeName("const long long *")] long* lda_Array, void** B_Array, [NativeTypeName("const long long *")] long* ldb_Array, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ztrsm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_DIAG")] CblasDiag Diag, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const long long")] long strideb, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_chemm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cherk_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float")] float beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cher2k_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zhemm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide Side, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zherk_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double")] double beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zher2k_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_UPLO")] CblasUpLo Uplo, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, void* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_sgemm_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* src, [NativeTypeName("const long long")] long ld, float* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemm_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const float *")] float* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_dgemm_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* src, [NativeTypeName("const long long")] long ld, double* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemm_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const double *")] double* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_hgemm_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const unsigned short")] ushort alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const unsigned short")] ushort beta, [NativeTypeName("unsigned short *")] ushort* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_hgemm_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_hgemm_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const unsigned short")] ushort alpha, [NativeTypeName("const unsigned short *")] ushort* src, [NativeTypeName("const long long")] long ld, [NativeTypeName("unsigned short *")] ushort* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_hgemm_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const unsigned short")] ushort beta, [NativeTypeName("unsigned short *")] ushort* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s16s16s32_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset OffsetC, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const short *")] short* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const short")] short ao, [NativeTypeName("const short *")] short* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const short")] short bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const int *")] int* cb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s8u8s32_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset OffsetC, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const char")] sbyte ao, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const char")] sbyte bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const int *")] int* cb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_bf16bf16f32_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_f16f16f32_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e5m2e5m2f32_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e4m3e4m3f32_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_s8u8s32_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_s16s16s32_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_bf16bf16f32_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_f16f16f32_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_e5m2e5m2f32_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint cblas_gemm_e4m3e4m3f32_pack_get_size_64([NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s8u8s32_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const void *")] void* src, [NativeTypeName("const long long")] long ld, void* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s16s16s32_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const short *")] short* src, [NativeTypeName("const long long")] long ld, short* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_bf16bf16f32_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const unsigned short *")] ushort* src, [NativeTypeName("const long long")] long ld, [NativeTypeName("unsigned short *")] ushort* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_f16f16f32_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const unsigned short *")] ushort* src, [NativeTypeName("const long long")] long ld, [NativeTypeName("unsigned short *")] ushort* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e5m2e5m2f32_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const unsigned char *")] byte* src, [NativeTypeName("const long long")] long ld, [NativeTypeName("unsigned char *")] byte* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e4m3e4m3f32_pack_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_IDENTIFIER")] CblasIdentifier identifier, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose Trans, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const unsigned char *")] byte* src, [NativeTypeName("const long long")] long ld, [NativeTypeName("unsigned char *")] byte* dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s8u8s32_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset offsetc, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const char")] sbyte ao, [NativeTypeName("const void *")] void* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const char")] sbyte bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const int *")] int* co);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_s16s16s32_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const CBLAS_OFFSET")] CblasOffset offsetc, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const short *")] short* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const short")] short ao, [NativeTypeName("const short *")] short* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const short")] short bo, [NativeTypeName("const float")] float beta, int* C, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const int *")] int* co);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_bf16bf16f32_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_f16f16f32_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned short *")] ushort* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned short *")] ushort* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e5m2e5m2f32_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_gemm_e4m3e4m3f32_compute_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const long long")] long TransA, [NativeTypeName("const long long")] long TransB, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const long long")] long K, [NativeTypeName("const float")] float alpha, [NativeTypeName("const unsigned char *")] byte* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const unsigned char *")] byte* B, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_dgemm_64(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const long long")] long k, [NativeTypeName("const double")] double alpha, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double beta, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_sgemm_64(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const long long")] long k, [NativeTypeName("const float")] float alpha, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float beta, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_cgemm_64(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const long long")] long k, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern mkl_jit_status_t mkl_cblas_jit_create_zgemm_64(void** jitter, [NativeTypeName("const MKL_LAYOUT")] MKL_LAYOUT layout, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transa, [NativeTypeName("const MKL_TRANSPOSE")] MKL_TRANSPOSE transb, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const long long")] long k, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const void *")] void* beta, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const float **")] float** x, [NativeTypeName("const long long *")] long* incx, float** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const double **")] double** x, [NativeTypeName("const long long *")] long* incx, double** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** x, [NativeTypeName("const long long *")] long* incx, void** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** x, [NativeTypeName("const long long *")] long* incx, void** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_saxpy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, float* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_daxpy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, double* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_caxpy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zaxpy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_scopy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const float **")] float** x, [NativeTypeName("const long long *")] long* incx, float** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dcopy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const double **")] double** x, [NativeTypeName("const long long *")] long* incx, double** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ccopy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const void **")] void** x, [NativeTypeName("const long long *")] long* incx, void** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zcopy_batch_64([NativeTypeName("const long long *")] long* n, [NativeTypeName("const void **")] void** x, [NativeTypeName("const long long *")] long* incx, void** y, [NativeTypeName("const long long *")] long* incy, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_scopy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, float* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dcopy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, double* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ccopy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zcopy_batch_strided_64([NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemv_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const long long *")] long* M, [NativeTypeName("const long long *")] long* N, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const float **")] float** A, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const float **")] float** X, [NativeTypeName("const long long *")] long* incX, [NativeTypeName("const float *")] float* beta, float** Y, [NativeTypeName("const long long *")] long* incY, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sgemv_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const float *")] float* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, [NativeTypeName("const float")] float beta, float* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemv_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const long long *")] long* M, [NativeTypeName("const long long *")] long* N, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const double **")] double** A, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const double **")] double** X, [NativeTypeName("const long long *")] long* incX, [NativeTypeName("const double *")] double* beta, double** Y, [NativeTypeName("const long long *")] long* incY, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_dgemv_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const double *")] double* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, [NativeTypeName("const double")] double beta, double* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemv_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const long long *")] long* M, [NativeTypeName("const long long *")] long* N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** A, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const void **")] void** X, [NativeTypeName("const long long *")] long* incX, [NativeTypeName("const void *")] void* beta, void** Y, [NativeTypeName("const long long *")] long* incY, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cgemv_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemv_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE *")] CblasTranspose* TransA, [NativeTypeName("const long long *")] long* M, [NativeTypeName("const long long *")] long* N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void **")] void** A, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const void **")] void** X, [NativeTypeName("const long long *")] long* incX, [NativeTypeName("const void *")] void* beta, void** Y, [NativeTypeName("const long long *")] long* incY, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zgemv_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout Layout, [NativeTypeName("const CBLAS_TRANSPOSE")] CblasTranspose TransA, [NativeTypeName("const long long")] long M, [NativeTypeName("const long long")] long N, [NativeTypeName("const void *")] void* alpha, [NativeTypeName("const void *")] void* A, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* X, [NativeTypeName("const long long")] long incX, [NativeTypeName("const long long")] long stridex, [NativeTypeName("const void *")] void* beta, void* Y, [NativeTypeName("const long long")] long incY, [NativeTypeName("const long long")] long stridey, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sdgmm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const long long *")] long* m, [NativeTypeName("const long long *")] long* n, [NativeTypeName("const float **")] float** a, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const float **")] float** x, [NativeTypeName("const long long *")] long* incx, float** c, [NativeTypeName("const long long *")] long* ldc, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_sdgmm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const float *")] float* a, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const float *")] float* x, [NativeTypeName("const long long")] long incx, [NativeTypeName("const long long")] long stridex, float* c, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ddgmm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const long long *")] long* m, [NativeTypeName("const long long *")] long* n, [NativeTypeName("const double **")] double** a, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const double **")] double** x, [NativeTypeName("const long long *")] long* incx, double** c, [NativeTypeName("const long long *")] long* ldc, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_ddgmm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const double *")] double* x, [NativeTypeName("const long long")] long incx, [NativeTypeName("const long long")] long stridex, double* c, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdgmm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const long long *")] long* m, [NativeTypeName("const long long *")] long* n, [NativeTypeName("const void **")] void** a, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const void **")] void** x, [NativeTypeName("const long long *")] long* incx, void** c, [NativeTypeName("const long long *")] long* ldc, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_cdgmm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* x, [NativeTypeName("const long long")] long incx, [NativeTypeName("const long long")] long stridex, void* c, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdgmm_batch_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE *")] CblasSide* side, [NativeTypeName("const long long *")] long* m, [NativeTypeName("const long long *")] long* n, [NativeTypeName("const void **")] void** a, [NativeTypeName("const long long *")] long* lda, [NativeTypeName("const void **")] void** x, [NativeTypeName("const long long *")] long* incx, void** c, [NativeTypeName("const long long *")] long* ldc, [NativeTypeName("const long long")] long group_count, [NativeTypeName("const long long *")] long* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cblas_zdgmm_batch_strided_64([NativeTypeName("const CBLAS_LAYOUT")] CblasLayout layout, [NativeTypeName("const CBLAS_SIDE")] CblasSide side, [NativeTypeName("const long long")] long m, [NativeTypeName("const long long")] long n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const long long")] long lda, [NativeTypeName("const long long")] long stridea, [NativeTypeName("const void *")] void* x, [NativeTypeName("const long long")] long incx, [NativeTypeName("const long long")] long stridex, void* c, [NativeTypeName("const long long")] long ldc, [NativeTypeName("const long long")] long stridec, [NativeTypeName("const long long")] long batch_size);
    }
}
