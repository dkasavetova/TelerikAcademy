using System;

class FactorialFraction
{
    static void Main()
    {
        int n = 5;
        int k = 3;

        int result = 1;
        for (int i = n; i > k; i--)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}

