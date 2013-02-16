using System;

class GetBit
{
    static void Main()
    {
        int i = 5;
        int b = 2;

        int bitAtIndexB = (i & 1 << b) >> b;
        Console.WriteLine(bitAtIndexB);
    }
}

