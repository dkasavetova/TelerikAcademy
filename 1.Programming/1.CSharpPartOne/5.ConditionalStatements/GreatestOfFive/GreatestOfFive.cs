using System;

class GreatestOfFive
{
    static void Main()
    {
        int a = 6;
        int b = 2;
        int c = -1;
        int d = 42;
        int e = 5;
        int max = int.MinValue;

        if (max < a)
        {
            max = a;
        }
        if (max < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        if (max < d)
        {
            max = d;
        }
        if (max < e)
        {
            max = e;
        }

        Console.WriteLine(max);

    }
}

