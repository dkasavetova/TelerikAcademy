using System;
using System.Collections.Generic;

class TextWordCount
{
    static void Main()
    {
        string str = Console.ReadLine();

        Dictionary<string, int> dict = new Dictionary<string, int>();

        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            if (dict.ContainsKey(words[i]))
            {
                dict[words[i]]++;
            }
            else
            {
                dict.Add(words[i], 1);
            }
        }

        foreach (var word in dict.Keys)
        {
            Console.WriteLine("\'{0}\' - {1}", word, dict[word]);
        }
    }
}

