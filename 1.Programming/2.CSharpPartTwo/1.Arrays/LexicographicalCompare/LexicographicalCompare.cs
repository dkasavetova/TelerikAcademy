using System;

class LexicographicalCompare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        char[] arrA = new char[n];
        for (int i = 0; i < n; i++)
        {
            arrA[i] = Console.ReadLine()[0];
        }

        char[] arrB = new char[m];
        for (int i = 0; i < m; i++)
        {
            arrB[i] = Console.ReadLine()[0];
        }

        Console.WriteLine(arrA.CompareTo(arrB));
    }
}

public static class ArrayExtensions
{
    public static int CompareTo(this char[] a, char[] b)
    {
        if (a.Length < b.Length)  
        {
            //The arrays are not equal - A is shorter
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].CompareTo(b[i]) < 0)
                {
                    //A is less than B
                    return -1;
                }
                else if (a[i].CompareTo(b[i]) > 0)
                {
                    //A is greater than B
                    return 1;
                }
            }
            //A is less than B
            //All elements are equal and A is shorter
            return -1;
        }
        else if (a.Length > b.Length)
        {
            //The arrays are not equal - B is shorter
            for (int i = 0; i < b.Length; i++)
            {
                if (a[i].CompareTo(b[i]) < 0)
                {
                    //A is less than B
                    return -1;
                }
                else if (a[i].CompareTo(b[i]) > 0)
                {
                    //A is greater than B
                    return 1;
                }
            }
            //A is greater than B
            //All elements are equal and A is longer
            return 1;
        }
        else
        {
            //The arrays are may be equal - they have the same length
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].CompareTo(b[i]) < 0)
                {
                    //A is less than B
                    return -1;
                }
                else if (a[i].CompareTo(b[i]) > 0)
                {
                    //A is greater than B
                    return 1;
                }
            }
            //A is equal to B
            //All elements are equal
            return 0;
        }
    }
}

