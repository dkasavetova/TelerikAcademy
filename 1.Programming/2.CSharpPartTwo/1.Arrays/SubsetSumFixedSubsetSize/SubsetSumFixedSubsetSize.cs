using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubsetSumFixedSubsetSize
{
    static int[] inputSet;
    static int[] combinationElements;
    static int k;

    static int s;
    static bool isFound = false;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());
        s = int.Parse(Console.ReadLine());
        inputSet = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputSet[i] = int.Parse(Console.ReadLine());
        }
        combinationElements = new int[inputSet.Length];
        Comb(0, 1);
        if (isFound == false)
        {
            Console.WriteLine("No subsets of length {0} with sum {1}.", k, s);
        }    
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
            //solution is found, don't look for other solutions
            if (isFound)
            {
                return;
            }
            Comb(pos + 1, i + 1);
        }
    }

    static void OnCombinationReady(int pos)
    {
        int sum = 0;
        for (int i = 0; i <= pos; i++)
        {
            //Console.Write(combinationElements[i] + " ");
            //Console.Write(inputSet[combinationElements[i] - 1] + " ");
            sum += inputSet[combinationElements[i] - 1];
        }
        if (sum == s)
        {
            isFound = true;
            for (int i = 0; i <= pos ; i++)
            {
                Console.Write(inputSet[combinationElements[i] - 1] + " ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

