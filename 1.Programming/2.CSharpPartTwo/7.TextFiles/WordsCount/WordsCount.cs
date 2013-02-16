using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        string wordsFile = "words.txt";
        string testFile = "test.txt";
        string resultFile = "result.txt";
        Dictionary<string, int> dict = new Dictionary<string, int>();
        List<string> words = new List<string>();
        List<string> testWords = new List<string>();
        try
        {
            StreamReader reader = new StreamReader(wordsFile);
            using (reader)
            {
                words = reader.ReadToEnd().Split(
                    new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 0);
                }
            }

            reader = new StreamReader(testFile);
            using (reader)
            {
                testWords = reader.ReadToEnd().Split(
                    new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var word in testWords)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
            }

            List<KeyValuePair<string, int>> list = dict.ToList();
            list.Sort((x, y) => y.Value.CompareTo(x.Value));

            StreamWriter writer = new StreamWriter(resultFile);
            using (writer)
            {
                foreach (var item in list)
                {
                    writer.WriteLine("{0} : {1}", item.Value, item.Key);
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

