using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static int n;
    static long s;
    static long[] combinationElements;
    static long[] numbers;
    static int sums;

    static void Main()
    {
        s = long.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        numbers = new long[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = (long.Parse(Console.ReadLine()));
        }

        sums = 0;

        combinationElements = new long[n];
        Combinations(0, 1);

        Console.WriteLine(sums);
    }

    static void Combinations(int pos, int num)
    {
        if (num > n)
        {
            return;
        }

        for (int i = num; i <= n; i++)
        {
            combinationElements[pos] = i;
            PrintCombination(pos);
            Combinations(pos + 1, i + 1);
        }
    }

    static void PrintCombination(int pos)
    {

        long sum = 0L;
        for (int i = 0; i <= pos; i++)
        {
            //Console.Write(combinationElements[i] + " ");
            //Console.Write(numbers[combinationElements[i] - 1] + " ");
            sum += numbers[combinationElements[i] - 1];
        }
        //Console.WriteLine();
        
        if (sum == s)
        {
            sums++;
        }
    }
}
