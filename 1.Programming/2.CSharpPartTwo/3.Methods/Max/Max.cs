using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Max
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(a, GetMax(b, c)));
    }

    static int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }
}

