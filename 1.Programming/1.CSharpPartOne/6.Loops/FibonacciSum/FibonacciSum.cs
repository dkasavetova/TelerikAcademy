using System;

class FibonacciSum
{
    static void Main()
    {
        int n = 50;

        decimal prev = 0M;
        decimal current = 1M;

        decimal sum = prev + current;

        checked
        {
            for (int i = 3; i <= n; i++)
            {
                decimal next = current + prev;
                sum += next;
                prev = current;
                current = next;
            }
        }

        Console.WriteLine(sum);
    }
}

