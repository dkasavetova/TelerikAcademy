using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PolynomialSubstractionMultiplication
{
    static void Main()
    {            
        int[] a = { 1, -2, 1 };
        int[] b = { 0,  5, 4, 3 };

        int[] c = PolynomialMul(a, b);
        PrintPolynomial(c);

        c = PolynomialSub(a, b);
        PrintPolynomial(c);
    }

    static void PrintPolynomial(int[] a)
    {
        for (int i = a.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}x^{1} ", a[i], i);
            if (i != 0)
            {
                Console.Write("+ ");
            }
        }
        Console.WriteLine();
    }

    static int[] PolynomialSub(int[] a, int[] b)
    {
        int minN = Math.Min(a.Length, b.Length);
        int maxN = Math.Max(a.Length, b.Length);
        int[] c = new int[maxN];

        //common lenght
        for (int i = 0; i < minN; i++)
        {
            c[i] = a[i] - b[i];
        }
        //only the longer
        if (a.Length <= minN)
        {
            for (int i = minN; i < maxN; i++)
            {
                c[i] = -b[i];
            }
        }
        else
        {
            for (int i = minN; i < maxN; i++)
            {
                c[i] = a[i];
            }
        }
        return c;
    }

    static int[] PolynomialMul(int[] a, int[] b)
    {
        int[] c = new int[a.Length + b.Length];

        for (int i = 0; i < a.Length; i++)
        {

            for (int j = 0; j < b.Length; j++)
            {
                c[i + j] += a[i] * b[j];
            }
        }
        return c;
    }
}

