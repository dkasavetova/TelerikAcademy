using System;
using System.Collections.Generic;

class SubsetSums
{
    static void Main()
    {
        int[] values = new int[] {3, -3, 1, 1, 1 };
        List<int> takenValues = new List<int>(values.Length);

        for (int i = 0; i < (1 << values.Length); i++)
        {
            int sum = 0;
            for (int j = 0; j < values.Length; j++)
            {             
                if ((i & (1 << j)) != 0)
                {
                    sum += values[j];
                    takenValues.Add(values[j]);
                }
            }
            if (sum == 0)
            {
                if (takenValues.Count != 0)
                {
                    foreach (var item in takenValues)
                    {
                        Console.Write(item + " ");
                    }
                }
                else
                {
                    Console.Write("Empty Set");
                }
                Console.WriteLine();
            }
            else
            {
                takenValues.Clear();
            }      
        }
    }
}

