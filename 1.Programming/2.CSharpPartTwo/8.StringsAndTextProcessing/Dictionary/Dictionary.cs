using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string> 
        {
            {".NET", "platform for applications from Microsoft"},
            {"CLR", "managed execution environment for .NET" },
            {"namespace", "hierarchical organization of classes"}
        };

        string q = Console.ReadLine();

        string a;

        if (dict.ContainsKey(q))
        {
            a = dict[q];
        }
        else
        {
            a = "No information about " + q + "!";
        }

        Console.WriteLine(a);
    }
}

