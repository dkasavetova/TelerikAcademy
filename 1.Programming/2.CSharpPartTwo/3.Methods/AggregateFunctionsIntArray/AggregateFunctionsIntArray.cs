using System;

class AggregateFunctionsIntArray
{
    static void Main()
    {
        int[] a = {1, 2, 3, 4 };
        Console.WriteLine(Min(a));
        Console.WriteLine(Max(a));
        Console.WriteLine(Sum(a));
        Console.WriteLine(Avg(a));
        Console.WriteLine(Prod(a));
    }

    static int Min(params int[] elems)
    {
        int min = elems[0];
        for (int i = 1; i < elems.Length; i++)
        {
            if (elems[i] < min)
            {
                min = elems[i];
            }
        }
        return min;
    }

    static int Max(params int[] elems)
    {
        int max = elems[0];
        for (int i = 1; i < elems.Length; i++)
        {
            if (elems[i] > max)
            {
                max = elems[i];
            }
        }
        return max;
    }

    static int Sum(params int[] elems)
    {
        int sum = 0;
        for (int i = 0; i < elems.Length; i++)
        {
            sum += elems[i];
        }
        return sum;
    }

    static double Avg(params int[] elems)
    {
        return Sum(elems) / (double)elems.Length;
    }

    static int Prod(params int[] elems)
    {
        int prod = 1;
        for (int i = 0; i < elems.Length; i++)
        {
            prod *= elems[i];
        }
        return prod;
    }
}

