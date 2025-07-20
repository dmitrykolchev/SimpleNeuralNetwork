using System;
using System.Runtime.InteropServices;

namespace Managed.Mkl.Native
{
    public unsafe partial struct MKLVersion
    {
        public int MajorVersion;

        public int MinorVersion;

        public int UpdateVersion;

        public int PatchVersion;

        [NativeTypeName("char *")]
        public sbyte* ProductStatus;

        [NativeTypeName("char *")]
        public sbyte* Build;

        [NativeTypeName("char *")]
        public sbyte* Processor;

        [NativeTypeName("char *")]
        public sbyte* Platform;
    }

    public enum MKL_LAYOUT
    {
        MKL_ROW_MAJOR = 101,
        MKL_COL_MAJOR = 102,
    }

    public enum MKL_TRANSPOSE
    {
        MKL_NOTRANS = 111,
        MKL_TRANS = 112,
        MKL_CONJTRANS = 113,
        MKL_CONJ = 114,
    }

    public enum MKL_UPLO
    {
        MKL_UPPER = 121,
        MKL_LOWER = 122,
    }

    public enum MKL_DIAG
    {
        MKL_NONUNIT = 131,
        MKL_UNIT = 132,
    }

    public enum MKL_SIDE
    {
        MKL_LEFT = 141,
        MKL_RIGHT = 142,
    }

    public enum MKL_COMPACT_PACK
    {
        MKL_COMPACT_SSE = 181,
        MKL_COMPACT_AVX = 182,
        MKL_COMPACT_AVX512 = 183,
    }

    public enum mkl_jit_status_t
    {
        MKL_JIT_SUCCESS = 0,
        MKL_NO_JIT = 1,
        MKL_JIT_ERROR = 2,
    }

    public enum sparse_status_t
    {
        SPARSE_STATUS_SUCCESS = 0,
        SPARSE_STATUS_NOT_INITIALIZED = 1,
        SPARSE_STATUS_ALLOC_FAILED = 2,
        SPARSE_STATUS_INVALID_VALUE = 3,
        SPARSE_STATUS_EXECUTION_FAILED = 4,
        SPARSE_STATUS_INTERNAL_ERROR = 5,
        SPARSE_STATUS_NOT_SUPPORTED = 6,
    }

    public enum sparse_operation_t
    {
        SPARSE_OPERATION_NON_TRANSPOSE = 10,
        SPARSE_OPERATION_TRANSPOSE = 11,
        SPARSE_OPERATION_CONJUGATE_TRANSPOSE = 12,
    }

    public enum sparse_matrix_type_t
    {
        SPARSE_MATRIX_TYPE_GENERAL = 20,
        SPARSE_MATRIX_TYPE_SYMMETRIC = 21,
        SPARSE_MATRIX_TYPE_HERMITIAN = 22,
        SPARSE_MATRIX_TYPE_TRIANGULAR = 23,
        SPARSE_MATRIX_TYPE_DIAGONAL = 24,
        SPARSE_MATRIX_TYPE_BLOCK_TRIANGULAR = 25,
        SPARSE_MATRIX_TYPE_BLOCK_DIAGONAL = 26,
    }

    public enum sparse_index_base_t
    {
        SPARSE_INDEX_BASE_ZERO = 0,
        SPARSE_INDEX_BASE_ONE = 1,
    }

    public enum sparse_fill_mode_t
    {
        SPARSE_FILL_MODE_LOWER = 40,
        SPARSE_FILL_MODE_UPPER = 41,
        SPARSE_FILL_MODE_FULL = 42,
    }

    public enum sparse_diag_type_t
    {
        SPARSE_DIAG_NON_UNIT = 50,
        SPARSE_DIAG_UNIT = 51,
    }

    public enum sparse_layout_t
    {
        SPARSE_LAYOUT_ROW_MAJOR = 101,
        SPARSE_LAYOUT_COLUMN_MAJOR = 102,
    }

    public enum verbose_mode_t
    {
        SPARSE_VERBOSE_OFF = 70,
        SPARSE_VERBOSE_BASIC = 71,
        SPARSE_VERBOSE_EXTENDED = 72,
    }

    public enum sparse_memory_usage_t
    {
        SPARSE_MEMORY_NONE = 80,
        SPARSE_MEMORY_AGGRESSIVE = 81,
    }

    public enum sparse_request_t
    {
        SPARSE_STAGE_FULL_MULT = 90,
        SPARSE_STAGE_NNZ_COUNT = 91,
        SPARSE_STAGE_FINALIZE_MULT = 92,
        SPARSE_STAGE_FULL_MULT_NO_VAL = 93,
        SPARSE_STAGE_FINALIZE_MULT_NO_VAL = 94,
    }

    public enum sparse_sor_type_t
    {
        SPARSE_SOR_FORWARD = 110,
        SPARSE_SOR_BACKWARD = 111,
        SPARSE_SOR_SYMMETRIC = 112,
    }

    public partial struct sparse_matrix
    {
    }

    public partial struct matrix_descr
    {
        public sparse_matrix_type_t type;

        public sparse_fill_mode_t mode;

        public sparse_diag_type_t diag;
    }

    public partial struct _DOUBLE_COMPLEX_t
    {
        public double r;

        public double i;
    }

    public enum sparse_matrix_indexing
    {
        MKL_ZERO_BASED,
        MKL_ONE_BASED,
    }

    public enum sparse_matrix_print_styles
    {
        MKL_C_STYLE,
        MKL_FORTRAN_STYLE,
    }

    public enum sparse_matrix_formats
    {
        MKL_CSR,
    }

    public enum sparse_matrix_structures
    {
        MKL_GENERAL_STRUCTURE,
        MKL_UPPER_TRIANGULAR,
        MKL_LOWER_TRIANGULAR,
        MKL_STRUCTURAL_SYMMETRIC,
    }

    public enum sparse_matrix_message_levels
    {
        MKL_NO_PRINT,
        MKL_PRINT,
    }

    public enum sparse_checker_error_values
    {
        MKL_SPARSE_CHECKER_SUCCESS = 0,
        MKL_SPARSE_CHECKER_NON_MONOTONIC = 21,
        MKL_SPARSE_CHECKER_OUT_OF_RANGE = 22,
        MKL_SPARSE_CHECKER_NONTRIANGULAR = 23,
        MKL_SPARSE_CHECKER_NONORDERED = 24,
    }

    public unsafe partial struct _sparse_struct
    {
        public int n;

        public int* csr_ia;

        public int* csr_ja;

        [NativeTypeName("int[3]")]
        public fixed int check_result[3];

        public sparse_matrix_indexing indexing;

        public sparse_matrix_structures matrix_structure;

        public sparse_matrix_formats matrix_format;

        public sparse_matrix_message_levels message_level;

        public sparse_matrix_print_styles print_style;
    }

    public enum DFTI_CONFIG_PARAM
    {
        DFTI_FORWARD_DOMAIN = 0,
        DFTI_DIMENSION = 1,
        DFTI_LENGTHS = 2,
        DFTI_PRECISION = 3,
        DFTI_FORWARD_SCALE = 4,
        DFTI_BACKWARD_SCALE = 5,
        DFTI_NUMBER_OF_TRANSFORMS = 7,
        DFTI_COMPLEX_STORAGE = 8,
        DFTI_REAL_STORAGE = 9,
        DFTI_CONJUGATE_EVEN_STORAGE = 10,
        DFTI_PLACEMENT = 11,
        DFTI_INPUT_STRIDES = 12,
        DFTI_OUTPUT_STRIDES = 13,
        DFTI_INPUT_DISTANCE = 14,
        DFTI_OUTPUT_DISTANCE = 15,
        DFTI_WORKSPACE = 17,
        DFTI_ORDERING = 18,
        DFTI_TRANSPOSE = 19,
        DFTI_DESCRIPTOR_NAME = 20,
        DFTI_PACKED_FORMAT = 21,
        DFTI_COMMIT_STATUS = 22,
        DFTI_VERSION = 23,
        DFTI_NUMBER_OF_USER_THREADS = 26,
        DFTI_THREAD_LIMIT = 27,
        DFTI_DESTROY_INPUT = 28,
        DFTI_FWD_DISTANCE = 58,
        DFTI_BWD_DISTANCE = 59,
    }

    public enum DFTI_CONFIG_VALUE
    {
        DFTI_COMMITTED = 30,
        DFTI_UNCOMMITTED = 31,
        DFTI_COMPLEX = 32,
        DFTI_REAL = 33,
        DFTI_SINGLE = 35,
        DFTI_DOUBLE = 36,
        DFTI_COMPLEX_COMPLEX = 39,
        DFTI_COMPLEX_REAL = 40,
        DFTI_REAL_COMPLEX = 41,
        DFTI_REAL_REAL = 42,
        DFTI_INPLACE = 43,
        DFTI_NOT_INPLACE = 44,
        DFTI_ORDERED = 48,
        DFTI_BACKWARD_SCRAMBLED = 49,
        DFTI_ALLOW = 51,
        DFTI_AVOID = 52,
        DFTI_NONE = 53,
        DFTI_CCS_FORMAT = 54,
        DFTI_PACK_FORMAT = 55,
        DFTI_PERM_FORMAT = 56,
        DFTI_CCE_FORMAT = 57,
    }

    public partial struct DFTI_DESCRIPTOR
    {
    }

    public enum sparse_qr_hint_t
    {
        SPARSE_QR_WITH_PIVOTS,
    }

    public static unsafe partial class MklNative
    {
        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Simatcopy([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const float")] float alpha, float* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Dimatcopy([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const double")] double alpha, double* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Cimatcopy([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("MKL_Complex8 *")] ComplexF* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zimatcopy([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("MKL_Complex16 *")] Complex* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Somatcopy([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("size_t")] nuint lda, float* B, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Domatcopy([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("size_t")] nuint lda, double* B, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Comatcopy([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("MKL_Complex8 *")] ComplexF* B, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zomatcopy([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("MKL_Complex16 *")] Complex* B, [NativeTypeName("size_t")] nuint ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Somatcopy2([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, float* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Domatcopy2([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, double* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Comatcopy2([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("MKL_Complex8 *")] ComplexF* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zomatcopy2([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("MKL_Complex16 *")] Complex* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Somatadd([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("const float")] float beta, [NativeTypeName("const float *")] float* B, [NativeTypeName("size_t")] nuint ldb, float* C, [NativeTypeName("size_t")] nuint ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Domatadd([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("const double")] double beta, [NativeTypeName("const double *")] double* B, [NativeTypeName("size_t")] nuint ldb, double* C, [NativeTypeName("size_t")] nuint ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Comatadd([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("const MKL_Complex8 *")] ComplexF* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("size_t")] nuint ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zomatadd([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("const MKL_Complex16 *")] Complex* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("size_t")] nuint ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Simatcopy_batch_strided([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const float")] float alpha, float* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint stride, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Dimatcopy_batch_strided([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const double")] double alpha, double* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint stride, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Cimatcopy_batch_strided([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("MKL_Complex8 *")] ComplexF* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint stride, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zimatcopy_batch_strided([NativeTypeName("const char")] sbyte ordering, [NativeTypeName("const char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("MKL_Complex16 *")] Complex* AB, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint stride, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Somatcopy_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, float* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Domatcopy_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, double* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Comatcopy_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("MKL_Complex8 *")] ComplexF* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zomatcopy_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte trans, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("MKL_Complex16 *")] Complex* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Simatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const float *")] float* alpha_array, float** AB_array, [NativeTypeName("const size_t *")] nuint* lda_array, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Dimatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const double *")] double* alpha_array, double** AB_array, [NativeTypeName("const size_t *")] nuint* lda_array, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Cimatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha_array, [NativeTypeName("MKL_Complex8 **")] ComplexF** AB_array, [NativeTypeName("const size_t *")] nuint* lda_array, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zimatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha_array, [NativeTypeName("MKL_Complex16 **")] Complex** AB_array, [NativeTypeName("const size_t *")] nuint* lda_array, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Somatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const float *")] float* alpha_array, [NativeTypeName("const float **")] float** A_array, [NativeTypeName("const size_t *")] nuint* lda_array, float** B, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Domatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const double *")] double* alpha_array, [NativeTypeName("const double **")] double** A_array, [NativeTypeName("const size_t *")] nuint* lda_array, double** B_array, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Comatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha_array, [NativeTypeName("const MKL_Complex8 **")] ComplexF** A_array, [NativeTypeName("const size_t *")] nuint* lda_array, [NativeTypeName("MKL_Complex8 **")] ComplexF** B, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zomatcopy_batch([NativeTypeName("char")] sbyte ordering, [NativeTypeName("const char *")] sbyte* trans_array, [NativeTypeName("const size_t *")] nuint* rows_array, [NativeTypeName("const size_t *")] nuint* cols_array, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha_array, [NativeTypeName("const MKL_Complex16 **")] Complex** A_array, [NativeTypeName("const size_t *")] nuint* lda_array, [NativeTypeName("MKL_Complex16 **")] Complex** B, [NativeTypeName("const size_t *")] nuint* ldb_array, [NativeTypeName("size_t")] nuint group_count, [NativeTypeName("const size_t *")] nuint* group_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Somatadd_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("const float")] float beta, [NativeTypeName("const float *")] float* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, float* C, [NativeTypeName("size_t")] nuint ldc, [NativeTypeName("size_t")] nuint stridec, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Domatadd_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("const double")] double beta, [NativeTypeName("const double *")] double* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, double* C, [NativeTypeName("size_t")] nuint ldc, [NativeTypeName("size_t")] nuint stridec, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Comatadd_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("const MKL_Complex8 *")] ComplexF* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("size_t")] nuint ldc, [NativeTypeName("size_t")] nuint stridec, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Zomatadd_batch_strided([NativeTypeName("char")] sbyte ordering, [NativeTypeName("char")] sbyte transa, [NativeTypeName("char")] sbyte transb, [NativeTypeName("size_t")] nuint rows, [NativeTypeName("size_t")] nuint cols, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* A, [NativeTypeName("size_t")] nuint lda, [NativeTypeName("size_t")] nuint stridea, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("const MKL_Complex16 *")] Complex* B, [NativeTypeName("size_t")] nuint ldb, [NativeTypeName("size_t")] nuint strideb, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("size_t")] nuint ldc, [NativeTypeName("size_t")] nuint stridec, [NativeTypeName("size_t")] nuint batch_size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_scsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_scsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_scsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scscmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scscsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scoomv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scoosv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_scoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_scoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_scootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdiamv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdiasv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdiagemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdiasymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdiatrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sskymv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sskysv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sbsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sbsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_sbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_sbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_sbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scscmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scscsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scoomm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scoosm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdiamm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdiasm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sskysm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sskymm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sbsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sbsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSCMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSCSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCOOMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCOOSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDIAMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDIASV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDIAGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDIASYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDIATRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SSKYMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SSKYSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SBSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float *")] float* beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SBSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_SBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSCMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSCSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCOOMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCOOSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDIAMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDIASM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SSKYSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SSKYMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SBSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const float *")] float* beta, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SBSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const float *")] float* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const float *")] float* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, float* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dcsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dcsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dcsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcscmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcscsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcoomv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcoosv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dcoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dcoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dcootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddiamv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddiasv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddiagemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddiasymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddiatrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dskymv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dskysv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dbsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dbsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_dbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcscmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcscsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcoomm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcoosm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddiamm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddiasm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dskysm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dskymm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dbsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dbsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSCMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSCSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCOOMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCOOSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDIAMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDIASV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDIAGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDIASYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDIATRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DSKYMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DSKYSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DBSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DBSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_DBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSCMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSCSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCOOMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCOOSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDIAMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDIASM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DSKYSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DSKYMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DBSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const double *")] double* beta, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DBSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const double *")] double* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const double *")] double* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, double* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_ccsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_ccsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_ccsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccscmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccscsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccoomv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccoosv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_ccoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_ccoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_ccootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdiamv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdiasv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdiagemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdiasymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdiatrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cskymv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cskysv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cbsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cbsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_cbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_cbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_cbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccscmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccscsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccoomm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccoosm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdiamm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdiasm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cskysm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cskymm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cbsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cbsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSCMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSCSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCOOMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCOOSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDIAMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDIASV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDIAGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDIASYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDIATRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSKYMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSKYSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CBSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CBSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_CBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSCMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSCSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCOOMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCOOSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDIAMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDIASM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSKYSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSKYMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CBSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CBSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex8 *")] ComplexF* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zcsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zcsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zcsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcscmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcscsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcoomv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcoosv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zcoogemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zcoosymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zcootrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdiamv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdiasv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdiagemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdiasymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdiatrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zskymv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zskysv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zbsrmv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zbsrsv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zbsrgemv([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zbsrsymv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cspblas_zbsrtrsv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcscmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcscsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcoomm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcoosm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdiamm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdiasm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zskysm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zskymm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zbsrmm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zbsrsm([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZCSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZCSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZCSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSCMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSCSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCOOMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCOOSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZCOOGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZCOOSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZCOOTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDIAMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDIASV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDIAGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDIASYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDIATRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZSKYMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZSKYSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZBSRMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZBSRSV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZBSRGEMV([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZBSRSYMV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CSPBLAS_ZBSRTRSV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const char *")] sbyte* diag, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSCMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSCSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCOOMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCOOSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* rowind, [NativeTypeName("const int *")] int* colind, [NativeTypeName("const int *")] int* nnz, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDIAMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDIASM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* lval, [NativeTypeName("const int *")] int* idiag, [NativeTypeName("const int *")] int* ndiag, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZSKYSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZSKYMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* pntr, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZBSRMM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZBSRSM([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* lb, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const char *")] sbyte* matdescra, [NativeTypeName("const MKL_Complex16 *")] Complex* val, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* pntrb, [NativeTypeName("const int *")] int* pntre, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, [NativeTypeName("MKL_Complex16 *")] Complex* c, [NativeTypeName("const int *")] int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrbsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, double* Acsr, int* AJ, int* AI, double* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrcoo([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJR, int* AIR, int* nnz, double* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ddnscsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, double* Adns, [NativeTypeName("const int *")] int* lda, double* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrcsc([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJ0, int* AI0, double* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrdia([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJ0, int* AI0, double* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, double* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrsky([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJ0, int* AI0, double* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrbsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, float* Acsr, int* AJ, int* AI, float* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrcoo([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJR, int* AIR, int* nnz, float* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_sdnscsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, float* Adns, [NativeTypeName("const int *")] int* lda, float* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrcsc([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJ0, int* AI0, float* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrdia([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJ0, int* AI0, float* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, float* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrsky([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJ0, int* AI0, float* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrbsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ, int* AI, [NativeTypeName("MKL_Complex8 *")] ComplexF* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrcoo([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJR, int* AIR, int* nnz, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_cdnscsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Adns, [NativeTypeName("const int *")] int* lda, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrcsc([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrdia([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex8 *")] ComplexF* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrsky([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex8 *")] ComplexF* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrbsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ, int* AI, [NativeTypeName("MKL_Complex16 *")] Complex* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrcoo([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJR, int* AIR, int* nnz, [NativeTypeName("MKL_Complex16 *")] Complex* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zdnscsr([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Adns, [NativeTypeName("const int *")] int* lda, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrcsc([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex16 *")] Complex* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrdia([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex16 *")] Complex* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrsky([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex16 *")] Complex* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRBSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, double* Acsr, int* AJ, int* AI, double* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRCOO([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJR, int* AIR, int* nnz, double* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DDNSCSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, double* Adns, [NativeTypeName("const int *")] int* lda, double* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRCSC([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJ0, int* AI0, double* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRDIA([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJ0, int* AI0, double* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, double* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRSKY([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, double* Acsr, int* AJ0, int* AI0, double* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRBSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, float* Acsr, int* AJ, int* AI, float* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRCOO([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJR, int* AIR, int* nnz, float* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SDNSCSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, float* Adns, [NativeTypeName("const int *")] int* lda, float* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRCSC([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJ0, int* AI0, float* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRDIA([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJ0, int* AI0, float* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, float* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRSKY([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, float* Acsr, int* AJ0, int* AI0, float* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRBSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ, int* AI, [NativeTypeName("MKL_Complex8 *")] ComplexF* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRCOO([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJR, int* AIR, int* nnz, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CDNSCSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Adns, [NativeTypeName("const int *")] int* lda, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRCSC([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRDIA([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex8 *")] ComplexF* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRSKY([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex8 *")] ComplexF* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRBSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* mblk, [NativeTypeName("const int *")] int* ldAbsr, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ, int* AI, [NativeTypeName("MKL_Complex16 *")] Complex* Absr, int* AJB, int* AIB, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRCOO([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJR, int* AIR, int* nnz, [NativeTypeName("MKL_Complex16 *")] Complex* Acoo, int* ir, int* jc, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZDNSCSR([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Adns, [NativeTypeName("const int *")] int* lda, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ, int* AI, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRCSC([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex16 *")] Complex* Acsc, int* AJ1, int* AI1, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRDIA([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex16 *")] Complex* Adia, [NativeTypeName("const int *")] int* ndiag, int* distance, int* idiag, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr_rem, int* AJ0_rem, int* AI0_rem, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRSKY([NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* Acsr, int* AJ0, int* AI0, [NativeTypeName("MKL_Complex16 *")] Complex* Asky, int* pointers, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrmultcsr([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, double* a, int* ja, int* ia, double* b, int* jb, int* ib, double* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsrmultd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, double* a, int* ja, int* ia, double* b, int* jb, int* ib, double* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_dcsradd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, double* a, int* ja, int* ia, [NativeTypeName("const double *")] double* beta, double* b, int* jb, int* ib, double* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrmultcsr([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, float* a, int* ja, int* ia, float* b, int* jb, int* ib, float* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsrmultd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, float* a, int* ja, int* ia, float* b, int* jb, int* ib, float* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_scsradd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, float* a, int* ja, int* ia, [NativeTypeName("const float *")] float* beta, float* b, int* jb, int* ib, float* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrmultcsr([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex8 *")] ComplexF* a, int* ja, int* ia, [NativeTypeName("MKL_Complex8 *")] ComplexF* b, int* jb, int* ib, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsrmultd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex8 *")] ComplexF* a, int* ja, int* ia, [NativeTypeName("MKL_Complex8 *")] ComplexF* b, int* jb, int* ib, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_ccsradd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* a, int* ja, int* ia, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* b, int* jb, int* ib, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrmultcsr([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex16 *")] Complex* a, int* ja, int* ia, [NativeTypeName("MKL_Complex16 *")] Complex* b, int* jb, int* ib, [NativeTypeName("MKL_Complex16 *")] Complex* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsrmultd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex16 *")] Complex* a, int* ja, int* ia, [NativeTypeName("MKL_Complex16 *")] Complex* b, int* jb, int* ib, [NativeTypeName("MKL_Complex16 *")] Complex* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void mkl_zcsradd([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* a, int* ja, int* ia, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* b, int* jb, int* ib, [NativeTypeName("MKL_Complex16 *")] Complex* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRMULTCSR([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, double* a, int* ja, int* ia, double* b, int* jb, int* ib, double* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRMULTD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, double* a, int* ja, int* ia, double* b, int* jb, int* ib, double* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_DCSRADD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, double* a, int* ja, int* ia, [NativeTypeName("const double *")] double* beta, double* b, int* jb, int* ib, double* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRMULTCSR([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, float* a, int* ja, int* ia, float* b, int* jb, int* ib, float* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRMULTD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, float* a, int* ja, int* ia, float* b, int* jb, int* ib, float* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_SCSRADD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, float* a, int* ja, int* ia, [NativeTypeName("const float *")] float* beta, float* b, int* jb, int* ib, float* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRMULTCSR([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex8 *")] ComplexF* a, int* ja, int* ia, [NativeTypeName("MKL_Complex8 *")] ComplexF* b, int* jb, int* ib, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRMULTD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex8 *")] ComplexF* a, int* ja, int* ia, [NativeTypeName("MKL_Complex8 *")] ComplexF* b, int* jb, int* ib, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_CCSRADD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* a, int* ja, int* ia, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* b, int* jb, int* ib, [NativeTypeName("MKL_Complex8 *")] ComplexF* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRMULTCSR([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex16 *")] Complex* a, int* ja, int* ia, [NativeTypeName("MKL_Complex16 *")] Complex* b, int* jb, int* ib, [NativeTypeName("MKL_Complex16 *")] Complex* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRMULTD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* k, [NativeTypeName("MKL_Complex16 *")] Complex* a, int* ja, int* ia, [NativeTypeName("MKL_Complex16 *")] Complex* b, int* jb, int* ib, [NativeTypeName("MKL_Complex16 *")] Complex* c, int* ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void MKL_ZCSRADD([NativeTypeName("const char *")] sbyte* transa, [NativeTypeName("const int *")] int* job, [NativeTypeName("const int *")] int* sort, [NativeTypeName("const int *")] int* m, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* a, int* ja, int* ia, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, [NativeTypeName("MKL_Complex16 *")] Complex* b, int* jb, int* ib, [NativeTypeName("MKL_Complex16 *")] Complex* c, int* jc, int* ic, [NativeTypeName("const int *")] int* nnzmax, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_coo([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int nnz, int* row_indx, int* col_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_coo([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int nnz, int* row_indx, int* col_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_coo([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int nnz, int* row_indx, int* col_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_coo([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int nnz, int* row_indx, int* col_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_coo_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long nnz, [NativeTypeName("long long *")] long* row_indx, [NativeTypeName("long long *")] long* col_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_coo_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long nnz, [NativeTypeName("long long *")] long* row_indx, [NativeTypeName("long long *")] long* col_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_coo_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long nnz, [NativeTypeName("long long *")] long* row_indx, [NativeTypeName("long long *")] long* col_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_coo_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long nnz, [NativeTypeName("long long *")] long* row_indx, [NativeTypeName("long long *")] long* col_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_csr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* rows_start, int* rows_end, int* col_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_csr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* rows_start, int* rows_end, int* col_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_csr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* rows_start, int* rows_end, int* col_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_csr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* rows_start, int* rows_end, int* col_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_csr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_csr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_csr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_csr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_csc([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* cols_start, int* cols_end, int* row_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_csc([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* cols_start, int* cols_end, int* row_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_csc([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* cols_start, int* cols_end, int* row_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_csc([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, int* cols_start, int* cols_end, int* row_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_csc_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* cols_start, [NativeTypeName("long long *")] long* cols_end, [NativeTypeName("long long *")] long* row_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_csc_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* cols_start, [NativeTypeName("long long *")] long* cols_end, [NativeTypeName("long long *")] long* row_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_csc_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* cols_start, [NativeTypeName("long long *")] long* cols_end, [NativeTypeName("long long *")] long* row_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_csc_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("long long *")] long* cols_start, [NativeTypeName("long long *")] long* cols_end, [NativeTypeName("long long *")] long* row_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_bsr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int block_size, int* rows_start, int* rows_end, int* col_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_bsr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int block_size, int* rows_start, int* rows_end, int* col_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_bsr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int block_size, int* rows_start, int* rows_end, int* col_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_bsr([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const int")] int rows, [NativeTypeName("const int")] int cols, [NativeTypeName("const int")] int block_size, int* rows_start, int* rows_end, int* col_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_create_bsr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long block_size, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_create_bsr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long block_size, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_create_bsr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long block_size, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_create_bsr_64([NativeTypeName("sparse_matrix_t *")] sparse_matrix** A, [NativeTypeName("const sparse_index_base_t")] sparse_index_base_t indexing, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const long long")] long rows, [NativeTypeName("const long long")] long cols, [NativeTypeName("const long long")] long block_size, [NativeTypeName("long long *")] long* rows_start, [NativeTypeName("long long *")] long* rows_end, [NativeTypeName("long long *")] long* col_indx, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_copy([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_copy_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_destroy([NativeTypeName("sparse_matrix_t")] sparse_matrix* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_destroy_64([NativeTypeName("sparse_matrix_t")] sparse_matrix* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_get_error_info([NativeTypeName("sparse_matrix_t")] sparse_matrix* A, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_get_error_info_64([NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("long long *")] long* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_csr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_bsr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const int")] int block_size, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_csc([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_coo([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_csr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_bsr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const long long")] long block_size, [NativeTypeName("const sparse_layout_t")] sparse_layout_t block_layout, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_csc_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_convert_coo_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** dest);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_bsr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, int* rows, int* cols, int* block_size, int** rows_start, int** rows_end, int** col_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_bsr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, int* rows, int* cols, int* block_size, int** rows_start, int** rows_end, int** col_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_bsr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, int* rows, int* cols, int* block_size, int** rows_start, int** rows_end, int** col_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_bsr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, int* rows, int* cols, int* block_size, int** rows_start, int** rows_end, int** col_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_bsr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* block_size, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_bsr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* block_size, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_bsr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* block_size, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_bsr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, sparse_layout_t* block_layout, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* block_size, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_csr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** rows_start, int** rows_end, int** col_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_csr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** rows_start, int** rows_end, int** col_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_csr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** rows_start, int** rows_end, int** col_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_csr([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** rows_start, int** rows_end, int** col_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_csr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_csr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_csr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_csr_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** rows_start, [NativeTypeName("long long **")] long** rows_end, [NativeTypeName("long long **")] long** col_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_csc([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** cols_start, int** cols_end, int** row_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_csc([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** cols_start, int** cols_end, int** row_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_csc([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** cols_start, int** cols_end, int** row_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_csc([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int** cols_start, int** cols_end, int** row_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_csc_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** cols_start, [NativeTypeName("long long **")] long** cols_end, [NativeTypeName("long long **")] long** row_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_csc_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** cols_start, [NativeTypeName("long long **")] long** cols_end, [NativeTypeName("long long **")] long** row_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_csc_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** cols_start, [NativeTypeName("long long **")] long** cols_end, [NativeTypeName("long long **")] long** row_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_csc_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long **")] long** cols_start, [NativeTypeName("long long **")] long** cols_end, [NativeTypeName("long long **")] long** row_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_coo([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int* nnz, int** rows_indx, int** cols_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_coo([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int* nnz, int** rows_indx, int** cols_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_coo([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int* nnz, int** rows_indx, int** cols_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_coo([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, int* rows, int* cols, int* nnz, int** rows_indx, int** cols_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_export_coo_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* nnz, [NativeTypeName("long long **")] long** rows_indx, [NativeTypeName("long long **")] long** cols_indx, float** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_export_coo_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* nnz, [NativeTypeName("long long **")] long** rows_indx, [NativeTypeName("long long **")] long** cols_indx, double** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_export_coo_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* nnz, [NativeTypeName("long long **")] long** rows_indx, [NativeTypeName("long long **")] long** cols_indx, [NativeTypeName("MKL_Complex8 **")] ComplexF** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_export_coo_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* source, sparse_index_base_t* indexing, [NativeTypeName("long long *")] long* rows, [NativeTypeName("long long *")] long* cols, [NativeTypeName("long long *")] long* nnz, [NativeTypeName("long long **")] long** rows_indx, [NativeTypeName("long long **")] long** cols_indx, [NativeTypeName("MKL_Complex16 **")] Complex** values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_set_value([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int row, [NativeTypeName("const int")] int col, [NativeTypeName("const float")] float value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_set_value([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int row, [NativeTypeName("const int")] int col, [NativeTypeName("const double")] double value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_set_value([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int row, [NativeTypeName("const int")] int col, [NativeTypeName("const MKL_Complex8")] ComplexF value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_set_value([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int row, [NativeTypeName("const int")] int col, [NativeTypeName("const MKL_Complex16")] Complex value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_set_value_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long row, [NativeTypeName("const long long")] long col, [NativeTypeName("const float")] float value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_set_value_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long row, [NativeTypeName("const long long")] long col, [NativeTypeName("const double")] double value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_set_value_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long row, [NativeTypeName("const long long")] long col, [NativeTypeName("const MKL_Complex8")] ComplexF value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_set_value_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long row, [NativeTypeName("const long long")] long col, [NativeTypeName("const MKL_Complex16")] Complex value);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_update_values([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int nvalues, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* indy, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_update_values([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int nvalues, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* indy, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_update_values([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int nvalues, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* indy, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_update_values([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const int")] int nvalues, [NativeTypeName("const int *")] int* indx, [NativeTypeName("const int *")] int* indy, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_update_values_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long nvalues, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const long long *")] long* indy, float* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_update_values_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long nvalues, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const long long *")] long* indy, double* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_update_values_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long nvalues, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const long long *")] long* indy, [NativeTypeName("MKL_Complex8 *")] ComplexF* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_update_values_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const long long")] long nvalues, [NativeTypeName("const long long *")] long* indx, [NativeTypeName("const long long *")] long* indy, [NativeTypeName("MKL_Complex16 *")] Complex* values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_verbose_mode(verbose_mode_t verbose);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_verbose_mode_64(verbose_mode_t verbose);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_mv_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const int")] int expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_mv_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const long long")] long expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_dotmv_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const int")] int expectedCalls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_dotmv_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const long long")] long expectedCalls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_mm_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int dense_matrix_size, [NativeTypeName("const int")] int expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_mm_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long dense_matrix_size, [NativeTypeName("const long long")] long expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_sv_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const int")] int expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_sv_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const long long")] long expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_sm_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int dense_matrix_size, [NativeTypeName("const int")] int expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_sm_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long dense_matrix_size, [NativeTypeName("const long long")] long expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_symgs_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const int")] int expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_symgs_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const long long")] long expected_calls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_lu_smoother_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const int")] int expectedCalls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_lu_smoother_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const long long")] long expectedCalls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_sorv_hint([NativeTypeName("const sparse_sor_type_t")] sparse_sor_type_t type, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const int")] int expectedCalls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_sorv_hint_64([NativeTypeName("const sparse_sor_type_t")] sparse_sor_type_t type, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const long long")] long expectedCalls);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_memory_hint([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_memory_usage_t")] sparse_memory_usage_t policy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_memory_hint_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_memory_usage_t")] sparse_memory_usage_t policy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_optimize([NativeTypeName("sparse_matrix_t")] sparse_matrix* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_optimize_64([NativeTypeName("sparse_matrix_t")] sparse_matrix* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_order([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_order_64([NativeTypeName("const sparse_matrix_t")] sparse_matrix* A);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float")] float beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double")] double beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float")] float beta, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double")] double beta, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_dotmv([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float")] float beta, float* y, float* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_dotmv([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double")] double beta, double* y, double* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_dotmv([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y, [NativeTypeName("MKL_Complex8 *")] ComplexF* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_dotmv([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* y, [NativeTypeName("MKL_Complex16 *")] Complex* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_dotmv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* x, [NativeTypeName("const float")] float beta, float* y, float* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_dotmv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double")] double beta, double* y, double* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_dotmv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y, [NativeTypeName("MKL_Complex8 *")] ComplexF* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_dotmv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* y, [NativeTypeName("MKL_Complex16 *")] Complex* d);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_trsv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_trsv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_trsv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_trsv([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_trsv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_trsv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_trsv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_trsv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_symgs([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* b, float* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_symgs([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* b, double* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_symgs([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("MKL_Complex8 *")] ComplexF* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_symgs([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("MKL_Complex16 *")] Complex* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_symgs_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* b, float* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_symgs_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* b, double* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_symgs_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("MKL_Complex8 *")] ComplexF* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_symgs_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("MKL_Complex16 *")] Complex* x);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_symgs_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* b, float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_symgs_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* b, double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_symgs_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_symgs_mv([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_symgs_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float *")] float* b, float* x, float* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_symgs_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double *")] double* b, double* x, double* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_symgs_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, [NativeTypeName("MKL_Complex8 *")] ComplexF* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_symgs_mv_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("MKL_Complex16 *")] Complex* x, [NativeTypeName("MKL_Complex16 *")] Complex* y);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_lu_smoother([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* diag, [NativeTypeName("const float *")] float* approx_diag_inverse, float* x, [NativeTypeName("const float *")] float* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_lu_smoother([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* diag, [NativeTypeName("const double *")] double* approx_diag_inverse, double* x, [NativeTypeName("const double *")] double* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_lu_smoother([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* diag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* approx_diag_inverse, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_lu_smoother([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* diag, [NativeTypeName("const MKL_Complex16 *")] Complex* approx_diag_inverse, [NativeTypeName("MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_lu_smoother_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const float *")] float* diag, [NativeTypeName("const float *")] float* approx_diag_inverse, float* x, [NativeTypeName("const float *")] float* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_lu_smoother_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const double *")] double* diag, [NativeTypeName("const double *")] double* approx_diag_inverse, double* x, [NativeTypeName("const double *")] double* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_lu_smoother_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex8 *")] ComplexF* diag, [NativeTypeName("const MKL_Complex8 *")] ComplexF* approx_diag_inverse, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const MKL_Complex8 *")] ComplexF* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_lu_smoother_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const MKL_Complex16 *")] Complex* diag, [NativeTypeName("const MKL_Complex16 *")] Complex* approx_diag_inverse, [NativeTypeName("MKL_Complex16 *")] Complex* x, [NativeTypeName("const MKL_Complex16 *")] Complex* rhs);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_mm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const float *")] float* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, [NativeTypeName("const float")] float beta, float* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_mm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, [NativeTypeName("const double")] double beta, double* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_mm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_mm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_mm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const float *")] float* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, [NativeTypeName("const float")] float beta, float* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_mm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const double *")] double* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, [NativeTypeName("const double")] double beta, double* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_mm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_mm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_trsm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const float *")] float* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, float* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_trsm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, double* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_trsm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, [NativeTypeName("MKL_Complex8 *")] ComplexF* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_trsm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const int")] int columns, [NativeTypeName("const int")] int ldx, [NativeTypeName("MKL_Complex16 *")] Complex* y, [NativeTypeName("const int")] int ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_trsm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const float *")] float* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, float* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_trsm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const double *")] double* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, double* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_trsm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex8 *")] ComplexF* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, [NativeTypeName("MKL_Complex8 *")] ComplexF* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_trsm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const struct matrix_descr")] matrix_descr descr, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const MKL_Complex16 *")] Complex* x, [NativeTypeName("const long long")] long columns, [NativeTypeName("const long long")] long ldx, [NativeTypeName("MKL_Complex16 *")] Complex* y, [NativeTypeName("const long long")] long ldy);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_add([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_add([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_add([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_add([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_add_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const float")] float alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_add_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const double")] double alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_add_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_add_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_spmm([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_spmm_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_sp2m([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_request_t")] sparse_request_t request, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_sp2m_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_request_t")] sparse_request_t request, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_syrk([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_syrk_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_sypr([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C, [NativeTypeName("const sparse_request_t")] sparse_request_t request);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_sypr_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("sparse_matrix_t *")] sparse_matrix** C, [NativeTypeName("const sparse_request_t")] sparse_request_t request);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_syprd([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const float *")] float* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const int")] int ldb, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_syprd([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const double *")] double* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const int")] int ldb, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_syprd([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex8 *")] ComplexF* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const int")] int ldb, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_syprd([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex16 *")] Complex* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const int")] int ldb, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_syprd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const float *")] float* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_syprd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const double *")] double* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_syprd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex8 *")] ComplexF* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_syprd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t op, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex16 *")] Complex* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutB, [NativeTypeName("const long long")] long ldb, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layoutC, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_spmmd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, float* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_spmmd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, double* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_spmmd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_spmmd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_spmmd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, float* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_spmmd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, double* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_spmmd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_spmmd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_sp2md([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_sp2md([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_sp2md([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_sp2md([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_sp2md_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_sp2md_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_sp2md_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_sp2md_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t transA, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const sparse_operation_t")] sparse_operation_t transB, [NativeTypeName("const struct matrix_descr")] matrix_descr descrB, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_syrkd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_syrkd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_syrkd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_syrkd([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const int")] int ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_syrkd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const float")] float alpha, [NativeTypeName("const float")] float beta, float* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_syrkd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const double")] double alpha, [NativeTypeName("const double")] double beta, double* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_c_syrkd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex8")] ComplexF alpha, [NativeTypeName("const MKL_Complex8")] ComplexF beta, [NativeTypeName("MKL_Complex8 *")] ComplexF* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_z_syrkd_64([NativeTypeName("const sparse_operation_t")] sparse_operation_t operation, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("const MKL_Complex16")] Complex alpha, [NativeTypeName("const MKL_Complex16")] Complex beta, [NativeTypeName("MKL_Complex16 *")] Complex* C, [NativeTypeName("const sparse_layout_t")] sparse_layout_t layout, [NativeTypeName("const long long")] long ldc);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_sorv([NativeTypeName("const sparse_sor_type_t")] sparse_sor_type_t type, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, float omega, float alpha, float* x, [NativeTypeName("const float *")] float* b);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_sorv([NativeTypeName("const sparse_sor_type_t")] sparse_sor_type_t type, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, double omega, double alpha, double* x, [NativeTypeName("const double *")] double* b);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_sorv_64([NativeTypeName("const sparse_sor_type_t")] sparse_sor_type_t type, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, float omega, float alpha, float* x, [NativeTypeName("const float *")] float* b);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_sorv_64([NativeTypeName("const sparse_sor_type_t")] sparse_sor_type_t type, [NativeTypeName("const struct matrix_descr")] matrix_descr descrA, [NativeTypeName("const sparse_matrix_t")] sparse_matrix* A, double omega, double alpha, double* x, [NativeTypeName("const double *")] double* b);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_create_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_define_structure_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const int *")] int* param3, [NativeTypeName("const int *")] int* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const int *")] int* param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_reorder_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_factor_real_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const void *")] void* param2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_factor_complex_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const void *")] void* param2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_solve_real_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const void *")] void* param2, [NativeTypeName("const int *")] int* param3, void* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_solve_complex_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const void *")] void* param2, [NativeTypeName("const int *")] int* param3, void* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_statistics_([NativeTypeName("_MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const _CHARACTER_STR_t *")] sbyte* param2, [NativeTypeName("_DOUBLE_PRECISION_t *")] double* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dss_delete_([NativeTypeName("const _MKL_DSS_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const int *")] int* maxfct, [NativeTypeName("const int *")] int* mnum, [NativeTypeName("const int *")] int* mtype, [NativeTypeName("const int *")] int* phase, [NativeTypeName("const int *")] int* n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, int* perm, [NativeTypeName("const int *")] int* nrhs, int* iparm, [NativeTypeName("const int *")] int* msglvl, void* b, void* x, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const int *")] int* maxfct, [NativeTypeName("const int *")] int* mnum, [NativeTypeName("const int *")] int* mtype, [NativeTypeName("const int *")] int* phase, [NativeTypeName("const int *")] int* n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, int* perm, [NativeTypeName("const int *")] int* nrhs, int* iparm, [NativeTypeName("const int *")] int* msglvl, void* b, void* x, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardisoinit([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const int *")] int* mtype, int* iparm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISOINIT([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const int *")] int* mtype, int* iparm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_handle_store([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_HANDLE_STORE([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_handle_restore([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_HANDLE_RESTORE([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_handle_delete([NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_HANDLE_DELETE([NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_64([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const long long *")] long* maxfct, [NativeTypeName("const long long *")] long* mnum, [NativeTypeName("const long long *")] long* mtype, [NativeTypeName("const long long *")] long* phase, [NativeTypeName("const long long *")] long* n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const long long *")] long* ia, [NativeTypeName("const long long *")] long* ja, [NativeTypeName("long long *")] long* perm, [NativeTypeName("const long long *")] long* nrhs, [NativeTypeName("long long *")] long* iparm, [NativeTypeName("const long long *")] long* msglvl, void* b, void* x, [NativeTypeName("long long *")] long* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_64([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const long long *")] long* maxfct, [NativeTypeName("const long long *")] long* mnum, [NativeTypeName("const long long *")] long* mtype, [NativeTypeName("const long long *")] long* phase, [NativeTypeName("const long long *")] long* n, [NativeTypeName("const void *")] void* a, [NativeTypeName("const long long *")] long* ia, [NativeTypeName("const long long *")] long* ja, [NativeTypeName("long long *")] long* perm, [NativeTypeName("const long long *")] long* nrhs, [NativeTypeName("long long *")] long* iparm, [NativeTypeName("const long long *")] long* msglvl, void* b, void* x, [NativeTypeName("long long *")] long* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_handle_store_64([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_HANDLE_STORE_64([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_handle_restore_64([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_HANDLE_RESTORE_64([NativeTypeName("_MKL_DSS_HANDLE_t")] void* pt, [NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_handle_delete_64([NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_HANDLE_DELETE_64([NativeTypeName("const char *")] sbyte* dirname, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_PARDISO_PIVOT([NativeTypeName("const double *")] double* aii, double* bii, [NativeTypeName("const double *")] double* eps);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_PARDISO_PIVOT_([NativeTypeName("const double *")] double* aii, double* bii, [NativeTypeName("const double *")] double* eps);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int mkl_pardiso_pivot([NativeTypeName("const double *")] double* aii, double* bii, [NativeTypeName("const double *")] double* eps);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int mkl_pardiso_pivot_([NativeTypeName("const double *")] double* aii, double* bii, [NativeTypeName("const double *")] double* eps);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_getdiag([NativeTypeName("const _MKL_DSS_HANDLE_t")] void* pt, void* df, void* da, [NativeTypeName("const int *")] int* mnum, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_GETDIAG([NativeTypeName("const _MKL_DSS_HANDLE_t")] void* pt, void* df, void* da, [NativeTypeName("const int *")] int* mnum, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pardiso_export(void* pt, void* values, int* ia, int* ja, [NativeTypeName("const int *")] int* step, [NativeTypeName("const int *")] int* iparm, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PARDISO_EXPORT(void* pt, void* values, int* ia, int* ja, [NativeTypeName("const int *")] int* step, [NativeTypeName("const int *")] int* iparm, int* error);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sparse_matrix_checker_init([NativeTypeName("sparse_struct *")] _sparse_struct* param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_checker_error_values sparse_matrix_checker([NativeTypeName("sparse_struct *")] _sparse_struct* param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Get_Version(MKLVersion* ver);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Get_Version_String([NativeTypeName("char *")] sbyte* buffer, int len);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Free_Buffers();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Thread_Free_Buffers();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long MKL_Mem_Stat(int* nbuffers);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long MKL_Peak_Mem_Usage(int reset);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* MKL_malloc([NativeTypeName("size_t")] nuint size, int align);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* MKL_calloc([NativeTypeName("size_t")] nuint num, [NativeTypeName("size_t")] nuint size, int align);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* MKL_realloc(void* ptr, [NativeTypeName("size_t")] nuint size);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_free(void* ptr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Disable_Fast_MM();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Get_Cpu_Clocks([NativeTypeName("unsigned long long *")] ulong* param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double MKL_Get_Cpu_Frequency();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double MKL_Get_Max_Cpu_Frequency();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double MKL_Get_Clocks_Frequency();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Set_Num_Threads_Local(int nth);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Set_Num_Threads(int nth);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Get_Max_Threads();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Set_Num_Stripes(int nstripes);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Get_Num_Stripes();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Domain_Set_Num_Threads(int nth, int MKL_DOMAIN);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Domain_Get_Max_Threads(int MKL_DOMAIN);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Set_Dynamic(int bool_MKL_DYNAMIC);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Get_Dynamic();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Enable_Instructions(int param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Set_Interface_Layer(int code);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Set_Threading_Layer(int code);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XerblaEntry")]
        public static extern delegate* unmanaged[Cdecl]<sbyte*, int*, int, void> mkl_set_xerbla([NativeTypeName("XerblaEntry")] delegate* unmanaged[Cdecl]<sbyte*, int*, int, void> xerbla);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ProgressEntry")]
        public static extern delegate* unmanaged[Cdecl]<int*, int*, sbyte*, int, int> mkl_set_progress([NativeTypeName("ProgressEntry")] delegate* unmanaged[Cdecl]<int*, int*, sbyte*, int, int> progress);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PardisopivotEntry")]
        public static extern delegate* unmanaged[Cdecl]<double*, double*, double*, int> mkl_set_pardiso_pivot([NativeTypeName("PardisopivotEntry")] delegate* unmanaged[Cdecl]<double*, double*, double*, int> pardiso_pivot);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_CBWR_Get(int param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_CBWR_Set(int param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_CBWR_Get_Auto_Branch();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Set_Env_Mode(int param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Verbose(int param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Verbose_Output_File([NativeTypeName("const char *")] sbyte* fname);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Set_Exit_Handler([NativeTypeName("MKLExitHandler")] delegate* unmanaged[Cdecl]<int, void> h);

        public const int MKL_BLACS_CUSTOM = 0;
        public const int MKL_BLACS_MSMPI = 1;
        public const int MKL_BLACS_INTELMPI = 2;
        public const int MKL_BLACS_LASTMPI = 3;

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Set_mpi(int vendor, [NativeTypeName("const char *")] sbyte* custom_library_name);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MKL_Set_Memory_Limit(int mem_type, [NativeTypeName("size_t")] nuint limit);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MKL_Finalize();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcsrilu0([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, double* alu, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcsrilut([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, double* alut, int* ialut, int* jalut, [NativeTypeName("const double *")] double* tol, [NativeTypeName("const int *")] int* maxfil, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCSRILU0([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, double* alu, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCSRILUT([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* ia, [NativeTypeName("const int *")] int* ja, double* alut, int* ialut, int* jalut, [NativeTypeName("const double *")] double* tol, [NativeTypeName("const int *")] int* maxfil, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, int* ierr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcg_init([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcg_check([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcg([NativeTypeName("const int *")] int* n, double* x, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcg_get([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* rci_request, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, [NativeTypeName("const double *")] double* tmp, int* itercount);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcgmrhs_init([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* method, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcgmrhs_check([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcgmrhs([NativeTypeName("const int *")] int* n, double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dcgmrhs_get([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* rci_request, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, [NativeTypeName("const double *")] double* tmp, int* itercount);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfgmres_init([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* RCI_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfgmres_check([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* RCI_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfgmres([NativeTypeName("const int *")] int* n, double* x, double* b, int* RCI_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfgmres_get([NativeTypeName("const int *")] int* n, double* x, double* b, int* RCI_request, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, double* tmp, int* itercount);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCG_INIT([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCG_CHECK([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCG([NativeTypeName("const int *")] int* n, double* x, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCG_GET([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* rci_request, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, [NativeTypeName("const double *")] double* tmp, int* itercount);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCGMRHS_INIT([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* method, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCGMRHS_CHECK([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCGMRHS([NativeTypeName("const int *")] int* n, double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, int* rci_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DCGMRHS_GET([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const int *")] int* nRhs, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* rci_request, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, [NativeTypeName("const double *")] double* tmp, int* itercount);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFGMRES_INIT([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* RCI_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFGMRES_CHECK([NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* x, [NativeTypeName("const double *")] double* b, int* RCI_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFGMRES([NativeTypeName("const int *")] int* n, double* x, double* b, int* RCI_request, int* ipar, double* dpar, double* tmp);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFGMRES_GET([NativeTypeName("const int *")] int* n, double* x, double* b, int* RCI_request, [NativeTypeName("const int *")] int* ipar, [NativeTypeName("const double *")] double* dpar, double* tmp, int* itercount);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlsp_init([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const int *")] int* param6, [NativeTypeName("const double *")] double* param7);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlsp_check([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const double *")] double* param5, int* param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlsp_solve([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, double* param1, double* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlsp_get([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, int* param1, int* param2, double* param3, double* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlsp_delete([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlspbc_init([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const double *")] double* param5, [NativeTypeName("const double *")] double* param6, [NativeTypeName("const int *")] int* param7, [NativeTypeName("const int *")] int* param8, [NativeTypeName("const double *")] double* param9);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlspbc_check([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const double *")] double* param5, [NativeTypeName("const double *")] double* param6, [NativeTypeName("const double *")] double* param7, int* param8);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlspbc_solve([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, double* param1, double* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlspbc_get([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, int* param1, int* param2, double* param3, double* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int dtrnlspbc_delete([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int djacobi_init([NativeTypeName("_JACOBIMATRIX_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const double *")] double* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int djacobi_solve([NativeTypeName("_JACOBIMATRIX_HANDLE_t *")] void** param0, double* param1, double* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int djacobi_delete([NativeTypeName("_JACOBIMATRIX_HANDLE_t *")] void** param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int djacobi([NativeTypeName("USRFCND")] delegate* unmanaged[Cdecl]<int*, int*, double*, double*, void> fcn, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, double* param3, double* param4, double* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int djacobix([NativeTypeName("USRFCNXD")] delegate* unmanaged[Cdecl]<int*, int*, double*, double*, void*, void> fcn, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, double* param3, double* param4, double* param5, void* param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlsp_init([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const int *")] int* param6, [NativeTypeName("const float *")] float* param7);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlsp_check([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const float *")] float* param5, int* param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlsp_solve([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, float* param1, float* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlsp_get([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0, int* param1, int* param2, float* param3, float* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlsp_delete([NativeTypeName("_TRNSP_HANDLE_t *")] void** param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlspbc_init([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const float *")] float* param5, [NativeTypeName("const float *")] float* param6, [NativeTypeName("const int *")] int* param7, [NativeTypeName("const int *")] int* param8, [NativeTypeName("const float *")] float* param9);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlspbc_check([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const float *")] float* param5, [NativeTypeName("const float *")] float* param6, [NativeTypeName("const float *")] float* param7, int* param8);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlspbc_solve([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, float* param1, float* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlspbc_get([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0, int* param1, int* param2, float* param3, float* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int strnlspbc_delete([NativeTypeName("_TRNSPBC_HANDLE_t *")] void** param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sjacobi_init([NativeTypeName("_JACOBIMATRIX_HANDLE_t *")] void** param0, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const float *")] float* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sjacobi_solve([NativeTypeName("_JACOBIMATRIX_HANDLE_t *")] void** param0, float* param1, float* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sjacobi_delete([NativeTypeName("_JACOBIMATRIX_HANDLE_t *")] void** param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sjacobi([NativeTypeName("USRFCNS")] delegate* unmanaged[Cdecl]<int*, int*, float*, float*, void> fcn, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, float* param3, float* param4, float* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sjacobix([NativeTypeName("USRFCNXS")] delegate* unmanaged[Cdecl]<int*, int*, float*, float*, void*, void> fcn, [NativeTypeName("const int *")] int* param1, [NativeTypeName("const int *")] int* param2, float* param3, float* param4, float* param5, void* param6);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiCreateDescriptor([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, [NativeTypeName("enum DFTI_CONFIG_VALUE")] DFTI_CONFIG_VALUE param1, [NativeTypeName("enum DFTI_CONFIG_VALUE")] DFTI_CONFIG_VALUE param2, [NativeTypeName("long")] int param3, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiCopyDescriptor([NativeTypeName("DFTI_DESCRIPTOR_HANDLE")] DFTI_DESCRIPTOR* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiCommitDescriptor([NativeTypeName("DFTI_DESCRIPTOR_HANDLE")] DFTI_DESCRIPTOR* param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiComputeForward([NativeTypeName("DFTI_DESCRIPTOR_HANDLE")] DFTI_DESCRIPTOR* param0, void* param1, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiComputeBackward([NativeTypeName("DFTI_DESCRIPTOR_HANDLE")] DFTI_DESCRIPTOR* param0, void* param1, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiSetValue([NativeTypeName("DFTI_DESCRIPTOR_HANDLE")] DFTI_DESCRIPTOR* param0, [NativeTypeName("enum DFTI_CONFIG_PARAM")] DFTI_CONFIG_PARAM param1, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiGetValue([NativeTypeName("DFTI_DESCRIPTOR_HANDLE")] DFTI_DESCRIPTOR* param0, [NativeTypeName("enum DFTI_CONFIG_PARAM")] DFTI_CONFIG_PARAM param1, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiFreeDescriptor([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* DftiErrorMessage([NativeTypeName("long")] int param0);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiErrorClass([NativeTypeName("long")] int param0, [NativeTypeName("long")] int param1);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiCreateDescriptor_s_1d([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, [NativeTypeName("enum DFTI_CONFIG_VALUE")] DFTI_CONFIG_VALUE domain, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiCreateDescriptor_s_md([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, [NativeTypeName("enum DFTI_CONFIG_VALUE")] DFTI_CONFIG_VALUE domain, [NativeTypeName("long")] int many, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiCreateDescriptor_d_1d([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, [NativeTypeName("enum DFTI_CONFIG_VALUE")] DFTI_CONFIG_VALUE domain, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int DftiCreateDescriptor_d_md([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, [NativeTypeName("enum DFTI_CONFIG_VALUE")] DFTI_CONFIG_VALUE domain, [NativeTypeName("long")] int many, __arglist);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_init_trig_transform(int* param0, int* param1, int* param2, double* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_commit_trig_transform(double* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, double* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_forward_trig_transform(double* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, double* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_backward_trig_transform(double* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, double* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_init_trig_transform(int* param0, int* param1, int* param2, float* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_commit_trig_transform(float* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, float* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_forward_trig_transform(float* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, float* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_backward_trig_transform(float* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, float* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_trig_transform([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, int* param1, int* param2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_init_helmholtz_2d([NativeTypeName("const double *")] double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const int *")] int* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const char *")] sbyte* param6, [NativeTypeName("const double *")] double* param7, int* param8, double* param9, int* param10);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_commit_helmholtz_2d(double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param5, int* param6, double* param7, int* param8);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_helmholtz_2d(double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param5, int* param6, [NativeTypeName("const double *")] double* param7, int* param8);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_helmholtz_2d([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, int* param1, int* param2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_init_helmholtz_3d([NativeTypeName("const double *")] double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const double *")] double* param5, [NativeTypeName("const int *")] int* param6, [NativeTypeName("const int *")] int* param7, [NativeTypeName("const int *")] int* param8, [NativeTypeName("const char *")] sbyte* param9, [NativeTypeName("const double *")] double* param10, int* param11, double* param12, int* param13);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_commit_helmholtz_3d(double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const double *")] double* param5, [NativeTypeName("const double *")] double* param6, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param7, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param8, int* param9, double* param10, int* param11);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_helmholtz_3d(double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const double *")] double* param4, [NativeTypeName("const double *")] double* param5, [NativeTypeName("const double *")] double* param6, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param7, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param8, int* param9, [NativeTypeName("const double *")] double* param10, int* param11);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_helmholtz_3d([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_init_helmholtz_2d([NativeTypeName("const float *")] float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const int *")] int* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const char *")] sbyte* param6, [NativeTypeName("const float *")] float* param7, int* param8, float* param9, int* param10);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_commit_helmholtz_2d(float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param5, int* param6, float* param7, int* param8);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_helmholtz_2d(float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param5, int* param6, [NativeTypeName("const float *")] float* param7, int* param8);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_init_helmholtz_3d([NativeTypeName("const float *")] float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const float *")] float* param5, [NativeTypeName("const int *")] int* param6, [NativeTypeName("const int *")] int* param7, [NativeTypeName("const int *")] int* param8, [NativeTypeName("const char *")] sbyte* param9, [NativeTypeName("const float *")] float* param10, int* param11, float* param12, int* param13);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_commit_helmholtz_3d(float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const float *")] float* param5, [NativeTypeName("const float *")] float* param6, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param7, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param8, int* param9, float* param10, int* param11);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_helmholtz_3d(float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const float *")] float* param4, [NativeTypeName("const float *")] float* param5, [NativeTypeName("const float *")] float* param6, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param7, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param8, int* param9, [NativeTypeName("const float *")] float* param10, int* param11);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_init_sph_p([NativeTypeName("const double *")] double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const int *")] int* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const double *")] double* param6, int* param7, double* param8, int* param9);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_commit_sph_p(double* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param2, int* param3, double* param4, int* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_sph_p(double* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param2, int* param3, double* param4, int* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_sph_p([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, int* param3);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_init_sph_np([NativeTypeName("const double *")] double* param0, [NativeTypeName("const double *")] double* param1, [NativeTypeName("const double *")] double* param2, [NativeTypeName("const double *")] double* param3, [NativeTypeName("const int *")] int* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const double *")] double* param6, int* param7, double* param8, int* param9);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_commit_sph_np(double* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, double* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void d_sph_np(double* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, double* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_sph_np([NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param0, int* param1, int* param2);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_init_sph_p([NativeTypeName("const float *")] float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const int *")] int* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const float *")] float* param6, int* param7, float* param8, int* param9);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_commit_sph_p(float* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param2, int* param3, float* param4, int* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_sph_p(float* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param2, int* param3, float* param4, int* param5);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_init_sph_np([NativeTypeName("const float *")] float* param0, [NativeTypeName("const float *")] float* param1, [NativeTypeName("const float *")] float* param2, [NativeTypeName("const float *")] float* param3, [NativeTypeName("const int *")] int* param4, [NativeTypeName("const int *")] int* param5, [NativeTypeName("const float *")] float* param6, int* param7, float* param8, int* param9);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_commit_sph_np(float* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, float* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void s_sph_np(float* param0, [NativeTypeName("DFTI_DESCRIPTOR_HANDLE *")] DFTI_DESCRIPTOR** param1, int* param2, float* param3, int* param4);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void feastinit(int* fpm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void FEASTINIT(int* fpm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfeast_scsrev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFEAST_SCSREV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sfeast_sygv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SFEAST_SYGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sfeast_scsrev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SFEAST_SCSREV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zfeast_hbgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ZFEAST_HBGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zfeast_hcsrev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ZFEAST_HCSREV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cfeast_hbev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CFEAST_HBEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zfeast_heev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ZFEAST_HEEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zfeast_hcsrgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const MKL_Complex16 *")] Complex* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ZFEAST_HCSRGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const MKL_Complex16 *")] Complex* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sfeast_scsrgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const float *")] float* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SFEAST_SCSRGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const float *")] float* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfeast_srci(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* ze, double* work, [NativeTypeName("MKL_Complex16 *")] Complex* workc, double* aq, double* sq, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* lambda, double* q, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFEAST_SRCI(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* ze, double* work, [NativeTypeName("MKL_Complex16 *")] Complex* workc, double* aq, double* sq, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* lambda, double* q, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sfeast_sbev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SFEAST_SBEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfeast_sygv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFEAST_SYGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cfeast_hegv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CFEAST_HEGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zfeast_hrci(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* ze, [NativeTypeName("MKL_Complex16 *")] Complex* work, [NativeTypeName("MKL_Complex16 *")] Complex* workc, [NativeTypeName("MKL_Complex16 *")] Complex* zaq, [NativeTypeName("MKL_Complex16 *")] Complex* zsq, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* lambda, [NativeTypeName("MKL_Complex16 *")] Complex* q, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ZFEAST_HRCI(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex16 *")] Complex* ze, [NativeTypeName("MKL_Complex16 *")] Complex* work, [NativeTypeName("MKL_Complex16 *")] Complex* workc, [NativeTypeName("MKL_Complex16 *")] Complex* zaq, [NativeTypeName("MKL_Complex16 *")] Complex* zsq, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* lambda, [NativeTypeName("MKL_Complex16 *")] Complex* q, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cfeast_hrci(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* ze, [NativeTypeName("MKL_Complex8 *")] ComplexF* work, [NativeTypeName("MKL_Complex8 *")] ComplexF* workc, [NativeTypeName("MKL_Complex8 *")] ComplexF* zaq, [NativeTypeName("MKL_Complex8 *")] ComplexF* zsq, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* lambda, [NativeTypeName("MKL_Complex8 *")] ComplexF* q, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CFEAST_HRCI(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* ze, [NativeTypeName("MKL_Complex8 *")] ComplexF* work, [NativeTypeName("MKL_Complex8 *")] ComplexF* workc, [NativeTypeName("MKL_Complex8 *")] ComplexF* zaq, [NativeTypeName("MKL_Complex8 *")] ComplexF* zsq, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* lambda, [NativeTypeName("MKL_Complex8 *")] ComplexF* q, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zfeast_hegv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ZFEAST_HEGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const MKL_Complex16 *")] Complex* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sfeast_srci(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* ze, float* work, [NativeTypeName("MKL_Complex8 *")] ComplexF* workc, float* aq, float* sq, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* lambda, float* q, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SFEAST_SRCI(int* ijob, [NativeTypeName("const int *")] int* n, [NativeTypeName("MKL_Complex8 *")] ComplexF* ze, float* work, [NativeTypeName("MKL_Complex8 *")] ComplexF* workc, float* aq, float* sq, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* lambda, float* q, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfeast_scsrgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const double *")] double* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFEAST_SCSRGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const double *")] double* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sfeast_syev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SFEAST_SYEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cfeast_hcsrev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CFEAST_HCSREV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zfeast_hbev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ZFEAST_HBEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex16 *")] Complex* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, [NativeTypeName("MKL_Complex16 *")] Complex* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfeast_sbgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFEAST_SBGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const double *")] double* b, [NativeTypeName("const int *")] int* ldb, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cfeast_hbgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CFEAST_HBGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const MKL_Complex8 *")] ComplexF* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cfeast_heev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CFEAST_HEEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* a, [NativeTypeName("const int *")] int* lda, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sfeast_sbgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* mode, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SFEAST_SBGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const float *")] float* a, [NativeTypeName("const int *")] int* lda, [NativeTypeName("const int *")] int* klb, [NativeTypeName("const float *")] float* b, [NativeTypeName("const int *")] int* ldb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, float* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cfeast_hcsrgv([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const MKL_Complex8 *")] ComplexF* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CFEAST_HCSRGV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* sa, [NativeTypeName("const int *")] int* isa, [NativeTypeName("const int *")] int* jsa, [NativeTypeName("const MKL_Complex8 *")] ComplexF* sb, [NativeTypeName("const int *")] int* isb, [NativeTypeName("const int *")] int* jsb, int* fpm, float* epsout, int* loop, [NativeTypeName("const float *")] float* emin, [NativeTypeName("const float *")] float* emax, int* m0, float* e, [NativeTypeName("MKL_Complex8 *")] ComplexF* x, int* m, float* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfeast_syev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFEAST_SYEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void dfeast_sbev([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DFEAST_SBEV([NativeTypeName("const char *")] sbyte* uplo, [NativeTypeName("const int *")] int* n, [NativeTypeName("const int *")] int* kla, [NativeTypeName("const double *")] double* a, [NativeTypeName("const int *")] int* lda, int* fpm, double* epsout, int* loop, [NativeTypeName("const double *")] double* emin, [NativeTypeName("const double *")] double* emax, int* m0, double* e, double* x, int* m, double* res, int* info);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_ee_init(int* pm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_gv([NativeTypeName("char *")] sbyte* which, int* pm, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descrA, [NativeTypeName("sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("struct matrix_descr")] matrix_descr descrB, int k0, int* k, double* E, double* X, double* res);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_gv([NativeTypeName("char *")] sbyte* which, int* pm, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descrA, [NativeTypeName("sparse_matrix_t")] sparse_matrix* B, [NativeTypeName("struct matrix_descr")] matrix_descr descrB, int k0, int* k, float* E, float* X, float* res);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_ev([NativeTypeName("char *")] sbyte* which, int* pm, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descrA, int k0, int* k, double* E, double* X, double* res);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_ev([NativeTypeName("char *")] sbyte* which, int* pm, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descrA, int k0, int* k, float* E, float* X, float* res);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_svd([NativeTypeName("char *")] sbyte* whichE, [NativeTypeName("char *")] sbyte* whichV, int* pm, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descrA, int k0, int* k, double* E, double* XL, double* XR, double* res);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_svd([NativeTypeName("char *")] sbyte* whichE, [NativeTypeName("char *")] sbyte* whichV, int* pm, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descrA, int k0, int* k, float* E, float* XL, float* XR, float* res);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern MKL_COMPACT_PACK mkl_get_format_compact();

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int mkl_sget_size_compact(int ld, int sd, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_sgepack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("const float *const *")] float** a, int lda, float* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_sgeunpack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("float *const *")] float** a, int lda, [NativeTypeName("const float *")] float* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_sgemm_compact(MKL_LAYOUT layout, MKL_TRANSPOSE transa, MKL_TRANSPOSE transb, int m, int n, int k, float alpha, [NativeTypeName("const float *")] float* ap, int ldap, [NativeTypeName("const float *")] float* bp, int ldbp, float beta, float* cp, int ldcp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_strsm_compact(MKL_LAYOUT layout, MKL_SIDE side, MKL_UPLO uplo, MKL_TRANSPOSE transa, MKL_DIAG diag, int m, int n, float alpha, [NativeTypeName("const float *")] float* ap, int ldap, float* bp, int ldbp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int mkl_dget_size_compact(int ld, int sd, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dgepack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("const double *const *")] double** a, int lda, double* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dgeunpack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("double *const *")] double** a, int lda, [NativeTypeName("const double *")] double* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dgemm_compact(MKL_LAYOUT layout, MKL_TRANSPOSE transa, MKL_TRANSPOSE transb, int m, int n, int k, double alpha, [NativeTypeName("const double *")] double* a, int ldap, [NativeTypeName("const double *")] double* b, int ldbp, double beta, double* c, int ldcp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dtrsm_compact(MKL_LAYOUT layout, MKL_SIDE side, MKL_UPLO uplo, MKL_TRANSPOSE transa, MKL_DIAG diag, int m, int n, double alpha, [NativeTypeName("const double *")] double* a, int ldap, double* b, int ldbp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int mkl_cget_size_compact(int ld, int sd, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_cgepack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("const MKL_Complex8 *const *")] ComplexF** a, int lda, float* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_cgeunpack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("MKL_Complex8 *const *")] ComplexF** a, int lda, [NativeTypeName("const float *")] float* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_cgemm_compact(MKL_LAYOUT layout, MKL_TRANSPOSE transa, MKL_TRANSPOSE transb, int m, int n, int k, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const float *")] float* a, int ldap, [NativeTypeName("const float *")] float* b, int ldbp, [NativeTypeName("const MKL_Complex8 *")] ComplexF* beta, float* c, int ldcp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_ctrsm_compact(MKL_LAYOUT layout, MKL_SIDE side, MKL_UPLO uplo, MKL_TRANSPOSE transa, MKL_DIAG diag, int m, int n, [NativeTypeName("const MKL_Complex8 *")] ComplexF* alpha, [NativeTypeName("const float *")] float* a, int ldap, float* b, int ldbp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int mkl_zget_size_compact(int ld, int sd, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_zgepack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("const MKL_Complex16 *const *")] Complex** a, int lda, double* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_zgeunpack_compact(MKL_LAYOUT layout, int rows, int columns, [NativeTypeName("MKL_Complex16 *const *")] Complex** a, int lda, [NativeTypeName("const double *")] double* ap, int ldap, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_zgemm_compact(MKL_LAYOUT layout, MKL_TRANSPOSE transa, MKL_TRANSPOSE transb, int m, int n, int k, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const double *")] double* a, int ldap, [NativeTypeName("const double *")] double* b, int ldbp, [NativeTypeName("const MKL_Complex16 *")] Complex* beta, double* c, int ldcp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_ztrsm_compact(MKL_LAYOUT layout, MKL_SIDE side, MKL_UPLO uplo, MKL_TRANSPOSE transa, MKL_DIAG diag, int m, int n, [NativeTypeName("const MKL_Complex16 *")] Complex* alpha, [NativeTypeName("const double *")] double* a, int ldap, double* b, int ldbp, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_cgetrinp_compact(MKL_LAYOUT layout, int n, float* ap, int ldap, float* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dgetrinp_compact(MKL_LAYOUT layout, int n, double* ap, int ldap, double* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_sgetrinp_compact(MKL_LAYOUT layout, int n, float* ap, int ldap, float* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_zgetrinp_compact(MKL_LAYOUT layout, int n, double* ap, int ldap, double* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_cgetrfnp_compact(MKL_LAYOUT layout, int m, int n, float* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dgetrfnp_compact(MKL_LAYOUT layout, int m, int n, double* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_sgetrfnp_compact(MKL_LAYOUT layout, int m, int n, float* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_zgetrfnp_compact(MKL_LAYOUT layout, int m, int n, double* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_cpotrf_compact(MKL_LAYOUT layout, MKL_UPLO uplo, int n, float* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dpotrf_compact(MKL_LAYOUT layout, MKL_UPLO uplo, int n, double* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_spotrf_compact(MKL_LAYOUT layout, MKL_UPLO uplo, int n, float* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_zpotrf_compact(MKL_LAYOUT layout, MKL_UPLO uplo, int n, double* ap, int ldap, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_cgeqrf_compact(MKL_LAYOUT layout, int m, int n, float* ap, int ldap, float* taup, float* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_dgeqrf_compact(MKL_LAYOUT layout, int m, int n, double* ap, int ldap, double* taup, double* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_sgeqrf_compact(MKL_LAYOUT layout, int m, int n, float* ap, int ldap, float* taup, float* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void mkl_zgeqrf_compact(MKL_LAYOUT layout, int m, int n, double* ap, int ldap, double* taup, double* work, int lwork, int* info, MKL_COMPACT_PACK format, int nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long mkl_sget_size_compact_64([NativeTypeName("long long")] long ld, [NativeTypeName("long long")] long sd, MKL_COMPACT_PACK format, [NativeTypeName("long long")] long nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long mkl_dget_size_compact_64([NativeTypeName("long long")] long ld, [NativeTypeName("long long")] long sd, MKL_COMPACT_PACK format, [NativeTypeName("long long")] long nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long mkl_cget_size_compact_64([NativeTypeName("long long")] long ld, [NativeTypeName("long long")] long sd, MKL_COMPACT_PACK format, [NativeTypeName("long long")] long nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long mkl_zget_size_compact_64([NativeTypeName("long long")] long ld, [NativeTypeName("long long")] long sd, MKL_COMPACT_PACK format, [NativeTypeName("long long")] long nm);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_set_qr_hint([NativeTypeName("sparse_matrix_t")] sparse_matrix* A, sparse_qr_hint_t hint);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_qr(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descr, sparse_layout_t layout, int columns, double* x, int ldx, [NativeTypeName("const double *")] double* b, int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_qr(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descr, sparse_layout_t layout, int columns, float* x, int ldx, [NativeTypeName("const float *")] float* b, int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_qr_reorder([NativeTypeName("sparse_matrix_t")] sparse_matrix* A, [NativeTypeName("struct matrix_descr")] matrix_descr descr);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_qr_factorize([NativeTypeName("sparse_matrix_t")] sparse_matrix* A, double* alt_values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_qr_factorize([NativeTypeName("sparse_matrix_t")] sparse_matrix* A, float* alt_values);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_qr_solve(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, double* alt_values, sparse_layout_t layout, int columns, double* x, int ldx, [NativeTypeName("const double *")] double* b, int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_qr_solve(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, float* alt_values, sparse_layout_t layout, int columns, float* x, int ldx, [NativeTypeName("const float *")] float* b, int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_qr_qmult(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, sparse_layout_t layout, int columns, double* x, int ldx, [NativeTypeName("const double *")] double* b, int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_qr_qmult(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, sparse_layout_t layout, int columns, float* x, int ldx, [NativeTypeName("const float *")] float* b, int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_d_qr_rsolve(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, sparse_layout_t layout, int columns, double* x, int ldx, [NativeTypeName("const double *")] double* b, int ldb);

        [DllImport("mkl_rt.2.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sparse_status_t mkl_sparse_s_qr_rsolve(sparse_operation_t operation, [NativeTypeName("sparse_matrix_t")] sparse_matrix* A, sparse_layout_t layout, int columns, float* x, int ldx, [NativeTypeName("const float *")] float* b, int ldb);
    }
}
