using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseWordsInSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(text);
        Console.WriteLine(ReverseWords(text));
    }

    static string ReverseWords(string sentence)
    {
        char[] punctiationChars = {'!', ',', '.', '?', }; //it's sorted

        List<string> words = sentence.Split(' ').ToList();
        for (int i = 0; i < words.Count; i++)
        {
            //if the word is ending with punctuation char
            if (Array.BinarySearch(punctiationChars, 
                words[i][words[i].Length - 1]) >= 0)
            {
                //add the punctuation char to the word list
                words.Insert(i + 1, words[i][words[i].Length - 1].ToString());
                //remove the punctuation char from the word
                words[i] = words[i].Substring(0, words[i].Length - 1);
                i++;
            }
        }

        for (int i = 0, j = words.Count - 1; i < j;)
        {
            if (Array.BinarySearch(punctiationChars, words[i][0]) >= 0)
            {
                i++;
                continue;
            }
            if (Array.BinarySearch(punctiationChars, words[j][0]) >= 0)
            {
                j--;
                continue;
            }

            string temp = words[i];
            words[i] = words[j];
            words[j] = temp;

            i++;
            j--;
        }

        StringBuilder sb = new StringBuilder(sentence.Length);

        foreach (var word in words)
        {
            if (Array.BinarySearch(punctiationChars, word[0]) >= 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            sb.Append(word);
            sb.Append(" ");
        }
        
        return sb.ToString();
    }
}

