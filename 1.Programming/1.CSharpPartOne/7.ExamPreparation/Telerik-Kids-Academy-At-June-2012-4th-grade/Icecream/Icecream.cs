using System;

class Icecream
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        
        input[1] = input[1].PadRight(n, '0');


        Console.WriteLine(input[0]);
        Console.WriteLine(input[1]);

        int nonZeroCount = 0;
        foreach (char ch in input[1])
        {
            if (ch != '0')
            {
                nonZeroCount++;
            }
        }

        if (nonZeroCount >= n)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(n - nonZeroCount);
        }
    }
}

