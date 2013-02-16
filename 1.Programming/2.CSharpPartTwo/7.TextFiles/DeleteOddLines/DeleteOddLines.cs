using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string input = "test.000.in.txt";
        List<string> linesList = new List<string>();

        using (StreamReader reader = new StreamReader(input))
        {
            int lineNumber = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    linesList.Add(line);
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(input))
        {
            foreach (var line in linesList)
            {
                writer.WriteLine(line);
            }
        }
    }
}
