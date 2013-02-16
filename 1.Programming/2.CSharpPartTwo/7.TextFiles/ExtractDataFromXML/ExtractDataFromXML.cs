using System;
using System.IO;

class ExtractDataFromXML
{
    static void Main()
    {
        string input = "test.000.in.txt";
        string xml;
        using (StreamReader reader = new StreamReader(input))
        {
            xml = reader.ReadToEnd();
        }

        int i = 0, j = 0;
        while (true)
        {
            i = xml.IndexOf('>', i) + 1;
            if (i >= xml.Length || xml[i] == '\r')
            {
	            break;
            }
            if (xml[i] != '<')
            {
                j = xml.IndexOf('<', i);
                Console.WriteLine(xml.Substring(i, j - i));
                i = j + 1;
            }
        }
    }
}

