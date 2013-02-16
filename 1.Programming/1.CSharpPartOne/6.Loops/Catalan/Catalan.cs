using System;

class Catalan
{
    static void Main()
    {
        // n = 0, 1, ...
        int n = 10;
        decimal nthCatalan = (decimal)BinomialCoeficient(2 * n, n) / (n + 1);
        Console.WriteLine(nthCatalan);
    }

    public static ulong BinomialCoeficient(int n, int k)
    {
        if (n < k)
        {
            return 0;
        }

        ulong[,] pascalTriangle = new ulong[n + 1, n + 1];

        for (int i = 0; i <= n; i++)
        {
            pascalTriangle[i, 0] = 1;
            pascalTriangle[i, i] = 1;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                pascalTriangle[i, j] = pascalTriangle[i - 1, j - 1] + pascalTriangle[i - 1, j];
            }
        }

        return pascalTriangle[n, k];
    }
}

