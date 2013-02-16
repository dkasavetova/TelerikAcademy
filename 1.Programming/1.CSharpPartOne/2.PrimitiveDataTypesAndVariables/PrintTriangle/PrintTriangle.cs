using System;
using System.Text;

class PrintTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '\u00A9';
        char empty = ' ';
        //count must be positive integer divisible by 3
        int count = 9;

        for (int i = 0; i < count / 3; i++)
        {
            for (int j = i; j < count / 3; j++)
            {
                Console.Write(empty);
            }
            Console.Write(symbol);
            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write(empty);
            }
            if (i != 0)
            {
                Console.Write(symbol);
            }
            Console.WriteLine(); 
        }
        for (int k = 0; k <= 2 * (count / 3); k++)
        {
            if (k % 2 == 0)
            {
                Console.Write(symbol);
            }
            else
            {
                Console.Write(empty);
            }
        }
        Console.WriteLine(); 
    }
}

