using System;

class IsBitSet
{
    static void Main()
    {
        int v = 5;
        int p = 1;

        bool isSet = (v & (1 << p)) != 0;
        Console.WriteLine(isSet);
    }
}

