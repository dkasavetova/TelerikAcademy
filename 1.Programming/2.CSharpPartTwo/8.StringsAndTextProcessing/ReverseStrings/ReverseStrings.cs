using System;
using System.Text;

class ReverseStrings
{
    static void Main()
    {
        string str = Console.ReadLine();

        str = Reverse(str);

        Console.WriteLine(str);
    }

    static string Reverse(string str)
    {
        StringBuilder sb = new StringBuilder(str);

        for (int i = 0; i < sb.Length / 2; i++)
        {
            char temp = sb[i];
            sb[i] = sb[sb.Length - 1 - i];
            sb[sb.Length - 1 - i] = temp;
        }

        return sb.ToString();
    }
}

