using System;

class ShortBits
{
    static void Main()
    {
        short num = 1337;
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
    }
}

