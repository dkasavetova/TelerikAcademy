using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrintName
{
    static void Main()
    {
        AskForName();
    }

    static void AskForName()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello,{0}!", name);
    }
}

