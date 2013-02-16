using System;

class CheckBit
{
    static void Main()
    {
        int number = 16;
        int bitIndex = 3;
        bool result = (number & 1 << bitIndex) != 0;
        Console.WriteLine(result);

    }
}

