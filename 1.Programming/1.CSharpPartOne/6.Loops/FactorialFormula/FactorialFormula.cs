using System;

class FactorialFormula
{
    static void Main()
    {
        int n = 3;
        int k = 5;

        int result = 1;

        for (int i = k; i > k - n ; i--)
        {
            result *= i;
        }
        for (int i = n; i >= 1; i--)
        {
            result *= i;
        }

        Console.WriteLine(result);

    }
}

