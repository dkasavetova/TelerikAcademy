using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GenomeDecoder
{
    static int n, m;
    static string encoded;


    static void Main()
    {
        ReadInput();

        StringBuilder count = new StringBuilder();
        StringBuilder decoded = new StringBuilder();
        for (int i = 0; i < encoded.Length; i++)
        {
            if (encoded[i] == 'A' || encoded[i] == 'C' || encoded[i] == 'G' || encoded[i] == 'T')
            {
                if (count.Length == 0)
                {
                    decoded.Append(encoded[i]);
                }
                else
                {
                    decoded.Append(new string(encoded[i], int.Parse(count.ToString())));
                    count.Clear();
                }
            }
            else
            {
                count.Append(encoded[i]);
            }
        }

        int index = 0;

        int linesCnt = decoded.Length / n + (decoded.Length % n == 0 ? 0 : 1);
        int maxLineNumberLen = linesCnt.ToString().Length;
        string formatString = "{0," + maxLineNumberLen + "} ";
        int lineNumber = 1;
        StringBuilder output = new StringBuilder();

        StreamWriter w = new StreamWriter("bla.txt");
        try
        {
            while (true)
            {
                if (lineNumber <= linesCnt)
                {
                    output.Append(string.Format(formatString, lineNumber));
                    w.Write(string.Format(formatString, lineNumber));
                    lineNumber++;
                }
                for (int j = 0; j < n / m; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        output.Append(decoded[index]);
                        w.Write(decoded[index]);
                        index++;
                    }
                    if (j != n / m - 1)
                    {
                        output.Append(' ');
                        w.Write(' ');
                    }
                }
                if (index == decoded.Length)
                {
                    throw new IndexOutOfRangeException();
                    //Console.WriteLine("HAHA");
                }
                if (n % m != 0)
                {
                    output.Append(' ');
                    w.Write(' ');
                }
               
                for (int j = 0; j < n % m; j++)
                {
                    output.Append(decoded[index]);
                    w.Write(decoded[index]);
                    index++;
                }
                output.Append("\r\n");
                w.Write("\r\n");
            }
        }
        catch (IndexOutOfRangeException) 
        {
            output.Append("\r\n");
            w.Write("\r\n");
        }

        Console.Write(output.ToString());
        w.Close();
    }
  
    private static void ReadInput()
    {
        string[] line = Console.ReadLine().Split(' ');
        n = int.Parse(line[0]);
        m = int.Parse(line[1]);
        encoded = Console.ReadLine();
    }
}

