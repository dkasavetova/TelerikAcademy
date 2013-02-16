using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class StringLenghtSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Array.Sort(arr, new LengthComparer());

        foreach (var str in arr)
        {
            Console.WriteLine(str);
        }
    }
}

class LengthComparer : IComparer<string>
{
    public int Compare(string a, string b)
    {
        if (a.Length < b.Length)
        {
            return -1;
        }
        if (a.Length == b.Length)
        {
            return 0;
        }
        return 1;
    }
}

