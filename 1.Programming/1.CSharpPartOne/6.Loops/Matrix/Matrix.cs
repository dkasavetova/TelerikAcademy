using System;

class Matrix
{
    static void Main()
    {
        int n = 3;

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write(row + col - 1 + " ");
            }
            Console.WriteLine();
        }
    }
}

