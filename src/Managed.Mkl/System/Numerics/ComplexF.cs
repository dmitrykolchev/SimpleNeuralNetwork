// <copyright file="ComplexF.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using global::System.Diagnostics;
using global::System.Diagnostics.CodeAnalysis;
using global::System.Globalization;
using global::System.Runtime.CompilerServices;

namespace System.Numerics;

/// <summary>
/// A ComplexF number z is a number of the form z = x + yi, where x and y
/// are real numbers, and i is the imaginary unit, with the property i2= -1.
/// </summary>
[Serializable]
[StructLayout(LayoutKind.Sequential)]
public readonly struct ComplexF
    : IEquatable<ComplexF>,
      IFormattable,
      INumberBase<ComplexF>,
      ISignedNumber<ComplexF>,
      IUtf8SpanFormattable
{
    private const NumberStyles DefaultNumberStyle = NumberStyles.Float | NumberStyles.AllowThousands;

    private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite
                                                     | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign
                                                     | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint
                                                     | NumberStyles.AllowThousands | NumberStyles.AllowExponent
                                                     | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier);

    public static readonly ComplexF Zero = new(0.0f, 0.0f);
    public static readonly ComplexF One = new(1.0f, 0.0f);
    public static readonly ComplexF ImaginaryOne = new(0.0f, 1.0f);
    public static readonly ComplexF NaN = new(float.NaN, float.NaN);
    public static readonly ComplexF Infinity = new(float.PositiveInfinity, float.PositiveInfinity);

    private const float InverseOfLog10 = 0.43429448190325f; // 1 / Log(10)

    // This is the largest x for which (Hypot(x,x) + x) will not overflow. It is used for branching inside Sqrt.
    private static readonly float _sqrtRescaleThreshold = float.MaxValue / (MathF.Sqrt(2.0f) + 1.0f);

    // This is the largest x for which 2 x^2 will not overflow. It is used for branching inside Asin and Acos.
    private static readonly float _asinOverflowThreshold = MathF.Sqrt(float.MaxValue) / 2.0f;

    // This value is used inside Asin and Acos.
    private static readonly float _log2 = MathF.Log(2.0f);

    // Do not rename, these fields are needed for binary serialization
    private readonly float _real; // Do not rename (binary serialization)
    private readonly float _imaginary; // Do not rename (binary serialization)

    public ComplexF(float real, float imaginary)
    {
        _real = real;
        _imaginary = imaginary;
    }

    public float Real { get { return _real; } }
    public float Imaginary { get { return _imaginary; } }

    public float Magnitude { get { return Abs(this); } }
    public float Phase { get { return MathF.Atan2(_imaginary, _real); } }

    public static ComplexF FromPolarCoordinates(float magnitude, float phase)
    {
        var (sin, cos) = MathF.SinCos(phase);
        return new ComplexF(magnitude * cos, magnitude * sin);
    }

    public static ComplexF Negate(ComplexF value)
    {
        return -value;
    }

    public static ComplexF Add(ComplexF left, ComplexF right)
    {
        return left + right;
    }

    public static ComplexF Add(ComplexF left, float right)
    {
        return left + right;
    }

    public static ComplexF Add(float left, ComplexF right)
    {
        return left + right;
    }

    public static ComplexF Subtract(ComplexF left, ComplexF right)
    {
        return left - right;
    }

    public static ComplexF Subtract(ComplexF left, float right)
    {
        return left - right;
    }

    public static ComplexF Subtract(float left, ComplexF right)
    {
        return left - right;
    }

    public static ComplexF Multiply(ComplexF left, ComplexF right)
    {
        return left * right;
    }

    public static ComplexF Multiply(ComplexF left, float right)
    {
        return left * right;
    }

    public static ComplexF Multiply(float left, ComplexF right)
    {
        return left * right;
    }

    public static ComplexF Divide(ComplexF dividend, ComplexF divisor)
    {
        return dividend / divisor;
    }

    public static ComplexF Divide(ComplexF dividend, float divisor)
    {
        return dividend / divisor;
    }

    public static ComplexF Divide(float dividend, ComplexF divisor)
    {
        return dividend / divisor;
    }

    public static ComplexF operator -(ComplexF value)  /* Unary negation of a ComplexF number */
    {
        return new ComplexF(-value._real, -value._imaginary);
    }

    public static ComplexF operator +(ComplexF left, ComplexF right)
    {
        return new ComplexF(left._real + right._real, left._imaginary + right._imaginary);
    }

    public static ComplexF operator +(ComplexF left, float right)
    {
        return new ComplexF(left._real + right, left._imaginary);
    }

    public static ComplexF operator +(float left, ComplexF right)
    {
        return new ComplexF(left + right._real, right._imaginary);
    }

    public static ComplexF operator -(ComplexF left, ComplexF right)
    {
        return new ComplexF(left._real - right._real, left._imaginary - right._imaginary);
    }

    public static ComplexF operator -(ComplexF left, float right)
    {
        return new ComplexF(left._real - right, left._imaginary);
    }

    public static ComplexF operator -(float left, ComplexF right)
    {
        return new ComplexF(left - right._real, -right._imaginary);
    }

    public static ComplexF operator *(ComplexF left, ComplexF right)
    {
        // Multiplication:  (a + bi)(c + di) = (ac -bd) + (bc + ad)i
        var result_realpart = (left._real * right._real) - (left._imaginary * right._imaginary);
        var result_imaginarypart = (left._imaginary * right._real) + (left._real * right._imaginary);
        return new ComplexF(result_realpart, result_imaginarypart);
    }

    public static ComplexF operator *(ComplexF left, float right)
    {
        if (!float.IsFinite(left._real))
        {
            if (!float.IsFinite(left._imaginary))
            {
                return new ComplexF(float.NaN, float.NaN);
            }

            return new ComplexF(left._real * right, float.NaN);
        }

        if (!float.IsFinite(left._imaginary))
        {
            return new ComplexF(float.NaN, left._imaginary * right);
        }

        return new ComplexF(left._real * right, left._imaginary * right);
    }

    public static ComplexF operator *(float left, ComplexF right)
    {
        if (!float.IsFinite(right._real))
        {
            if (!float.IsFinite(right._imaginary))
            {
                return new ComplexF(float.NaN, float.NaN);
            }

            return new ComplexF(left * right._real, float.NaN);
        }

        if (!float.IsFinite(right._imaginary))
        {
            return new ComplexF(float.NaN, left * right._imaginary);
        }

        return new ComplexF(left * right._real, left * right._imaginary);
    }

    public static ComplexF operator /(ComplexF left, ComplexF right)
    {
        // Division : Smith's formula.
        var a = left._real;
        var b = left._imaginary;
        var c = right._real;
        var d = right._imaginary;

        // Computing c * c + d * d will overflow even in cases where the actual result of the division does not overflow.
        if (MathF.Abs(d) < MathF.Abs(c))
        {
            var doc = d / c;
            return new ComplexF((a + b * doc) / (c + d * doc), (b - a * doc) / (c + d * doc));
        }
        else
        {
            var cod = c / d;
            return new ComplexF((b + a * cod) / (d + c * cod), (-a + b * cod) / (d + c * cod));
        }
    }

    public static ComplexF operator /(ComplexF left, float right)
    {
        // IEEE prohibit optimizations which are value changing
        // so we make sure that behaviour for the simplified version exactly match
        // full version.
        if (right == 0)
        {
            return new ComplexF(float.NaN, float.NaN);
        }

        if (!float.IsFinite(left._real))
        {
            if (!float.IsFinite(left._imaginary))
            {
                return new ComplexF(float.NaN, float.NaN);
            }

            return new ComplexF(left._real / right, float.NaN);
        }

        if (!float.IsFinite(left._imaginary))
        {
            return new ComplexF(float.NaN, left._imaginary / right);
        }

        // Here the actual optimized version of code.
        return new ComplexF(left._real / right, left._imaginary / right);
    }

    public static ComplexF operator /(float left, ComplexF right)
    {
        // Division : Smith's formula.
        var a = left;
        var c = right._real;
        var d = right._imaginary;

        // Computing c * c + d * d will overflow even in cases where the actual result of the division does not overflow.
        if (MathF.Abs(d) < MathF.Abs(c))
        {
            var doc = d / c;
            return new ComplexF(a / (c + d * doc), (-a * doc) / (c + d * doc));
        }
        else
        {
            var cod = c / d;
            return new ComplexF(a * cod / (d + c * cod), -a / (d + c * cod));
        }
    }

    public static float Abs(ComplexF value)
    {
        return float.Hypot(value._real, value._imaginary);
    }

    private static float Log1P(float x)
    {
        // Compute log(1 + x) without loss of accuracy when x is small.

        // Our only use case so far is for positive values, so this isn't coded to handle negative values.
        Debug.Assert((x >= 0.0f) || float.IsNaN(x));

        var xp1 = 1.0f + x;
        if (xp1 == 1.0f)
        {
            return x;
        }
        else if (x < 0.75f)
        {
            // This is accurate to within 5 ulp with any floating-point system that uses a guard digit,
            // as proven in Theorem 4 of "What Every Computer Scientist Should Know About Floating-Point
            // Arithmetic" (https://docs.oracle.com/cd/E19957-01/806-3568/ncg_goldberg.html)
            return x * MathF.Log(xp1) / (xp1 - 1.0f);
        }
        else
        {
            return MathF.Log(xp1);
        }

    }

    public static ComplexF Conjugate(ComplexF value)
    {
        // Conjugate of a ComplexF number: the conjugate of x+i*y is x-i*y
        return new ComplexF(value._real, -value._imaginary);
    }

    public static ComplexF Reciprocal(ComplexF value)
    {
        // Reciprocal of a ComplexF number : the reciprocal of x+i*y is 1/(x+i*y)
        if (value._real == 0 && value._imaginary == 0)
        {
            return Zero;
        }
        return One / value;
    }

    public static bool operator ==(ComplexF left, ComplexF right)
    {
        return left._real == right._real && left._imaginary == right._imaginary;
    }

    public static bool operator !=(ComplexF left, ComplexF right)
    {
        return left._real != right._real || left._imaginary != right._imaginary;
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj is ComplexF other && Equals(other);
    }

    public bool Equals(ComplexF value)
    {
        return _real.Equals(value._real) && _imaginary.Equals(value._imaginary);
    }

    public override int GetHashCode() => HashCode.Combine(_real, _imaginary);

    public override string ToString() => ToString(null, null);

    public string ToString([StringSyntax(StringSyntaxAttribute.NumericFormat)] string? format) => ToString(format, null);

    public string ToString(IFormatProvider? provider) => ToString(null, provider);

    public string ToString([StringSyntax(StringSyntaxAttribute.NumericFormat)] string? format, IFormatProvider? provider)
    {
        // $"<{m_real.ToString(format, provider)}; {m_imaginary.ToString(format, provider)}>";
        var handler = new DefaultInterpolatedStringHandler(4, 2, provider, stackalloc char[512]);
        handler.AppendLiteral("<");
        handler.AppendFormatted(_real, format);
        handler.AppendLiteral("; ");
        handler.AppendFormatted(_imaginary, format);
        handler.AppendLiteral(">");
        return handler.ToStringAndClear();
    }

    public static ComplexF Sin(ComplexF value)
    {
        var (sin, cos) = MathF.SinCos(value._real);
        return new ComplexF(sin * MathF.Cosh(value._imaginary), cos * MathF.Sinh(value._imaginary));
        // There is a known limitation with this algorithm: inputs that cause sinh and cosh to overflow, but for
        // which sin or cos are small enough that sin * cosh or cos * sinh are still representable, nonetheless
        // produce overflow. For example, Sin((0.01, 711.0)) should produce (~3.0E306, PositiveInfinity), but
        // instead produces (PositiveInfinity, PositiveInfinity).
    }

    public static ComplexF Sinh(ComplexF value)
    {
        // Use sinh(z) = -i sin(iz) to compute via sin(z).
        var sin = Sin(new ComplexF(-value._imaginary, value._real));
        return new ComplexF(sin._imaginary, -sin._real);
    }

    public static ComplexF Asin(ComplexF value)
    {
        float b, bPrime, v;
        Asin_Internal(MathF.Abs(value.Real), MathF.Abs(value.Imaginary), out b, out bPrime, out v);

        float u;
        if (bPrime < 0.0)
        {
            u = MathF.Asin(b);
        }
        else
        {
            u = MathF.Atan(bPrime);
        }

        if (value.Real < 0.0)
        {
            u = -u;
        }

        if (value.Imaginary < 0.0)
        {
            v = -v;
        }

        return new ComplexF(u, v);
    }

    public static ComplexF Cos(ComplexF value)
    {
        (var sin, var cos) = MathF.SinCos(value._real);
        return new ComplexF(cos * MathF.Cosh(value._imaginary), -sin * MathF.Sinh(value._imaginary));
    }

    public static ComplexF Cosh(ComplexF value)
    {
        // Use cosh(z) = cos(iz) to compute via cos(z).
        return Cos(new ComplexF(-value._imaginary, value._real));
    }

    public static ComplexF Acos(ComplexF value)
    {
        float b, bPrime, v;
        Asin_Internal(MathF.Abs(value.Real), MathF.Abs(value.Imaginary), out b, out bPrime, out v);

        float u;
        if (bPrime < 0.0)
        {
            u = MathF.Acos(b);
        }
        else
        {
            u = MathF.Atan((float)(1.0 / bPrime));
        }

        if (value.Real < 0.0)
        {
            u = MathF.PI - u;
        }

        if (value.Imaginary > 0.0)
        {
            v = -v;
        }

        return new ComplexF(u, v);
    }

    public static ComplexF Tan(ComplexF value)
    {
        // tan z = sin z / cos z, but to avoid unnecessary repeated trig computations, use
        //   tan z = (sin(2x) + i sinh(2y)) / (cos(2x) + cosh(2y))
        // (see Abramowitz & Stegun 4.3.57 or derive by hand), and compute trig functions here.

        // This approach does not work for |y| > ~355, because sinh(2y) and cosh(2y) overflow,
        // even though their ratio does not. In that case, divide through by cosh to get:
        //   tan z = (sin(2x) / cosh(2y) + i \tanh(2y)) / (1 + cos(2x) / cosh(2y))
        // which correctly computes the (tiny) real part and the (normal-sized) imaginary part.

        var x2 = 2.0f * value._real;
        var y2 = 2.0f * value._imaginary;
        (var sin, var cos) = MathF.SinCos(x2);
        var cosh = MathF.Cosh(y2);
        if (MathF.Abs(value._imaginary) <= 4.0)
        {
            var D = cos + cosh;
            return new ComplexF(sin / D, MathF.Sinh(y2) / D);
        }
        else
        {
            var D = 1.0f + cos / cosh;
            return new ComplexF(sin / cosh / D, MathF.Tanh(y2) / D);
        }
    }

    public static ComplexF Tanh(ComplexF value)
    {
        // Use tanh(z) = -i tan(iz) to compute via tan(z).
        var tan = Tan(new ComplexF(-value._imaginary, value._real));
        return new ComplexF(tan._imaginary, -tan._real);
    }

    public static ComplexF Atan(ComplexF value)
    {
        var two = new ComplexF((float)2.0, 0.0f);
        return (ImaginaryOne / two) * (Log(One - ImaginaryOne * value) - Log(One + ImaginaryOne * value));
    }

    private static void Asin_Internal(float x, float y, out float b, out float bPrime, out float v)
    {

        // This method for the inverse ComplexF sine (and cosine) is described in Hull, Fairgrieve,
        // and Tang, "Implementing the ComplexF Arcsine and Arccosine Functions Using Exception Handling",
        // ACM Transactions on Mathematical Software (1997)
        // (https://www.researchgate.net/profile/Ping_Tang3/publication/220493330_Implementing_the_Complex_Arcsine_and_Arccosine_Functions_Using_Exception_Handling/links/55b244b208ae9289a085245d.pdf)

        // First, the basics: start with sin(w) = (e^{iw} - e^{-iw}) / (2i) = z. Here z is the input
        // and w is the output. To solve for w, define t = e^{i w} and multiply through by t to
        // get the quadratic equation t^2 - 2 i z t - 1 = 0. The solution is t = i z + sqrt(1 - z^2), so
        //   w = arcsin(z) = - i log( i z + sqrt(1 - z^2) )
        // Decompose z = x + i y, multiply out i z + sqrt(1 - z^2), use log(s) = |s| + i arg(s), and do a
        // bunch of algebra to get the components of w = arcsin(z) = u + i v
        //   u = arcsin(beta)  v = sign(y) log(alpha + sqrt(alpha^2 - 1))
        // where
        //   alpha = (rho + sigma) / 2      beta = (rho - sigma) / 2
        //   rho = sqrt((x + 1)^2 + y^2)    sigma = sqrt((x - 1)^2 + y^2)
        // These formulas appear in DLMF section 4.23. (http://dlmf.nist.gov/4.23), along with the analogous
        //   arccos(w) = arccos(beta) - i sign(y) log(alpha + sqrt(alpha^2 - 1))
        // So alpha and beta together give us arcsin(w) and arccos(w).

        // As written, alpha is not susceptible to cancelation errors, but beta is. To avoid cancelation, note
        //   beta = (rho^2 - sigma^2) / (rho + sigma) / 2 = (2 x) / (rho + sigma) = x / alpha
        // which is not subject to cancelation. Note alpha >= 1 and |beta| <= 1.

        // For alpha ~ 1, the argument of the log is near unity, so we compute (alpha - 1) instead,
        // write the argument as 1 + (alpha - 1) + sqrt((alpha - 1)(alpha + 1)), and use the log1p function
        // to compute the log without loss of accuracy.
        // For beta ~ 1, arccos does not accurately resolve small angles, so we compute the tangent of the angle
        // instead.
        // Hull, Fairgrieve, and Tang derive formulas for (alpha - 1) and beta' = tan(u) that do not suffer
        // from cancelation in these cases.

        // For simplicity, we assume all positive inputs and return all positive outputs. The caller should
        // assign signs appropriate to the desired cut conventions. We return v directly since its magnitude
        // is the same for both arcsin and arccos. Instead of u, we usually return beta and sometimes beta'.
        // If beta' is not computed, it is set to -1; if it is computed, it should be used instead of beta
        // to determine u. Compute u = arcsin(beta) or u = arctan(beta') for arcsin, u = arccos(beta)
        // or arctan(1/beta') for arccos.

        Debug.Assert((x >= 0.0) || float.IsNaN(x));
        Debug.Assert((y >= 0.0) || float.IsNaN(y));

        // For x or y large enough to overflow alpha^2, we can simplify our formulas and avoid overflow.
        if ((x > _asinOverflowThreshold) || (y > _asinOverflowThreshold))
        {
            b = (float)-1.0;
            bPrime = x / y;

            float small, big;
            if (x < y)
            {
                small = x;
                big = y;
            }
            else
            {
                small = y;
                big = x;
            }
            var ratio = small / big;
            v = (float)(_log2 + MathF.Log(big) + 0.5 * Log1P(ratio * ratio));
        }
        else
        {
            var r = float.Hypot((float)(x + 1.0), y);
            var s = float.Hypot((float)(x - 1.0), y);

            var a = (float)((r + s) * 0.5);
            b = x / a;

            if (b > 0.75)
            {
                if (x <= 1.0)
                {
                    var amx = (float)((y * y / (r + (x + 1.0)) + (s + (1.0 - x))) * 0.5);
                    bPrime = x / MathF.Sqrt((a + x) * amx);
                }
                else
                {
                    // In this case, amx ~ y^2. Since we take the square root of amx, we should
                    // pull y out from under the square root so we don't lose its contribution
                    // when y^2 underflows.
                    var t = (float)((1.0 / (r + (x + 1.0)) + 1.0 / (s + (x - 1.0))) * 0.5);
                    bPrime = x / y / MathF.Sqrt((a + x) * t);
                }
            }
            else
            {
                bPrime = (float)-1.0;
            }

            if (a < 1.5)
            {
                if (x < 1.0)
                {
                    // This is another case where our expression is proportional to y^2 and
                    // we take its square root, so again we pull out a factor of y from
                    // under the square root.
                    var t = (float)((1.0 / (r + (x + 1.0)) + 1.0 / (s + (1.0 - x))) * 0.5);
                    var am1 = y * y * t;
                    v = Log1P(am1 + y * MathF.Sqrt((float)(t * (a + 1.0))));
                }
                else
                {
                    var am1 = (float)((y * y / (r + (x + 1.0)) + (s + (x - 1.0))) * 0.5);
                    v = Log1P(am1 + MathF.Sqrt((float)(am1 * (a + 1.0))));
                }
            }
            else
            {
                // Because of the test above, we can be sure that a * a will not overflow.
                v = MathF.Log(a + MathF.Sqrt((float)((a - 1.0) * (a + 1.0))));
            }
        }
    }

    public static bool IsFinite(ComplexF value) => float.IsFinite(value._real) && float.IsFinite(value._imaginary);

    public static bool IsInfinity(ComplexF value) => float.IsInfinity(value._real) || float.IsInfinity(value._imaginary);

    public static bool IsNaN(ComplexF value) => !IsInfinity(value) && !IsFinite(value);

    public static ComplexF Log(ComplexF value)
    {
        return new ComplexF(MathF.Log(Abs(value)), MathF.Atan2(value._imaginary, value._real));
    }

    public static ComplexF Log(ComplexF value, float baseValue)
    {
        return Log(value) / Log(baseValue);
    }

    public static ComplexF Log10(ComplexF value)
    {
        var tempLog = Log(value);
        return Scale(tempLog, InverseOfLog10);
    }

    public static ComplexF Exp(ComplexF value)
    {
        var expReal = MathF.Exp(value._real);
        return FromPolarCoordinates(expReal, value._imaginary);
    }

    public static ComplexF Sqrt(ComplexF value)
    {

        // Handle NaN input cases according to IEEE 754
        if (float.IsNaN(value._real))
        {
            if (float.IsInfinity(value._imaginary))
            {
                return new ComplexF(float.PositiveInfinity, value._imaginary);
            }
            return new ComplexF(float.NaN, float.NaN);
        }
        if (float.IsNaN(value._imaginary))
        {
            if (float.IsPositiveInfinity(value._real))
            {
                return new ComplexF(float.NaN, float.PositiveInfinity);
            }
            if (float.IsNegativeInfinity(value._real))
            {
                return new ComplexF(float.PositiveInfinity, float.NaN);
            }
            return new ComplexF(float.NaN, float.NaN);
        }

        if (value._imaginary == 0.0)
        {
            // Handle the trivial case quickly.
            if (value._real < 0.0)
            {
                return new ComplexF(0.0f, MathF.Sqrt(-value._real));
            }

            return new ComplexF(MathF.Sqrt(value._real), 0.0f);
        }

        // One way to compute Sqrt(z) is just to call Pow(z, 0.5), which coverts to polar coordinates
        // (sqrt + atan), halves the phase, and reconverts to cartesian coordinates (cos + sin).
        // Not only is this more expensive than necessary, it also fails to preserve certain expected
        // symmetries, such as that the square root of a pure negative is a pure imaginary, and that the
        // square root of a pure imaginary has exactly equal real and imaginary parts. This all goes
        // back to the fact that MathF.PI is not stored with infinite precision, so taking half of MathF.PI
        // does not land us on an argument with cosine exactly equal to zero.

        // To find a fast and symmetry-respecting formula for ComplexF square root,
        // note x + i y = \sqrt{a + i b} implies x^2 + 2 i x y - y^2 = a + i b,
        // so x^2 - y^2 = a and 2 x y = b. Cross-substitute and use the quadratic formula to obtain
        //   x = \sqrt{\frac{\sqrt{a^2 + b^2} + a}{2}}  y = \pm \sqrt{\frac{\sqrt{a^2 + b^2} - a}{2}}
        // There is just one complication: depending on the sign on a, either x or y suffers from
        // cancelation when |b| << |a|. We can get around this by noting that our formulas imply
        // x^2 y^2 = b^2 / 4, so |x| |y| = |b| / 2. So after computing the one that doesn't suffer
        // from cancelation, we can compute the other with just a division. This is basically just
        // the right way to evaluate the quadratic formula without cancelation.

        // All this reduces our total cost to two sqrts and a few flops, and it respects the desired
        // symmetries. Much better than atan + cos + sin!

        // The signs are a matter of choice of branch cut, which is traditionally taken so x > 0 and sign(y) = sign(b).

        // If the components are too large, Hypot will overflow, even though the subsequent sqrt would
        // make the result representable. To avoid this, we re-scale (by exact powers of 2 for accuracy)
        // when we encounter very large components to avoid intermediate infinities.
        var rescale = false;
        var realCopy = value._real;
        var imaginaryCopy = value._imaginary;
        if ((MathF.Abs(realCopy) >= _sqrtRescaleThreshold) || (MathF.Abs(imaginaryCopy) >= _sqrtRescaleThreshold))
        {
            if (float.IsInfinity(value._imaginary))
            {
                // We need to handle infinite imaginary parts specially because otherwise
                // our formulas below produce inf/inf = NaN.
                return (new ComplexF(float.PositiveInfinity, imaginaryCopy));
            }

            realCopy *= (float)0.25;
            imaginaryCopy *= (float)0.25;
            rescale = true;
        }

        // This is the core of the algorithm. Everything else is special case handling.
        float x, y;
        if (realCopy >= 0.0)
        {
            x = MathF.Sqrt((float)((float.Hypot(realCopy, imaginaryCopy) + realCopy) * 0.5));
            y = (float)(imaginaryCopy / (2.0 * x));
        }
        else
        {
            y = MathF.Sqrt((float)((float.Hypot(realCopy, imaginaryCopy) - realCopy) * 0.5));
            if (imaginaryCopy < 0.0)
            {
                y = -y;
            }

            x = (float)(imaginaryCopy / (2.0 * y));
        }

        if (rescale)
        {
            x *= (float)2.0;
            y *= (float)2.0;
        }

        return new ComplexF(x, y);
    }

    public static ComplexF Pow(ComplexF value, ComplexF power)
    {
        if (power == Zero)
        {
            return One;
        }

        if (value == Zero)
        {
            return Zero;
        }

        var valueReal = value._real;
        var valueImaginary = value._imaginary;
        var powerReal = power._real;
        var powerImaginary = power._imaginary;

        var rho = Abs(value);
        var theta = MathF.Atan2(valueImaginary, valueReal);
        var newRho = powerReal * theta + powerImaginary * MathF.Log(rho);

        var t = MathF.Pow(rho, powerReal) * MathF.Exp(-powerImaginary * theta);

        return FromPolarCoordinates(t, newRho);
    }

    public static ComplexF Pow(ComplexF value, float power)
    {
        return Pow(value, new ComplexF(power, 0));
    }

    private static ComplexF Scale(ComplexF value, float factor)
    {
        var realResult = factor * value._real;
        var imaginaryResuilt = factor * value._imaginary;
        return new ComplexF(realResult, imaginaryResuilt);
    }

    //
    // Explicit Conversions To Complex
    //

    public static explicit operator ComplexF(decimal value)
    {
        return new ComplexF((float)value, 0.0f);
    }

    /// <summary>Explicitly converts a <see cref="Int128" /> value to a float-precision ComplexF number.</summary>
    /// <param name="value">The value to convert.</param>
    /// <returns><paramref name="value" /> converted to a float-precision ComplexF number.</returns>
    public static explicit operator ComplexF(Int128 value)
    {
        return new ComplexF((float)value, 0.0f);
    }

    public static explicit operator ComplexF(BigInteger value)
    {
        return new ComplexF((float)value, 0.0f);
    }

    /// <summary>Explicitly converts a <see cref="UInt128" /> value to a float-precision ComplexF number.</summary>
    /// <param name="value">The value to convert.</param>
    /// <returns><paramref name="value" /> converted to a float-precision ComplexF number.</returns>
    //[CLSCompliant(false)]
    public static explicit operator ComplexF(UInt128 value)
    {
        return new ComplexF((float)value, 0.0f);
    }

    //
    // Implicit Conversions To Complex
    //

    public static implicit operator ComplexF(byte value)
    {
        return new ComplexF(value, 0.0f);
    }

    /// <summary>Implicitly converts a <see cref="char" /> value to a float-precision ComplexF number.</summary>
    /// <param name="value">The value to convert.</param>
    /// <returns><paramref name="value" /> converted to a float-precision ComplexF number.</returns>
    public static implicit operator ComplexF(char value)
    {
        return new ComplexF(value, 0.0f);
    }

    public static implicit operator ComplexF(float value)
    {
        return new ComplexF(value, 0.0f);
    }

    /// <summary>Implicitly converts a <see cref="Half" /> value to a float-precision ComplexF number.</summary>
    /// <param name="value">The value to convert.</param>
    /// <returns><paramref name="value" /> converted to a float-precision ComplexF number.</returns>
    public static implicit operator ComplexF(Half value)
    {
        return new ComplexF((float)value, 0.0f);
    }

    public static implicit operator ComplexF(short value)
    {
        return new ComplexF(value, 0.0f);
    }

    public static implicit operator ComplexF(int value)
    {
        return new ComplexF(value, 0.0f);
    }

    public static implicit operator ComplexF(long value)
    {
        return new ComplexF(value, 0.0f);
    }

    /// <summary>Implicitly converts a <see cref="IntPtr" /> value to a float-precision ComplexF number.</summary>
    /// <param name="value">The value to convert.</param>
    /// <returns><paramref name="value" /> converted to a float-precision ComplexF number.</returns>
    public static implicit operator ComplexF(nint value)
    {
        return new ComplexF(value, 0.0f);
    }

    //[CLSCompliant(false)]
    public static implicit operator ComplexF(sbyte value)
    {
        return new ComplexF(value, 0.0f);
    }

    public static implicit operator ComplexF(double value)
    {
        return new ComplexF((float)value, 0.0f);
    }

    //[CLSCompliant(false)]
    public static implicit operator ComplexF(ushort value)
    {
        return new ComplexF(value, 0.0f);
    }

    //[CLSCompliant(false)]
    public static implicit operator ComplexF(uint value)
    {
        return new ComplexF(value, 0.0f);
    }

    //[CLSCompliant(false)]
    public static implicit operator ComplexF(ulong value)
    {
        return new ComplexF(value, 0.0f);
    }

    /// <summary>Implicitly converts a <see cref="UIntPtr" /> value to a float-precision ComplexF number.</summary>
    /// <param name="value">The value to convert.</param>
    /// <returns><paramref name="value" /> converted to a float-precision ComplexF number.</returns>
    //[CLSCompliant(false)]
    public static implicit operator ComplexF(nuint value)
    {
        return new ComplexF(value, 0.0f);
    }

    //
    // IAdditiveIdentity
    //

    /// <inheritdoc cref="IAdditiveIdentity{TSelf, TResult}.AdditiveIdentity" />
    static ComplexF IAdditiveIdentity<ComplexF, ComplexF>.AdditiveIdentity => new(0.0f, 0.0f);

    //
    // IDecrementOperators
    //

    /// <inheritdoc cref="IDecrementOperators{TSelf}.op_Decrement(TSelf)" />
    public static ComplexF operator --(ComplexF value) => value - One;

    //
    // IIncrementOperators
    //

    /// <inheritdoc cref="IIncrementOperators{TSelf}.op_Increment(TSelf)" />
    public static ComplexF operator ++(ComplexF value) => value + One;

    //
    // IMultiplicativeIdentity
    //

    /// <inheritdoc cref="IMultiplicativeIdentity{TSelf, TResult}.MultiplicativeIdentity" />
    static ComplexF IMultiplicativeIdentity<ComplexF, ComplexF>.MultiplicativeIdentity => new(1.0f, 0.0f);

    //
    // INumberBase
    //

    /// <inheritdoc cref="INumberBase{TSelf}.One" />
    static ComplexF INumberBase<ComplexF>.One => new(1.0f, 0.0f);

    /// <inheritdoc cref="INumberBase{TSelf}.Radix" />
    static int INumberBase<ComplexF>.Radix => 2;

    /// <inheritdoc cref="INumberBase{TSelf}.Zero" />
    static ComplexF INumberBase<ComplexF>.Zero => new(0.0f, 0.0f);

    /// <inheritdoc cref="INumberBase{TSelf}.Abs(TSelf)" />
    static ComplexF INumberBase<ComplexF>.Abs(ComplexF value) => Abs(value);

    /// <inheritdoc cref="INumberBase{TSelf}.CreateChecked{TOther}(TOther)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComplexF CreateChecked<TOther>(TOther value)
        where TOther : INumberBase<TOther>
    {
        ComplexF result;

        if (typeof(TOther) == typeof(Complex))
        {
            result = (ComplexF)(object)value;
        }
        else if (!TryConvertFrom(value, out result) && !TOther.TryConvertToChecked(value, out result))
        {
            throw new NotSupportedException();
        }

        return result;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.CreateSaturating{TOther}(TOther)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComplexF CreateSaturating<TOther>(TOther value)
        where TOther : INumberBase<TOther>
    {
        ComplexF result;

        if (typeof(TOther) == typeof(Complex))
        {
            result = (ComplexF)(object)value;
        }
        else if (!TryConvertFrom(value, out result) && !TOther.TryConvertToSaturating(value, out result))
        {
            throw new NotSupportedException();
        }

        return result;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.CreateTruncating{TOther}(TOther)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComplexF CreateTruncating<TOther>(TOther value)
        where TOther : INumberBase<TOther>
    {
        ComplexF result;

        if (typeof(TOther) == typeof(Complex))
        {
            result = (ComplexF)(object)value;
        }
        else if (!TryConvertFrom(value, out result) && !TOther.TryConvertToTruncating(value, out result))
        {
            throw new NotSupportedException();
        }

        return result;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.IsCanonical(TSelf)" />
    static bool INumberBase<ComplexF>.IsCanonical(ComplexF value) => true;

    /// <inheritdoc cref="INumberBase{TSelf}.IsComplexNumber(TSelf)" />
    public static bool IsComplexNumber(ComplexF value) => (value._real != 0.0) && (value._imaginary != 0.0);

    /// <inheritdoc cref="INumberBase{TSelf}.IsEvenInteger(TSelf)" />
    public static bool IsEvenInteger(ComplexF value) => (value._imaginary == 0) && float.IsEvenInteger(value._real);

    /// <inheritdoc cref="INumberBase{TSelf}.IsImaginaryNumber(TSelf)" />
    public static bool IsImaginaryNumber(ComplexF value) => (value._real == 0.0) && float.IsRealNumber(value._imaginary);

    /// <inheritdoc cref="INumberBase{TSelf}.IsInteger(TSelf)" />
    public static bool IsInteger(ComplexF value) => (value._imaginary == 0) && float.IsInteger(value._real);

    /// <inheritdoc cref="INumberBase{TSelf}.IsNegative(TSelf)" />
    public static bool IsNegative(ComplexF value)
    {
        // since ComplexF numbers do not have a well-defined concept of
        // negative we report false if this value has an imaginary part

        return (value._imaginary == 0.0) && float.IsNegative(value._real);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.IsNegativeInfinity(TSelf)" />
    public static bool IsNegativeInfinity(ComplexF value)
    {
        // since ComplexF numbers do not have a well-defined concept of
        // negative we report false if this value has an imaginary part

        return (value._imaginary == 0.0) && float.IsNegativeInfinity(value._real);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.IsNormal(TSelf)" />
    public static bool IsNormal(ComplexF value)
    {
        // much as IsFinite requires both part to be finite, we require both
        // part to be "normal" (finite, non-zero, and non-subnormal) to be true

        return float.IsNormal(value._real)
            && ((value._imaginary == 0.0) || float.IsNormal(value._imaginary));
    }

    /// <inheritdoc cref="INumberBase{TSelf}.IsOddInteger(TSelf)" />
    public static bool IsOddInteger(ComplexF value) => (value._imaginary == 0) && float.IsOddInteger(value._real);

    /// <inheritdoc cref="INumberBase{TSelf}.IsPositive(TSelf)" />
    public static bool IsPositive(ComplexF value)
    {
        // since ComplexF numbers do not have a well-defined concept of
        // negative we report false if this value has an imaginary part

        return (value._imaginary == 0.0) && float.IsPositive(value._real);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.IsPositiveInfinity(TSelf)" />
    public static bool IsPositiveInfinity(ComplexF value)
    {
        // since ComplexF numbers do not have a well-defined concept of
        // positive we report false if this value has an imaginary part

        return (value._imaginary == 0.0) && float.IsPositiveInfinity(value._real);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.IsRealNumber(TSelf)" />
    public static bool IsRealNumber(ComplexF value) => (value._imaginary == 0.0) && float.IsRealNumber(value._real);

    /// <inheritdoc cref="INumberBase{TSelf}.IsSubnormal(TSelf)" />
    public static bool IsSubnormal(ComplexF value)
    {
        // much as IsInfinite allows either part to be infinite, we allow either
        // part to be "subnormal" (finite, non-zero, and non-normal) to be true

        return float.IsSubnormal(value._real) || float.IsSubnormal(value._imaginary);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.IsZero(TSelf)" />
    static bool INumberBase<ComplexF>.IsZero(ComplexF value) => (value._real == 0.0) && (value._imaginary == 0.0);

    /// <inheritdoc cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)" />
    public static ComplexF MaxMagnitude(ComplexF x, ComplexF y)
    {
        // ComplexF numbers are not normally comparable, however every complex
        // number has a real magnitude (absolute value) and so we can provide
        // an implementation for MaxMagnitude

        // This matches the IEEE 754:2019 `maximumMagnitude` function
        //
        // It propagates NaN inputs back to the caller and
        // otherwise returns the input with a larger magnitude.
        // It treats +0 as larger than -0 as per the specification.

        var ax = Abs(x);
        var ay = Abs(y);

        if ((ax > ay) || float.IsNaN(ax))
        {
            return x;
        }

        if (ax == ay)
        {
            // We have two equal magnitudes which means we have two of the following
            //   `+a + ib`
            //   `-a + ib`
            //   `+a - ib`
            //   `-a - ib`
            //
            // We want to treat `+a + ib` as greater than everything and `-a - ib` as
            // lesser. For `-a + ib` and `+a - ib` its "ambiguous" which should be preferred
            // so we will just preference `+a - ib` since that's the most correct choice
            // in the face of something like `+a - i0.0` vs `-a + i0.0`. This is the "most
            // correct" choice because both represent real numbers and `+a` is preferred
            // over `-a`.

            if (float.IsNegative(y._real))
            {
                if (float.IsNegative(y._imaginary))
                {
                    // when `y` is `-a - ib` we always prefer `x` (its either the same as
                    // `x` or some part of `x` is positive).

                    return x;
                }
                else
                {
                    if (float.IsNegative(x._real))
                    {
                        // when `y` is `-a + ib` and `x` is `-a + ib` or `-a - ib` then
                        // we either have same value or both parts of `x` are negative
                        // and we want to prefer `y`.

                        return y;
                    }
                    else
                    {
                        // when `y` is `-a + ib` and `x` is `+a + ib` or `+a - ib` then
                        // we want to prefer `x` because either both parts are positive
                        // or we want to prefer `+a - ib` due to how it handles when `x`
                        // represents a real number.

                        return x;
                    }
                }
            }
            else if (float.IsNegative(y._imaginary))
            {
                if (float.IsNegative(x._real))
                {
                    // when `y` is `+a - ib` and `x` is `-a + ib` or `-a - ib` then
                    // we either both parts of `x` are negative or we want to prefer
                    // `+a - ib` due to how it handles when `y` represents a real number.

                    return y;
                }
                else
                {
                    // when `y` is `+a - ib` and `x` is `+a + ib` or `+a - ib` then
                    // we want to prefer `x` because either both parts are positive
                    // or they represent the same value.

                    return x;
                }
            }
        }

        return y;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)" />
    static ComplexF INumberBase<ComplexF>.MaxMagnitudeNumber(ComplexF x, ComplexF y)
    {
        // ComplexF numbers are not normally comparable, however every complex
        // number has a real magnitude (absolute value) and so we can provide
        // an implementation for MaxMagnitudeNumber

        // This matches the IEEE 754:2019 `maximumMagnitudeNumber` function
        //
        // It does not propagate NaN inputs back to the caller and
        // otherwise returns the input with a larger magnitude.
        // It treats +0 as larger than -0 as per the specification.

        var ax = Abs(x);
        var ay = Abs(y);

        if ((ax > ay) || float.IsNaN(ay))
        {
            return x;
        }

        if (ax == ay)
        {
            // We have two equal magnitudes which means we have two of the following
            //   `+a + ib`
            //   `-a + ib`
            //   `+a - ib`
            //   `-a - ib`
            //
            // We want to treat `+a + ib` as greater than everything and `-a - ib` as
            // lesser. For `-a + ib` and `+a - ib` its "ambiguous" which should be preferred
            // so we will just preference `+a - ib` since that's the most correct choice
            // in the face of something like `+a - i0.0` vs `-a + i0.0`. This is the "most
            // correct" choice because both represent real numbers and `+a` is preferred
            // over `-a`.

            if (float.IsNegative(y._real))
            {
                if (float.IsNegative(y._imaginary))
                {
                    // when `y` is `-a - ib` we always prefer `x` (its either the same as
                    // `x` or some part of `x` is positive).

                    return x;
                }
                else
                {
                    if (float.IsNegative(x._real))
                    {
                        // when `y` is `-a + ib` and `x` is `-a + ib` or `-a - ib` then
                        // we either have same value or both parts of `x` are negative
                        // and we want to prefer `y`.

                        return y;
                    }
                    else
                    {
                        // when `y` is `-a + ib` and `x` is `+a + ib` or `+a - ib` then
                        // we want to prefer `x` because either both parts are positive
                        // or we want to prefer `+a - ib` due to how it handles when `x`
                        // represents a real number.

                        return x;
                    }
                }
            }
            else if (float.IsNegative(y._imaginary))
            {
                if (float.IsNegative(x._real))
                {
                    // when `y` is `+a - ib` and `x` is `-a + ib` or `-a - ib` then
                    // we either both parts of `x` are negative or we want to prefer
                    // `+a - ib` due to how it handles when `y` represents a real number.

                    return y;
                }
                else
                {
                    // when `y` is `+a - ib` and `x` is `+a + ib` or `+a - ib` then
                    // we want to prefer `x` because either both parts are positive
                    // or they represent the same value.

                    return x;
                }
            }
        }

        return y;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)" />
    public static ComplexF MinMagnitude(ComplexF x, ComplexF y)
    {
        // ComplexF numbers are not normally comparable, however every complex
        // number has a real magnitude (absolute value) and so we can provide
        // an implementation for MaxMagnitude

        // This matches the IEEE 754:2019 `minimumMagnitude` function
        //
        // It propagates NaN inputs back to the caller and
        // otherwise returns the input with a smaller magnitude.
        // It treats -0 as smaller than +0 as per the specification.

        var ax = Abs(x);
        var ay = Abs(y);

        if ((ax < ay) || float.IsNaN(ax))
        {
            return x;
        }

        if (ax == ay)
        {
            // We have two equal magnitudes which means we have two of the following
            //   `+a + ib`
            //   `-a + ib`
            //   `+a - ib`
            //   `-a - ib`
            //
            // We want to treat `+a + ib` as greater than everything and `-a - ib` as
            // lesser. For `-a + ib` and `+a - ib` its "ambiguous" which should be preferred
            // so we will just preference `-a + ib` since that's the most correct choice
            // in the face of something like `+a - i0.0` vs `-a + i0.0`. This is the "most
            // correct" choice because both represent real numbers and `-a` is preferred
            // over `+a`.

            if (float.IsNegative(y._real))
            {
                if (float.IsNegative(y._imaginary))
                {
                    // when `y` is `-a - ib` we always prefer `y` as both parts are negative
                    return y;
                }
                else
                {
                    if (float.IsNegative(x._real))
                    {
                        // when `y` is `-a + ib` and `x` is `-a + ib` or `-a - ib` then
                        // we either have same value or both parts of `x` are negative
                        // and we want to prefer it.

                        return x;
                    }
                    else
                    {
                        // when `y` is `-a + ib` and `x` is `+a + ib` or `+a - ib` then
                        // we want to prefer `y` because either both parts of 'x' are positive
                        // or we want to prefer `-a - ib` due to how it handles when `y`
                        // represents a real number.

                        return y;
                    }
                }
            }
            else if (float.IsNegative(y._imaginary))
            {
                if (float.IsNegative(x._real))
                {
                    // when `y` is `+a - ib` and `x` is `-a + ib` or `-a - ib` then
                    // either both parts of `x` are negative or we want to prefer
                    // `-a - ib` due to how it handles when `x` represents a real number.

                    return x;
                }
                else
                {
                    // when `y` is `+a - ib` and `x` is `+a + ib` or `+a - ib` then
                    // we want to prefer `y` because either both parts of x are positive
                    // or they represent the same value.

                    return y;
                }
            }
            else
            {
                return x;
            }
        }

        return y;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)" />
    static ComplexF INumberBase<ComplexF>.MinMagnitudeNumber(ComplexF x, ComplexF y)
    {
        // ComplexF numbers are not normally comparable, however every complex
        // number has a real magnitude (absolute value) and so we can provide
        // an implementation for MinMagnitudeNumber

        // This matches the IEEE 754:2019 `minimumMagnitudeNumber` function
        //
        // It does not propagate NaN inputs back to the caller and
        // otherwise returns the input with a smaller magnitude.
        // It treats -0 as smaller than +0 as per the specification.

        var ax = Abs(x);
        var ay = Abs(y);

        if ((ax < ay) || float.IsNaN(ay))
        {
            return x;
        }

        if (ax == ay)
        {
            // We have two equal magnitudes which means we have two of the following
            //   `+a + ib`
            //   `-a + ib`
            //   `+a - ib`
            //   `-a - ib`
            //
            // We want to treat `+a + ib` as greater than everything and `-a - ib` as
            // lesser. For `-a + ib` and `+a - ib` its "ambiguous" which should be preferred
            // so we will just preference `-a + ib` since that's the most correct choice
            // in the face of something like `+a - i0.0` vs `-a + i0.0`. This is the "most
            // correct" choice because both represent real numbers and `-a` is preferred
            // over `+a`.

            if (float.IsNegative(y._real))
            {
                if (float.IsNegative(y._imaginary))
                {
                    // when `y` is `-a - ib` we always prefer `y` as both parts are negative
                    return y;
                }
                else
                {
                    if (float.IsNegative(x._real))
                    {
                        // when `y` is `-a + ib` and `x` is `-a + ib` or `-a - ib` then
                        // we either have same value or both parts of `x` are negative
                        // and we want to prefer it.

                        return x;
                    }
                    else
                    {
                        // when `y` is `-a + ib` and `x` is `+a + ib` or `+a - ib` then
                        // we want to prefer `y` because either both parts of 'x' are positive
                        // or we want to prefer `-a - ib` due to how it handles when `y`
                        // represents a real number.

                        return y;
                    }
                }
            }
            else if (float.IsNegative(y._imaginary))
            {
                if (float.IsNegative(x._real))
                {
                    // when `y` is `+a - ib` and `x` is `-a + ib` or `-a - ib` then
                    // either both parts of `x` are negative or we want to prefer
                    // `-a - ib` due to how it handles when `x` represents a real number.

                    return x;
                }
                else
                {
                    // when `y` is `+a - ib` and `x` is `+a + ib` or `+a - ib` then
                    // we want to prefer `y` because either both parts of x are positive
                    // or they represent the same value.

                    return y;
                }
            }
            else
            {
                return x;
            }
        }

        return y;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)" />
    static ComplexF INumberBase<ComplexF>.MultiplyAddEstimate(ComplexF left, ComplexF right, ComplexF addend)
    {
        // Multiplication:  (a + bi)(c + di) = (ac - bd) + (bc + ad)i
        // Addition:        (a + bi) + (c + di) = (a + c) + (b + d)i

        var result_realpart = addend._real;
        result_realpart = float.MultiplyAddEstimate(-left._imaginary, right._imaginary, result_realpart);
        result_realpart = float.MultiplyAddEstimate(left._real, right._real, result_realpart);

        var result_imaginarypart = addend._imaginary;
        result_imaginarypart = float.MultiplyAddEstimate(left._real, right._imaginary, result_imaginarypart);
        result_imaginarypart = float.MultiplyAddEstimate(left._imaginary, right._real, result_imaginarypart);

        return new ComplexF(result_realpart, result_imaginarypart);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.Parse(ReadOnlySpan{char}, NumberStyles, IFormatProvider?)" />
    public static ComplexF Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
    {
        if (!TryParse(s, style, provider, out var result))
        {
            throw new OverflowException();
        }
        return result;
    }

    /// <inheritdoc cref="INumberBase{TSelf}.Parse(string, NumberStyles, IFormatProvider?)" />
    public static ComplexF Parse(string s, NumberStyles style, IFormatProvider? provider)
    {
        ArgumentNullException.ThrowIfNull(s);
        return Parse(s.AsSpan(), style, provider);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromChecked{TOther}(TOther, out TSelf)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<ComplexF>.TryConvertFromChecked<TOther>(TOther value, out ComplexF result)
    {
        return TryConvertFrom<TOther>(value, out result);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromSaturating{TOther}(TOther, out TSelf)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<ComplexF>.TryConvertFromSaturating<TOther>(TOther value, out ComplexF result)
    {
        return TryConvertFrom<TOther>(value, out result);
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromTruncating{TOther}(TOther, out TSelf)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<ComplexF>.TryConvertFromTruncating<TOther>(TOther value, out ComplexF result)
    {
        return TryConvertFrom<TOther>(value, out result);
    }

    private static bool TryConvertFrom<TOther>(TOther value, out ComplexF result)
        where TOther : INumberBase<TOther>
    {
        // We don't want to defer to `float.Create*(value)` because some type might have its own
        // `TOther.ConvertTo*(value, out ComplexF result)` handling that would end up bypassed.

        if (typeof(TOther) == typeof(byte))
        {
            var actualValue = (byte)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(char))
        {
            var actualValue = (char)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(decimal))
        {
            var actualValue = (decimal)(object)value;
            result = (ComplexF)actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualValue = (float)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(Half))
        {
            var actualValue = (Half)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(short))
        {
            var actualValue = (short)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(int))
        {
            var actualValue = (int)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(long))
        {
            var actualValue = (long)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(Int128))
        {
            var actualValue = (Int128)(object)value;
            result = (ComplexF)actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(nint))
        {
            var actualValue = (nint)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(sbyte))
        {
            var actualValue = (sbyte)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualValue = (float)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(ushort))
        {
            var actualValue = (ushort)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(uint))
        {
            var actualValue = (uint)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(ulong))
        {
            var actualValue = (ulong)(object)value;
            result = actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(UInt128))
        {
            var actualValue = (UInt128)(object)value;
            result = (ComplexF)actualValue;
            return true;
        }
        else if (typeof(TOther) == typeof(nuint))
        {
            var actualValue = (nuint)(object)value;
            result = actualValue;
            return true;
        }
        else
        {
            result = default;
            return false;
        }
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToChecked{TOther}(TSelf, out TOther)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<ComplexF>.TryConvertToChecked<TOther>(ComplexF value, [MaybeNullWhen(false)] out TOther result)
    {
        // ComplexF numbers with an imaginary part can't be represented as a "real number"
        // so we'll throw an OverflowException for this scenario for integer types and
        // for decimal. However, we will convert it to NaN for the floating-point types,
        // since that's what Sqrt(-1) (which is `new ComplexF(0, 1)`) results in.

        if (typeof(TOther) == typeof(byte))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((byte)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(char))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((char)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(decimal))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((decimal)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualResult = (value._imaginary != 0) ? float.NaN : value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(Half))
        {
            var actualResult = (value._imaginary != 0) ? Half.NaN : (Half)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(short))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((short)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(int))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((int)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(long))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((long)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(Int128))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((Int128)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(nint))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((nint)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(BigInteger))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((BigInteger)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(sbyte))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((sbyte)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualResult = (value._imaginary != 0) ? float.NaN : (float)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(ushort))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((ushort)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(uint))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((uint)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(ulong))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((ulong)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(UInt128))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((UInt128)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(nuint))
        {
            if (value._imaginary != 0)
            {
                throw new OverflowException();
            }

            var actualResult = checked((nuint)value._real);
            result = (TOther)(object)actualResult;
            return true;
        }
        else
        {
            result = default;
            return false;
        }
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToSaturating{TOther}(TSelf, out TOther)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<ComplexF>.TryConvertToSaturating<TOther>(ComplexF value, [MaybeNullWhen(false)] out TOther result)
    {
        // ComplexF numbers with an imaginary part can't be represented as a "real number"
        // and there isn't really a well-defined way to "saturate" to just a real value.
        //
        // The two potential options are that we either treat ComplexF numbers with a non-
        // zero imaginary part as NaN and then convert that to 0 -or- we ignore the imaginary
        // part and only consider the real part.
        //
        // We use the latter below since that is "more useful" given an unknown number type.
        // Users who want 0 instead can always check `IsComplexNumber` and special-case the
        // handling.

        if (typeof(TOther) == typeof(byte))
        {
            var actualResult = (value._real >= byte.MaxValue) ? byte.MaxValue :
                                (value._real <= byte.MinValue) ? byte.MinValue : (byte)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(char))
        {
            var actualResult = (value._real >= char.MaxValue) ? char.MaxValue :
                                (value._real <= char.MinValue) ? char.MinValue : (char)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(decimal))
        {
            var actualResult = (value._real >= (float)decimal.MaxValue) ? decimal.MaxValue :
                                   (value._real <= (float)decimal.MinValue) ? decimal.MinValue : (decimal)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualResult = value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(Half))
        {
            var actualResult = (Half)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(short))
        {
            var actualResult = (value._real >= short.MaxValue) ? short.MaxValue :
                                 (value._real <= short.MinValue) ? short.MinValue : (short)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(int))
        {
            var actualResult = (value._real >= int.MaxValue) ? int.MaxValue :
                               (value._real <= int.MinValue) ? int.MinValue : (int)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(long))
        {
            var actualResult = (value._real >= long.MaxValue) ? long.MaxValue :
                                (value._real <= long.MinValue) ? long.MinValue : (long)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(Int128))
        {
            var actualResult = (value._real >= +170141183460469231731687303715884105727.0) ? Int128.MaxValue :
                                  (value._real <= -170141183460469231731687303715884105728.0) ? Int128.MinValue : (Int128)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(nint))
        {
            var actualResult = (value._real >= nint.MaxValue) ? nint.MaxValue :
                                (value._real <= nint.MinValue) ? nint.MinValue : (nint)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(BigInteger))
        {
            var actualResult = (BigInteger)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(sbyte))
        {
            var actualResult = (value._real >= sbyte.MaxValue) ? sbyte.MaxValue :
                                 (value._real <= sbyte.MinValue) ? sbyte.MinValue : (sbyte)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualResult = (float)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(ushort))
        {
            var actualResult = (value._real >= ushort.MaxValue) ? ushort.MaxValue :
                                  (value._real <= ushort.MinValue) ? ushort.MinValue : (ushort)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(uint))
        {
            var actualResult = (value._real >= uint.MaxValue) ? uint.MaxValue :
                                (value._real <= uint.MinValue) ? uint.MinValue : (uint)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(ulong))
        {
            var actualResult = (value._real >= ulong.MaxValue) ? ulong.MaxValue :
                                 (value._real <= ulong.MinValue) ? ulong.MinValue : (ulong)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(UInt128))
        {
            var actualResult = (value._real >= 340282366920938463463374607431768211455.0) ? UInt128.MaxValue :
                                   (value._real <= 0.0) ? UInt128.MinValue : (UInt128)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(nuint))
        {
            var actualResult = (value._real >= nuint.MaxValue) ? nuint.MaxValue :
                                 (value._real <= nuint.MinValue) ? nuint.MinValue : (nuint)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else
        {
            result = default;
            return false;
        }
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToTruncating{TOther}(TSelf, out TOther)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool INumberBase<ComplexF>.TryConvertToTruncating<TOther>(ComplexF value, [MaybeNullWhen(false)] out TOther result)
    {
        // ComplexF numbers with an imaginary part can't be represented as a "real number"
        // so we'll only consider the real part for the purposes of truncation.

        if (typeof(TOther) == typeof(byte))
        {
            var actualResult = (value._real >= byte.MaxValue) ? byte.MaxValue :
                                (value._real <= byte.MinValue) ? byte.MinValue : (byte)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(char))
        {
            var actualResult = (value._real >= char.MaxValue) ? char.MaxValue :
                                (value._real <= char.MinValue) ? char.MinValue : (char)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(decimal))
        {
            var actualResult = (value._real >= (float)decimal.MaxValue) ? decimal.MaxValue :
                                   (value._real <= (float)decimal.MinValue) ? decimal.MinValue : (decimal)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualResult = value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(Half))
        {
            var actualResult = (Half)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(short))
        {
            var actualResult = (value._real >= short.MaxValue) ? short.MaxValue :
                                 (value._real <= short.MinValue) ? short.MinValue : (short)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(int))
        {
            var actualResult = (value._real >= int.MaxValue) ? int.MaxValue :
                               (value._real <= int.MinValue) ? int.MinValue : (int)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(long))
        {
            var actualResult = (value._real >= long.MaxValue) ? long.MaxValue :
                                (value._real <= long.MinValue) ? long.MinValue : (long)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(Int128))
        {
            var actualResult = (value._real >= +170141183460469231731687303715884105727.0) ? Int128.MaxValue :
                                  (value._real <= -170141183460469231731687303715884105728.0) ? Int128.MinValue : (Int128)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(nint))
        {
            var actualResult = (value._real >= nint.MaxValue) ? nint.MaxValue :
                                (value._real <= nint.MinValue) ? nint.MinValue : (nint)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(BigInteger))
        {
            var actualResult = (BigInteger)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(sbyte))
        {
            var actualResult = (value._real >= sbyte.MaxValue) ? sbyte.MaxValue :
                                 (value._real <= sbyte.MinValue) ? sbyte.MinValue : (sbyte)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(float))
        {
            var actualResult = (float)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(ushort))
        {
            var actualResult = (value._real >= ushort.MaxValue) ? ushort.MaxValue :
                                  (value._real <= ushort.MinValue) ? ushort.MinValue : (ushort)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(uint))
        {
            var actualResult = (value._real >= uint.MaxValue) ? uint.MaxValue :
                                (value._real <= uint.MinValue) ? uint.MinValue : (uint)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(ulong))
        {
            var actualResult = (value._real >= ulong.MaxValue) ? ulong.MaxValue :
                                 (value._real <= ulong.MinValue) ? ulong.MinValue : (ulong)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(UInt128))
        {
            var actualResult = (value._real >= 340282366920938463463374607431768211455.0) ? UInt128.MaxValue :
                                   (value._real <= 0.0) ? UInt128.MinValue : (UInt128)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else if (typeof(TOther) == typeof(nuint))
        {
            var actualResult = (value._real >= nuint.MaxValue) ? nuint.MaxValue :
                                 (value._real <= nuint.MinValue) ? nuint.MinValue : (nuint)value._real;
            result = (TOther)(object)actualResult;
            return true;
        }
        else
        {
            result = default;
            return false;
        }
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryParse(ReadOnlySpan{char}, NumberStyles, IFormatProvider?, out TSelf)" />
    public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out ComplexF result)
    {
        ValidateParseStyleFloatingPoint(style);

        var openBracket = s.IndexOf('<');
        var semicolon = s.IndexOf(';');
        var closeBracket = s.IndexOf('>');

        if ((s.Length < 5) || (openBracket == -1) || (semicolon == -1) || (closeBracket == -1) || (openBracket > semicolon) || (openBracket > closeBracket) || (semicolon > closeBracket))
        {
            // We need at least 5 characters for `<0;0>`
            // We also expect a to find an open bracket, a semicolon, and a closing bracket in that order

            result = default;
            return false;
        }

        if ((openBracket != 0) && (((style & NumberStyles.AllowLeadingWhite) == 0) || !s.Slice(0, openBracket).IsWhiteSpace()))
        {
            // The opening bracket wasn't the first and we either didn't allow leading whitespace
            // or one of the leading characters wasn't whitespace at all.

            result = default;
            return false;
        }

        if (!float.TryParse(s.Slice(openBracket + 1, semicolon - openBracket - 1), style, provider, out var real))
        {
            result = default;
            return false;
        }

        if (char.IsWhiteSpace(s[semicolon + 1]))
        {
            // We allow a single whitespace after the semicolon regardless of style, this is so that
            // the output of `ToString` can be correctly parsed by default and values will roundtrip.
            semicolon += 1;
        }

        if (!float.TryParse(s.Slice(semicolon + 1, closeBracket - semicolon - 1), style, provider, out var imaginary))
        {
            result = default;
            return false;
        }

        if ((closeBracket != (s.Length - 1)) && (((style & NumberStyles.AllowTrailingWhite) == 0) || !s.Slice(closeBracket).IsWhiteSpace()))
        {
            // The closing bracket wasn't the last and we either didn't allow trailing whitespace
            // or one of the trailing characters wasn't whitespace at all.

            result = default;
            return false;
        }

        result = new ComplexF(real, imaginary);
        return true;

        static void ValidateParseStyleFloatingPoint(NumberStyles style)
        {
            // Check for undefined flags or hex number
            if ((style & (InvalidNumberStyles | NumberStyles.AllowHexSpecifier)) != 0)
            {
                ThrowInvalid(style);

                static void ThrowInvalid(NumberStyles value)
                {
                    if ((value & InvalidNumberStyles) != 0)
                    {
                        throw new ArgumentException("Invalid Number Styles", nameof(style));
                    }

                    throw new ArgumentException("Hex Style Not Supported");
                }
            }
        }
    }

    /// <inheritdoc cref="INumberBase{TSelf}.TryParse(string, NumberStyles, IFormatProvider?, out TSelf)" />
    public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, out ComplexF result)
    {
        if (s is null)
        {
            result = default;
            return false;
        }
        return TryParse(s.AsSpan(), style, provider, out result);
    }

    //
    // IParsable
    //

    /// <inheritdoc cref="IParsable{TSelf}.Parse(string, IFormatProvider?)" />
    public static ComplexF Parse(string s, IFormatProvider? provider) => Parse(s, DefaultNumberStyle, provider);

    /// <inheritdoc cref="IParsable{TSelf}.TryParse(string?, IFormatProvider?, out TSelf)" />
    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, out ComplexF result) => TryParse(s, DefaultNumberStyle, provider, out result);

    //
    // ISignedNumber
    //

    /// <inheritdoc cref="ISignedNumber{TSelf}.NegativeOne" />
    static ComplexF ISignedNumber<ComplexF>.NegativeOne => new((float)-1.0, 0.0f);

    public static ComplexF NegativeOne => throw new NotImplementedException();

    //static ComplexF INumberBase<ComplexF>.One => throw new NotImplementedException();

    public static int Radix => throw new NotImplementedException();

    //static ComplexF INumberBase<ComplexF>.Zero => throw new NotImplementedException();

    public static ComplexF AdditiveIdentity => throw new NotImplementedException();

    public static ComplexF MultiplicativeIdentity => throw new NotImplementedException();

    //
    // ISpanFormattable
    //

    /// <inheritdoc cref="ISpanFormattable.TryFormat(Span{char}, out int, ReadOnlySpan{char}, IFormatProvider?)" />
    public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax(StringSyntaxAttribute.NumericFormat)] ReadOnlySpan<char> format = default, IFormatProvider? provider = null) =>
        TryFormatCore(destination, out charsWritten, format, provider);

    /// <inheritdoc cref="IUtf8SpanFormattable.TryFormat(Span{byte}, out int, ReadOnlySpan{char}, IFormatProvider?)" />
    public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax(StringSyntaxAttribute.NumericFormat)] ReadOnlySpan<char> format = default, IFormatProvider? provider = null) =>
        TryFormatCore(utf8Destination, out bytesWritten, format, provider);

    private bool TryFormatCore<TChar>(Span<TChar> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) where TChar : unmanaged, IBinaryInteger<TChar>
    {
        Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

        // We have at least 6 more characters for: <0; 0>
        if (destination.Length >= 6)
        {
            int realChars;
            if (typeof(TChar) == typeof(char) ?
                _real.TryFormat(Unsafe.BitCast<Span<TChar>, Span<char>>(destination.Slice(1)), out realChars, format, provider) :
                _real.TryFormat(Unsafe.BitCast<Span<TChar>, Span<byte>>(destination.Slice(1)), out realChars, format, provider))
            {
                destination[0] = TChar.CreateTruncating('<');
                destination = destination.Slice(1 + realChars); // + 1 for <

                // We have at least 4 more characters for: ; 0>
                if (destination.Length >= 4)
                {
                    int imaginaryChars;
                    if (typeof(TChar) == typeof(char) ?
                        _imaginary.TryFormat(Unsafe.BitCast<Span<TChar>, Span<char>>(destination.Slice(2)), out imaginaryChars, format, provider) :
                        _imaginary.TryFormat(Unsafe.BitCast<Span<TChar>, Span<byte>>(destination.Slice(2)), out imaginaryChars, format, provider))
                    {
                        // We have 1 more character for: >
                        if ((uint)(2 + imaginaryChars) < (uint)destination.Length)
                        {
                            destination[0] = TChar.CreateTruncating(';');
                            destination[1] = TChar.CreateTruncating(' ');
                            destination[2 + imaginaryChars] = TChar.CreateTruncating('>');

                            charsWritten = realChars + imaginaryChars + 4;
                            return true;
                        }
                    }
                }
            }
        }

        charsWritten = 0;
        return false;
    }

    //
    // ISpanParsable
    //

    /// <inheritdoc cref="ISpanParsable{TSelf}.Parse(ReadOnlySpan{char}, IFormatProvider?)" />
    public static ComplexF Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => Parse(s, DefaultNumberStyle, provider);

    /// <inheritdoc cref="ISpanParsable{TSelf}.TryParse(ReadOnlySpan{char}, IFormatProvider?, out TSelf)" />
    public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out ComplexF result) => TryParse(s, DefaultNumberStyle, provider, out result);

    //static ComplexF INumberBase<ComplexF>.Abs(ComplexF value)
    //{
    //    throw new NotImplementedException();
    //}

    public static bool IsCanonical(ComplexF value)
    {
        throw new NotImplementedException();
    }

    public static bool IsZero(ComplexF value)
    {
        throw new NotImplementedException();
    }

    public static ComplexF MaxMagnitudeNumber(ComplexF x, ComplexF y)
    {
        throw new NotImplementedException();
    }

    public static ComplexF MinMagnitudeNumber(ComplexF x, ComplexF y)
    {
        throw new NotImplementedException();
    }

    public static bool TryConvertFromChecked<TOther>(TOther value, [MaybeNullWhen(false)] out ComplexF result) where TOther : INumberBase<TOther>
    {
        throw new NotImplementedException();
    }

    public static bool TryConvertFromSaturating<TOther>(TOther value, [MaybeNullWhen(false)] out ComplexF result) where TOther : INumberBase<TOther>
    {
        throw new NotImplementedException();
    }

    public static bool TryConvertFromTruncating<TOther>(TOther value, [MaybeNullWhen(false)] out ComplexF result) where TOther : INumberBase<TOther>
    {
        throw new NotImplementedException();
    }

    public static bool TryConvertToChecked<TOther>(ComplexF value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
    {
        throw new NotImplementedException();
    }

    public static bool TryConvertToSaturating<TOther>(ComplexF value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
    {
        throw new NotImplementedException();
    }

    public static bool TryConvertToTruncating<TOther>(ComplexF value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
    {
        throw new NotImplementedException();
    }

    //
    // IUnaryPlusOperators
    //

    /// <inheritdoc cref="IUnaryPlusOperators{TSelf, TResult}.op_UnaryPlus(TSelf)" />
    public static ComplexF operator +(ComplexF value) => value;
}
