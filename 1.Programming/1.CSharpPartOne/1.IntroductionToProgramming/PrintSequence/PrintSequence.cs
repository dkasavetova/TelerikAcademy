using System;

class PrintSequence
{
    static void Main()
    {
        int start = 2;
        int count = 10;
        int end = start + count;

        for (int i = start; i < end; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(-i);
            }
            if (i < end - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

