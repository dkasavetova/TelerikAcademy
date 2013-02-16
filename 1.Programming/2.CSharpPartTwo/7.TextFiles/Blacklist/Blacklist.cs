using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Blacklist
{
    static void Main()
    {
        string input = "input.txt";
        string blacklist = "blacklist.txt";
        List<string> inputWords = new List<string>();
        List<string> blacklistWords = new List<string>();

        try
        {
            StreamReader reader = new StreamReader(input);
            using (reader)
            {
                inputWords = reader.ReadToEnd().Split(
                    new char[] {'\r','\n', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            reader = new StreamReader(blacklist);
            using (reader)
            {
                blacklistWords = reader.ReadToEnd().Split(
                    new char[] { '\r', '\n', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            blacklistWords.Sort();
            for (int i = 0; i < inputWords.Count; i++)
            {
                if (blacklistWords.BinarySearch(inputWords[i]) >= 0)
                {
                    inputWords.RemoveAt(i--);
                }
            }

            StreamWriter writer = new StreamWriter(input);
            using (writer)
            {
                foreach (var word in inputWords)
                {
                    writer.WriteLine(word);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("That file is not there :(");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine("You don't have rights to open that file :(");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Someone is using that file and it can't be opened :(");
        }
        catch (Exception)
        {
            Console.Error.WriteLine("The file can't be read :(");
        }
    }
}
