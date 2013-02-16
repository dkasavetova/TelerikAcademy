using System;
using System.Numerics;

class FactorialTrailingZeros
{
    static void Main()
    {
        int n = 15000;
        Console.WriteLine("N = " + n);
        BigInteger fact = 1;
        BigInteger trailingZerosCount = 0;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine("N! = "  + fact);

        BigInteger m = n;
        BigInteger q = 0;
        do
        {
            q = m / 5;
            trailingZerosCount += q;
            m = q;

        } while (q != 0);

        Console.WriteLine(trailingZerosCount);
    }
}

