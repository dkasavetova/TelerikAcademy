using System;

class SomeSeries
{
    static void Main()
    {
        int x = 2;
        int n = 3;

        decimal sum = 1M;
        int nominator = 1;
        int denominator = 1;

        for (int i = 1; i <= n; i++)
        {
            nominator *= i;
            denominator *= x;
            sum += (nominator / (decimal)denominator);
        }

        Console.WriteLine(sum);
    }
}

