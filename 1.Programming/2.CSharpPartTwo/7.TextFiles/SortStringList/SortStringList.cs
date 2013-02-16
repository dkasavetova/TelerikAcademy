using System;
using System.Collections.Generic;
using System.IO;

class SortStringList
{
    static void Main()
    {
        string input = "test.000.in.txt";
        string output = "text.000.out.txt";
        List<string> strList = new List<string>();

        try
        {
            StreamReader reader = new StreamReader(input);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    strList.Add(line);
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("That file is not there :(");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have rights to open that file :(");
        }
        catch (IOException)
        {
            Console.WriteLine("Someone is using that file and it can't be opened :(");
        }
        catch (Exception)
        {
            Console.WriteLine("The file can't be read :(");
        }

        strList.Sort();

        try
        {
            StreamWriter writer = new StreamWriter(output);
            using (writer)
            {
                foreach (var str in strList)
                {
                    writer.WriteLine(str);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("That file is not there :(");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have rights to open that file :(");
        }
        catch (IOException)
        {
            Console.WriteLine("Someone is using that file and it can't be opened :(");
        }
        catch (Exception)
        {
            Console.WriteLine("The file can't be read :(");
        }
    }
}

