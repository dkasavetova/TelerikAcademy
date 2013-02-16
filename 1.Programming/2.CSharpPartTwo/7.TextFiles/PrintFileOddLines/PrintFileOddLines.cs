using System;
using System.IO;

class PrintFileOddLines
{
    static void Main()
    {
        string fileName = "test.000.in.txt";

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
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
    }
}

