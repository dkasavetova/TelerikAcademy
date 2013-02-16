using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Censure
{
    static void Main(string[] args)
    {
        string text = 
            "Microsoft announced its next generation PHP compiler today. " +
            "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbidden = { "PHP", "CLR", "Microsoft" };

        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine(CensureText(text, forbidden, '*'));
    }

    /* Post: forbidden[] is sorted */
    static string CensureText(string text, string[] forbidden, char replace)
    {
        Array.Sort(forbidden);

        List<string> words = text.Split(' ').ToList();

        for (int i = 0; i < words.Count; i++)
        {
            string currentWord;
            if (words[i][words[i].Length - 1] == '.') //add other sentence ending chars if needed
            {
                currentWord = words[i].Substring(0, words[i].Length - 1);
            }
            else
            {
                currentWord = words[i];
            }

            if (Array.BinarySearch(forbidden, currentWord) >= 0)
            {
                //if there was '.' removed from the end of the word
                if (currentWord.Length < words[i].Length)
                {
                    words[i] = new string(replace, currentWord.Length) + 
                        words[i][words[i].Length - 1];
                }
                else
                {
                    words[i] = new string(replace, currentWord.Length);
                }
            }
        }

        StringBuilder sb = new StringBuilder(text.Length);

        foreach (var word in words)
        {
            sb.Append(word);
            sb.Append(" ");
        }

        return sb.ToString();
    }
}

