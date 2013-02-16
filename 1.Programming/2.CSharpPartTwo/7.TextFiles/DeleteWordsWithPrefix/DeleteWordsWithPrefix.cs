using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class DeleteWordsWithPrefix
{
    static void Main()
    {
        string input = "test.000.in.txt";

        string prefix = "start";

        string fileContent;
        List<string> words = new List<string>();

        using (StreamReader reader = new StreamReader(input))
        {
            fileContent = reader.ReadToEnd();
        }

        words = fileContent.Split(
            new char[] {' ', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).ToList();

        words.RemoveAll(x => x.StartsWith(prefix));

        using (StreamWriter writer = new StreamWriter(input))
        {
            foreach (var word in words)
            {
                writer.WriteLine(word);
            }
        }

    }
}



