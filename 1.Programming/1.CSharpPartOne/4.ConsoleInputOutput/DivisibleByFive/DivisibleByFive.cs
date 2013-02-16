using System;

class DivisibleByFive
{
    static void Main()
    {

        int q = 5;

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine((Math.Max(a, b) / q) - (Math.Min(a, b) / q));
    }
}

