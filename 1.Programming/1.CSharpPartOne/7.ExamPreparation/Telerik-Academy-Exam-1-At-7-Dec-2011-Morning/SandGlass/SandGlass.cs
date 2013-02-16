using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n/2; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            for (int j = 1; j <= n - 2 * i; j++)
            {
                Console.Write('*');
            } 
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write('.');
            }
            for (int j = n - 2 * i ; j >= 1 ; j--)
            {
                Console.Write('*');
            }
            for (int j = i; j >= 1; j--)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}

