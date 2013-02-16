using System;
using System.Collections.Generic;

class GetPalindromesFromText
{
    static void Main()
    {
        string text = Console.ReadLine();

        List<string> palindromes = GetPalindromes(text);

        foreach (var item in palindromes)
        {
            Console.WriteLine(item);
        }
    }

    static List<string> GetPalindromes(string text)
    {
        string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();

        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }
        return palindromes;
    }

    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}

