using System;

class FindItemCount
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 3, 5, 3, 6, 3 };
        Console.WriteLine(Count(a, 34));
    }

    static int Count(int[] arr, int key)
    {
        int count = 0;
        foreach (var number in arr)
        {
            if (number == key)
            {
                count++;
            }
        }
        return count;
    }
}

