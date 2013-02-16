using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        string inputFile = "test.000.in.txt";
        string outputFile = "test.000.out.txt";

        using (StreamReader reader = new StreamReader(inputFile))
        {
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                int lineNumber = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    writer.WriteLine("{0}: {1}", lineNumber, line);
                }
            }
        }
    }
}

