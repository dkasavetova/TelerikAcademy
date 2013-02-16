using System;

class NumbersSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int newNumber = int.Parse(Console.ReadLine());
            sum += newNumber;
        }

        Console.WriteLine("sum = {0}", sum);
    }
}

