using System.Text;
using System.IO;

class ConcatFiles
{
    static void Main()
    {
        string firstFile = "input.000.0.in.txt";
        string secondFile = "input.000.1.in.txt";
        string outputFile = "output.000.out.txt";

        StringBuilder sb = new StringBuilder();

        using (StreamReader firstReader = new StreamReader(firstFile))
        {
            sb.Append(firstReader.ReadToEnd());
        }

        using (StreamReader secondReader = new StreamReader(secondFile))
        {
            sb.Append(secondReader.ReadToEnd());
        }

        using (StreamWriter ouputWriter = new StreamWriter(outputFile))
        {
            ouputWriter.Write(sb.ToString());
        }
    }
}
