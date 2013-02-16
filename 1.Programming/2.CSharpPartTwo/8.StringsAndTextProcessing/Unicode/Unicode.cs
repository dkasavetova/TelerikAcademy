using System;
using System.Text;

class Unicode
{
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(UnicodeEncode(text));
    }

    static string UnicodeEncode(string text)
    {
        StringBuilder sb = new StringBuilder(text.Length * 6);

        foreach (var ch in text)
        {
           sb.Append(string.Format("\\u{0:x4}", (int)ch));
        }
        return sb.ToString();
    }
}

