using System;
using System.Text;

class RemoveConsecutiveIdenticalLetters
{
    static void Main()
    {
        string str = Console.ReadLine();
        str = RemoveDuplicatedConsecuteLeters(str);
        Console.WriteLine(str);
    }

    static string RemoveDuplicatedConsecuteLeters(string str)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(str[0]);
        for (int i = 1; i < str.Length - 1; i++)
        {
            if (str[i] != str[i - 1])
            {
                sb.Append(str[i]);
            }
        }
        if (str.Length - 2 >= 0 && (str[str.Length - 2] != str[str.Length - 1]))
        {
            sb.Append(str[str.Length - 1]);
        }
        return sb.ToString();
    }
}

