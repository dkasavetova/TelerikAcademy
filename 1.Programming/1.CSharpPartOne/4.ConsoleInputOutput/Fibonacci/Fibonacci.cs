using System;

class Fibonacci
{
    static void Main()
    {
        decimal prev = 0M;
        decimal current = 1M;

        Console.WriteLine("F(1) = {0}", prev);
        Console.WriteLine("F(2) = {0}", current);

        checked
        {
            for (int i = 3; i <= 100; i++)
            {
                decimal next = current + prev;
                Console.WriteLine("F({0}) = {1}", i, next);
                prev = current;
                current = next;
            }
        }
    }
}

