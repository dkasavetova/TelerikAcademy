using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PolynomialAddition
{
    static void Main()
    {
        int[] a = { 5, 0, 1 };
        int[] b = { 5, 1, 2, 3, 6 };
        int[] c = PolynomialAdd(a, b);
        for (int i = c.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}x^{1} ",c[i], i);
            if (i != 0)
            {
                Console.Write("+ ");
            }
        }
        Console.WriteLine();
    }

    static int[] PolynomialAdd(int[] a, int[] b)
    {
        int minN = Math.Min(a.Length, b.Length);
        int maxN = Math.Max(a.Length, b.Length);
        int[] c = new int[maxN];

        //common lenght
        for (int i = 0; i < minN; i++)
        {
            c[i] = a[i] + b[i];
        }
        //only the longer
        if (a.Length <= minN)
        {
            for (int i = minN; i < maxN; i++)
            {
                c[i] = b[i];
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
}

