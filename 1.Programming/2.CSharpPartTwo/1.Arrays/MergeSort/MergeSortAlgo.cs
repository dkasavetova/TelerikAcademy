using System;

class MergeSortAlgo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        MergeSort(arr, 0, arr.Length - 1);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " "); 
        }
        Console.WriteLine();
    }

    static void MergeSort(int[] a, int p, int r)
    {
        if (p < r)
        {
            int q = (p + r) / 2;
            MergeSort(a, p, q);
            MergeSort(a, q + 1, r);
            Merge(a, p, q, r);
        }
    }

    static void Merge(int[] a, int p, int q, int r)
    {
        int n1 = q - p + 1;
        int n2 = r - q;
        int[] left = new int[n1 + 1];
        int[] right = new int[n2 + 1];
        int i, j;
        for (i = 0; i < n1; i++)
        {
            left[i] = a[p + i];
        }
        for (j = 0; j < n2; j++)
        {
            right[j] = a[q + j + 1];
        }
        left[left.Length - 1] = int.MaxValue;
        right[right.Length - 1] = int.MaxValue;
        i = 0;
        j = 0;
        for (int k = p; k <= r; k++)
        {
            if (left[i] <= right[j])
            {
                a[k] = left[i];
                i++;
            }
            else
            {
                a[k] = right[j];
                j++;
            }
        }
    }
}

