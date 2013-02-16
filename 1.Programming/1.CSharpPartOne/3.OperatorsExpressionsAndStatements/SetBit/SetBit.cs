using System;

class SetBit
{
    static void Main()
    {
        int n = 5;
        int p = 2;
        int v = 0;

        int result = (v == 0) ? (n &= ~(1 << p)) : (n |= 1 << p);

        Console.WriteLine(result);
    }
}

