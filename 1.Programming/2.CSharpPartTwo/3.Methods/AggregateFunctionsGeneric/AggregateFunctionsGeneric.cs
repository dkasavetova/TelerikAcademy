using System;

class AggregateFunctionsGeneric
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        Console.WriteLine(Min(a));
        Console.WriteLine(Max(a));
        Console.WriteLine(Sum(a));
        Console.WriteLine(Avg(a));
        Console.WriteLine(Prod(a));
        Console.WriteLine();

        double[] b = { 1.1, 2.2, 3.14, 4.44 };
        Console.WriteLine(Min(b));
        Console.WriteLine(Max(b));
        Console.WriteLine(Sum(b));
        Console.WriteLine(Avg(b));
        Console.WriteLine(Prod(b));
        Console.WriteLine();

        decimal[] c = { 1.1m, 2.2m, 3.14m, 4.44m };
        Console.WriteLine(Min(c));
        Console.WriteLine(Max(c));
        Console.WriteLine(Sum(c));
        Console.WriteLine(Avg(c));
        Console.WriteLine(Prod(c));
        Console.WriteLine();
    }


    static T Min<T>(params T[] elems) where T : IComparable<T>
    {
        T min = elems[0];
        for (int i = 1; i < elems.Length; i++)
        {
            if (elems[i].CompareTo(min) < 0)
            {
                min = elems[i];
            }
        }
        return min;
    }

    static T Max<T>(params T[] elems) where T : IComparable<T>
    {
        T max = elems[0];
        for (int i = 1; i < elems.Length; i++)
        {
            if (elems[i].CompareTo(max) < 1)
            {
                max = elems[i];
            }
        }
        return max;
    }

    static T Sum<T>(params T[] elems)
    {
        dynamic sum = elems[0];
        for (int i = 1; i < elems.Length; i++)
        {
            sum += elems[i];
        }
        return sum;
    }

    static decimal Avg<T>(params T[] elems)
    {
        decimal sumAsDecimal = Convert.ToDecimal(Sum(elems));
        return sumAsDecimal / (decimal)(elems.Length);
    }

    static T Prod<T>(params T[] elems)
    {
        dynamic prod = elems[0];
        for (int i = 1; i < elems.Length; i++)
        {
            prod *= elems[i];
        }
        return prod;
    }
}
