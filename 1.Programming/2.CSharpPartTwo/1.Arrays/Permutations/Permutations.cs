using System;
using System.Collections.Generic;

class Permutations
{
    static int[] inputSet;
    static int[] permutationElements;
    static bool[] used;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        inputSet = new int[n];
        permutationElements = new int[inputSet.Length];
        used = new bool[inputSet.Length];

        for (int i = 0; i < n; i++)
        {
            inputSet[i] = int.Parse(Console.ReadLine());
        }

        Perm(0);
    }

    static void Perm(int pos)
    {
        if (pos >= inputSet.Length)
        {
            OnPermutationReady();
        }
        else
        {
            for (int i = 0; i < inputSet.Length; i++)
            {
                if (used[i] == false)
                {
                    used[i] = true;
                    permutationElements[pos] = i;
                    Perm(pos + 1);
                    used[i] = false;
                }
            }
        }
    }

    static void OnPermutationReady()
    {
        for (int i = 0; i < inputSet.Length; i++)
        {
            //Console.Write(permutationElements[i] + " ");
            Console.Write(inputSet[permutationElements[i]] + " ");
        }
        Console.WriteLine();
    }
}

