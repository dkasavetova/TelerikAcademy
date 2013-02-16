using System;

class SelectionSortAlgo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        SelectionSort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

    }

    static void SelectionSort(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] < a[min])
                {
                    min = j;
                }
            }
            Swap(ref a[i], ref a[min]);
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

