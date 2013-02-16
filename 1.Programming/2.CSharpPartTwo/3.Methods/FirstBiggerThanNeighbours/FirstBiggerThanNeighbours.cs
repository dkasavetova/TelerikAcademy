using System;

class FirstBiggerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 2, 88 };
        Console.WriteLine(GetIndexOfFirstBiggerThanNeighbous(a));
    }

    static int GetIndexOfFirstBiggerThanNeighbous(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (IsBiggerThanNeighbours(a, i))
            {
                return i;
            }
        }
        return -1;
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

