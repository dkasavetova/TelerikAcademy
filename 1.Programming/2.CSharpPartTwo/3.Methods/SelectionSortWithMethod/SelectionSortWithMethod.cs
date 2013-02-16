using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SelectionSortWithMethod
{
    static void Main()
    {
        int[] a = { 3, 4, 6, 1, 8 };
        PrintArray(a);

        SelectionSortDesc(a);
        PrintArray(a);

        a = new int[] { 3, 4, 6, 1, 8 };

        SelectionSortAsc(a);
        PrintArray(a);
    }

    static void PrintArray(int[] a) 
    {
        foreach (var num in a)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int MaxElemIndex(int[] arr, int startIndex) 
    {
        int max = startIndex;
        for (int i = startIndex + 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[max])
            {
                max = i;
            }
        }
        return max;
    }

    static void SelectionSortDesc(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int max = MaxElemIndex(a, i);
            Swap(ref a[i], ref a[max]);
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void SelectionSortAsc(int[] a)
    {
        SelectionSortDesc(a);
        ArrayReverse(a);
        
    }

    static void ArrayReverse(int[] a)
    {
        for (int i = 0; i < a.Length/2; i++)
        {
            Swap(ref a[i], ref a[a.Length - 1 - i]);
        }
    }
}

