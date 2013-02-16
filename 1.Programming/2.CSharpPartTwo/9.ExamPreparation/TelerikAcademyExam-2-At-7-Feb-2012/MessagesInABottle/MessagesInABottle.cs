using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MessagesInABottle
{
    static string message, cipherStr;
    static List<Tuple<string, char>> cipher = new List<Tuple<string, char>>();
    static List<string> screenBuffer = new List<string>();

    static void Main()
    {
        ReadInput();
        ParseCipher();
        Solve(0, new StringBuilder());
        PrintOutput();
    }

    private static void PrintOutput()
    {
        Console.WriteLine(screenBuffer.Count);
        foreach (var item in screenBuffer)
        {
            Console.WriteLine(item);
        }
    }

    static void Solve(int index, StringBuilder partialSolution)
    {
        if (index == message.Length)
        {
            screenBuffer.Add(partialSolution.ToString());
            return;
        }
        string partialMessage = message.Substring(index);
        for (int i = 0; i < cipher.Count; i++)
        {
            if (partialMessage.StartsWith(cipher[i].Item1))
            {
                partialSolution.Append(cipher[i].Item2);
                Solve(index + cipher[i].Item1.Length, partialSolution);
                partialSolution.Remove(partialSolution.Length - 1, 1);
            }
        }
    }

    private static void ParseCipher()
    {
        StringBuilder key = new StringBuilder();
        char val = cipherStr[0];

        for (int i = 1; i < cipherStr.Length; i++)
        {
            if (cipherStr[i] >= 'A' && cipherStr[i] <= 'Z')
            {
                cipher.Add(new Tuple<string, char>(key.ToString(), val));
                key.Clear();
                val = cipherStr[i];
            }
            else
            {
                key.Append(cipherStr[i]);
            }
        }
        cipher.Add(new Tuple<string, char>(key.ToString(), val));

        cipher = cipher.OrderBy(x => x.Item2).ToList();
    }

    private static void ReadInput()
    {
        message = Console.ReadLine();
        cipherStr = Console.ReadLine();
    }
}

