using System;
using System.Collections.Generic;

class WordLettersCount
{
    static void Main()
    {
        string str = Console.ReadLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < str.Length; i++)
        {
            if (dict.ContainsKey(str[i]))
            {
                dict[str[i]]++;
            }
            else
            {
                dict.Add(str[i], 1);
            }
        }

        foreach (var ch in dict.Keys)
        {
            Console.WriteLine("\'{0}\' - {1}", ch, dict[ch]);
        }
    }
}
