using System;

class PrintNumbersNotDivisible
{
    static void Main()
    {
        int n = 10;

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}

