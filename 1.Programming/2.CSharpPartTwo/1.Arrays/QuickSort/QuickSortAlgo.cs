using System;

class QuickSortAlgo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        RandomizedQuicksort(arr, 0, arr.Length - 1);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void RandomizedQuicksort(int[] a, int p, int r)
    {
        if (p < r)
        {
            int q = RandomizedPartition(a, p, r);
            RandomizedQuicksort(a, p, q - 1);
            RandomizedQuicksort(a, q + 1, r);
        }
    }

    static int Partition(int[] a, int p, int r)
    {
        int x = a[r];
        int i = p - 1;
        for (int j = p; j < r; j++)
        {
            if (a[j] <= x)
            {
                i++;
                Swap(ref a[i], ref a[j]);
            }
        }
        Swap(ref a[i + 1], ref a[r]);
        return i + 1;
    }

    static int RandomizedPartition(int[] a, int p, int r)
    {
        int i = new Random(Environment.TickCount).Next(p, r + 1);
        Swap(ref a[r], ref a[i]);
        return Partition(a, p, r);
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

