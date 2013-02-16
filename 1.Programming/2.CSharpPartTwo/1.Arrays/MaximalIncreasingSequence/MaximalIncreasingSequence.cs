using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currLen = 1;
        int maxLen = 1;

        int currStartIndex = 0;
        int maxStartIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] < arr[i])
            {
                currLen++;
            }
            else
            {
                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    maxStartIndex = currStartIndex;
                }

                currLen = 1;
                currStartIndex = i;
            }
        }
        if (currLen > maxLen)
        {
            maxLen = currLen;
            maxStartIndex = currStartIndex;
        }

        for (int i = maxStartIndex; i < maxStartIndex + maxLen; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

