using System;
using System.IO;

class PrintFileContent
{
    static void Main()
    {
        string path = Console.ReadLine();

        try
        {
            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please provide valid path");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please provide path string");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path string is too long.");
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
            Console.WriteLine(
                "Someone is using that file and it can't be opened :(");
        }
        catch (Exception)
        {
            Console.WriteLine("The file can't be read :(");
        }      
    }
}