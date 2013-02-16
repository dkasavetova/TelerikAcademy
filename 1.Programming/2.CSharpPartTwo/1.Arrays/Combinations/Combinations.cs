using System;

class Combinations
{
    static int[] inputSet;
    static int[] combinationElements;
    static int k;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());

        inputSet = new int[n];
        combinationElements = new int[inputSet.Length];

        for (int i = 0; i < n; i++)
        {
            inputSet[i] = int.Parse(Console.ReadLine());
        }

        Comb(0, 1);
    }

    static void Comb(int pos, int num)
    {
        // stop before generating combination with more than k elements
        if (pos >= k)
        {
            return;
        }

        for (int i = num; i <= inputSet.Length; i++)
        {
            combinationElements[pos] = i;
            // don't take the combinations with less than k elements
            if (pos >= k - 1)
            {
                OnCombinationReady(pos);
            }
            Comb(pos + 1, i + 1);
        }
    }

    static void OnCombinationReady(int pos)
    {
        for (int i = 0; i <= pos; i++)
        {
            //Console.Write(combinationElements[i] + " ");
            Console.Write(inputSet[combinationElements[i] - 1] + " ");
        }
        Console.WriteLine();
    }
}

