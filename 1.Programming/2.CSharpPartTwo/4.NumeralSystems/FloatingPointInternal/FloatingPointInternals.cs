using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FloatingPointInternals
{
    static void Main()
    {
        double n = -27.25; ;
        float f = (float)n;
        int s = 0, m = 0, e = 0;
        long sl = 0, ml = 0, el = 0;

        FloatInternals(f, ref s, ref m, ref e);
        Console.WriteLine("{0,8} = {1}", "sign", Convert.ToString(s, 2));
        Console.WriteLine("{0,8} = {1}", "exponent", Convert.ToString(e, 2));
        Console.WriteLine("{0,8} = {1}", "mantissa", Convert.ToString(m, 2));
        Console.WriteLine();

        DoubleInternals(n, ref sl, ref ml, ref el);
        Console.WriteLine("{0,8} = {1}", "sign", Convert.ToString(sl, 2));
        Console.WriteLine("{0,8} = {1}", "exponent", Convert.ToString(el, 2));
        Console.WriteLine("{0,8} = {1}", "mantissa", Convert.ToString(ml, 2));
        Console.WriteLine();

    }

    static void DoubleInternals(double d, ref long s, ref long m, ref long e)
    {
        long doubleBits = BitConverter.DoubleToInt64Bits(d);

        int signIndex = 63;
        long signMask = (long)1 << signIndex;
        long sign = doubleBits & signMask;
        sign = (long)((ulong)sign >> signIndex);

        int exponentStartIndex = 52;
        int exponentEndIndex = 62;
        long exponentMask = (((long)1 <<(exponentEndIndex - exponentStartIndex + 1)) - 1) << exponentStartIndex;
        long exponent = doubleBits & exponentMask;
        exponent = (long)((ulong)exponent >> exponentStartIndex);

        int mantissaStartIndex = 0;
        int mantissaEndIndex = 51;
        long mantissaMask = (((long)1 << (mantissaEndIndex - mantissaStartIndex + 1)) - 1);
        long mantissa = doubleBits & mantissaMask;

        s = sign;
        m = mantissa;
        e = exponent;
    }

    static void FloatInternals(float f, ref int s, ref int m, ref int e)
    {
        long floatBits = BitConverter.DoubleToInt64Bits((double)f);

        int signIndex = 63;
        long signMask = (long)1 << signIndex;
        long sign = floatBits & signMask;
        sign = (long)((ulong)sign >> signIndex); ;

        int exponentStartIndex = 52;
        int exponentEndIndex = 62;
        long exponentMask = (((long)1 << (exponentEndIndex - exponentStartIndex + 1)) - 1) << exponentStartIndex;
        long exponent = floatBits & exponentMask;
        int doubleBias = 1023;
        int floatBias = 127;
        exponent = (long)((ulong)exponent >> exponentStartIndex);
        exponent -= (doubleBias - floatBias);

        int mantissaStartIndex = 29;
        int mantissaEndIndex = 51;
        long mantissaMask = (((long)1 << (mantissaEndIndex - mantissaStartIndex + 1)) - 1) << mantissaStartIndex;
        long mantissa = floatBits & mantissaMask;
        mantissa = (long)((ulong)mantissa >> mantissaStartIndex);

        s = (int)sign;
        m = (int)mantissa;
        e = (int)exponent;
    }
}
