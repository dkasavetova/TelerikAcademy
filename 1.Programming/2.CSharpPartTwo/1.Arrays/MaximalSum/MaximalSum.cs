using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //Finds the largest k numbers in O(n) :)
        RandomizedQuicksortFirstK(arr, 0, arr.Length - 1, k);

        for (int i = 0; i < k; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static int Partition(int[] a, int p, int r)
    {
        int x = a[r];
        int i = p - 1;
        for (int j = p; j < r; j++)
        {
            if (a[j] >= x)
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

    static void RandomizedQuicksortFirstK(int[] a, int p, int r, int k)
    {
        if (p < r)
        {
            int q = RandomizedPartition(a, p, r);
            if (q > p + k)
	        {
                RandomizedQuicksortFirstK(a, p, q - 1, k);
	        }
            if (q < p + k)
            {
                RandomizedQuicksortFirstK(a, q + 1, r, k + p - q - 1);
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

