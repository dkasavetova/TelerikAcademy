using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = n - 1 - i; j >= 1; j--)
            {
                Console.Write('.');
            }
            Console.Write('*');
            for (int j = 0; j < n - 1 + i; j++)
            {
                Console.Write('.');
            }
            Console.Write('*');
            Console.WriteLine();
        }
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write('*');
        }
    }
}

