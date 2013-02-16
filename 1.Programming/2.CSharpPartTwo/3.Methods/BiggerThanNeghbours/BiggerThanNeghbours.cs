using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BiggerThanNeghbours
{
    static void Main()
    {
        int[] a = { 2, 1, 777, 7, 88 };
        Console.WriteLine(IsBiggerThanNeighbours(a, 0));
        Console.WriteLine(IsBiggerThanNeighbours(a, 1));
        Console.WriteLine(IsBiggerThanNeighbours(a, 2));
        Console.WriteLine(IsBiggerThanNeighbours(a, a.Length -1));
        a = new int[] { 5 };
        Console.WriteLine(IsBiggerThanNeighbours(a, 0));
    }

    static bool IsBiggerThanNeighbours(int[] a, int i)
    {
        if (a.Length == 1)
        {
            return true;
        }
        else if (i == 0)
        {
            return (a[i + 1] < a[0]);
        }
        else if (i == a.Length - 1)
        {
            return (a[a.Length - 2] < a[a.Length - 1]);
        }
        else
        {
            return (a[i - 1] < a[i]) && (a[i + 1] < a[i]);
        }
    }
}

