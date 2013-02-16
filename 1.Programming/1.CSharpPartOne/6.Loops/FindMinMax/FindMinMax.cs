using System;

class FindMinMax
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine("Enter {0} numbers: ", n);

        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (max < current)
            {
                max = current;
            }
            if (min > current)
            {
                min = current;
            }
        }

        Console.WriteLine("Max = {0}; Min = {1};", max, min);
    }
}

