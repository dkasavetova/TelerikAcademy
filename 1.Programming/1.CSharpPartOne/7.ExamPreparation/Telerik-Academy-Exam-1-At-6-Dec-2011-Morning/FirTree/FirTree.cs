using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <n; i++)
        {
            for (int j = i; j <= n - 2; j++)
            {
                Console.Write('.');
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write('*');
            } 
            for (int j = i; j <= n - 2; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write('.');
        }
        Console.Write('*');
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write('.');
        }
        Console.WriteLine();
    }
}

