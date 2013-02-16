using System;
using System.Collections.Generic;
using System.Linq;

class SentencesContainingWord
{
    static void Main()
    {
        string text = Console.ReadLine();
        string word = Console.ReadLine();

        List<string> sentences = GetSentencesCotainingWord(text, word);
        foreach (var sentence in sentences)
        {
            Console.WriteLine(sentence);
        }
    }

    /* Setence must end with ".", there are no other punctuation */
    static List<string> GetSentencesCotainingWord(string text, string keyWord)
    {

        List<string> targetSentences = new List<string>();

        List<string> sentences = new List<string>();
        for (int i = 0; i < text.Length; i++)
        {
            int j = text.IndexOf('.', i);
            if (j >= 0)
            {
                sentences.Add(text.Substring(i, j - i + 1).Trim());
                i = j;
            }
        }
        //remove the "." from the last word of the sentence so we can match the last word
        for (int i = 0; i < sentences.Count; i++)
        {
            sentences[i] = sentences[i].Insert(sentences[i].Length - 1, " ");
        }


        for (int i = 0; i < sentences.Count; i++)
        {
            List<string> words =  sentences[i].Split(' ').ToList();

            foreach (var word in words)
            {
                if (word == keyWord )
                {
                    //concat the "." to the last word
                    targetSentences.Add(sentences[i].Remove(
                        sentences[i].Length - 2, 1));
                    break;
                }
            }
        }
        return targetSentences;
    }
}

