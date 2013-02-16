using System;

class Variations
{
    static int[] inputSet;
    static int[] variationElements;
    static int k;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());

        inputSet = new int[n];
        variationElements = new int[k];

        for (int i = 0; i < n; i++)
        {
            inputSet[i] = int.Parse(Console.ReadLine());
        }

        Var(0, 1);
    }

    static void Var(int pos, int num)
    {
        // stop before generating varination with more than k elements
        if (pos >= k)
        {
            return;
        }

        for (int i = 1; i <= inputSet.Length; i++)
        {
            variationElements[pos] = i;
            // don't take the varinations with less than k elements
            if (pos >= k - 1)
            {
                OnVariationReady(pos);
            }
            Var(pos + 1, i);
        }
    }

    static void OnVariationReady(int pos)
    {
        for (int i = 0; i <= pos; i++)
        {
            //
            Console.Write(variationElements[i] + " ");
          // Console.Write(inputSet[variationElements[i] - 1] + " ");
        }
        Console.WriteLine();
    }
}

