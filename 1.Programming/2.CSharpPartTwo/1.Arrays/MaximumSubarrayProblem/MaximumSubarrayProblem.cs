using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaximumSubarrayProblem
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int start = 0;
        int end = 0;
        int sum = 0;

        MaximalSubarraySum(arr, ref start, ref end, ref sum);

        for (int i = start; i <= end; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void MaximalSubarraySum(int[] a, ref int s, ref int e, ref int sum)
    {
        int maxEndingHere = a[0];
        int maxSoFar = a[0];
        int begin = 0;
        int beginTemp = 0;
        int end = 0;

        for (int i = 1; i < a.Length; i++)
        {
            maxEndingHere += a[i];
            if (a[i] > maxEndingHere)
            {
                maxEndingHere = a[i];
                beginTemp = i;
            }
            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;
                begin = beginTemp;
                end = i;
            }
        }

        s = begin;
        e = end;
        sum = maxSoFar;
    }
}

