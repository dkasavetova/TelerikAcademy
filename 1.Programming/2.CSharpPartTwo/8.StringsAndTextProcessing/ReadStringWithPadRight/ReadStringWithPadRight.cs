using System;

class ReadStringWithPadRight
{
    static void Main()
    {
        string str = ReadString();
        Console.WriteLine(str);
    }

    static string ReadString()
    {
        int maxLen = 20;
        char padChar = '*';

        string str = Console.ReadLine();

        if (str.Length >= maxLen)
        {
            return str.Substring(0, maxLen);
        }
        else
        {
            return str.PadRight(maxLen, padChar);
        }
    }
}

