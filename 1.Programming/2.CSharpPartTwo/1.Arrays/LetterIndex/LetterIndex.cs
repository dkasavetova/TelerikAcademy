using System;

class LetterIndex
{
    static void Main()
    {
        string word = Console.ReadLine().ToUpper();

        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('A' + i);
        }

        foreach (var ch in word)
        {
            Console.WriteLine(ch - 'A' + 1);
        }
        
    }
}

