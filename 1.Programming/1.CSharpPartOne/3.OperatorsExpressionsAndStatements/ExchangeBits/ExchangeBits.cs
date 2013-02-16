using System;

class ExchangeBits
{
    static void Main()
    {
        uint n = (1 << 3) + (1 << 4) + (1 << 5);

        Print(n);
        SwapBit(ref n, 3, 24);
        SwapBit(ref n, 4, 25);
        SwapBit(ref n, 5, 26);
        Print(n);
    }

    static void Print(uint n)
    {
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
    }

    static void SwapBit(ref uint n, int p, int q)
    {
        uint temp = (uint)(n & 1 << q);
        if ((n & 1 << p) != 0)
        {
            n |= (uint)(1 << q);
        }
        else
        {
            n &= (uint)~(1 << q);
        }
        if (temp != 0)
        {
            n |= (uint)(1 << p);
        }
        else
        {
            n &= (uint)~(1 << p);
        }
    }
}

