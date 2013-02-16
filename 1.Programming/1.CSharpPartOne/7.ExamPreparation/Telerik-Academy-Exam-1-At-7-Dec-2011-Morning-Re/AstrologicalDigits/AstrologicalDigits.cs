using System;

class AstrologicalDigits
{
    static string nStr;
    static int n = 0;

    static void Main()
    {
        Readinput();
        Solve();
        PrintOutput();
    }

    static void PrintOutput()
    {
        Console.WriteLine(n);
    }

    static void Solve()
    {
        do
        {
            n = 0;

            foreach (var ch in nStr)
            {
                if (ch != '.' && ch != '-') 
                {
                    n += ch - '0';
                }
            }

            nStr = n.ToString();
        } while (n > 9);
    }

    static void Readinput()
    {
        nStr = Console.ReadLine();
    }
}

