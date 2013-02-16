using System;
using System.Collections.Generic;
using System.Linq;

class ArrayMode
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }


        int maxVal = 0;
        int maxKey = 0;
       
        foreach (var item in dict)
        {
            if (item.Value > maxVal)
            {
                maxKey = item.Key;
                maxVal = item.Value;
            }
        }

        Console.WriteLine("{0} ({1} times)", maxKey, maxVal);
    }
}





