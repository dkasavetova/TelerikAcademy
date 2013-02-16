using System;

class BinarySearchAlgo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        if (BinarySearch(arr, v) > 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static int BinarySearch(int[] a, int key)
    {
        int p = 0;
        int r = a.Length - 1;
        while (p < r)
        {
            int q = p + (r - p) / 2;
            if (key < a[q])
            {
                r = q - 1;
            }
            else if (key > a[q])
            {
                p = q + 1;
            }
            else
            {
                return q;
            }
        }
        return -1;
    }
}

