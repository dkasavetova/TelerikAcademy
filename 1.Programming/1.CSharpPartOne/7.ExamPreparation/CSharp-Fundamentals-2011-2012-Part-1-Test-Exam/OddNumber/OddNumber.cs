using System;
using System.Collections.Generic;

class OddNumber
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //Dictionary<long, uint> dict = new Dictionary<long, uint>();
        //long number = 0L;
        //for (int i = 0; i < n; i++)
        //{
        //    number = long.Parse(Console.ReadLine());
        //    if (dict.ContainsKey(number))
        //    {
        //        dict[number]++;
        //    }
        //    else
        //    {
        //        dict.Add(number, 1);
        //    }
        //}

        //if (dict.Count == 1)
        //{
        //    Console.WriteLine(number);
        //}
        //else
        //{
        //    foreach (var item in dict)
        //    {
        //        if (item.Value % 2 == 1)
        //        {
        //            Console.WriteLine(item.Key);
        //            break;
        //        }
        //    }
        //} 

        int n = int.Parse(Console.ReadLine());
        long number = long.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            number ^= long.Parse(Console.ReadLine());
        }
        Console.WriteLine(number);

    }
}

