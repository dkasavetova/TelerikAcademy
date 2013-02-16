using System;

class RandomInRange
{
    static void Main(string[] args)
    {
        int lo = 100;
        int hi = 200;
        int n = 10;

        Random rand = new Random(Environment.TickCount);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rand.Next(lo, hi + 1));
        }
    }
}

