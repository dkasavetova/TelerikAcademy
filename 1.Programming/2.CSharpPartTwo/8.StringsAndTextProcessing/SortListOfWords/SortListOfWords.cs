using System;

class SortListOfWords
{
    static void Main()
    {
        string line = Console.ReadLine();

        string[] words = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}

