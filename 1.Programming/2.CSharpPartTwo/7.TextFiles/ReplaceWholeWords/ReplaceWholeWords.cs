using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
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

        string pattern = @"\b" + searchStr + @"\b";
        fileContent = Regex.Replace(fileContent, pattern, replaceStr);

        using (StreamWriter writer = new StreamWriter(input))
        {
            writer.Write(fileContent);
        }
    }
}

