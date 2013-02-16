using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        string searchStr = "start";
        string replaceStr = "finish";

        string input = "test.000.in.txt";
        string fileContent;

        using (StreamReader reader = new StreamReader(input))
        {
            fileContent = reader.ReadToEnd();
        }

        fileContent = fileContent.Replace(searchStr, replaceStr);

        using (StreamWriter writer = new StreamWriter(input))
        {
            writer.Write(fileContent);
        }

    }
}

