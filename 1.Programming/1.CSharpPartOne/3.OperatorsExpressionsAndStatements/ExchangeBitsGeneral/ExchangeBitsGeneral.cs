using System;

class ExchangeBitsGeneral
{
    static void Main()
    {
        int k = 3;
        int p = 3;
        int q = 24;
        // uint n = 120 + (1 << 24)  + (1 << 26) + (1 << 27); ;
        uint n = (1 << 3) + (1 << 4) + (1 << 5);

        Console.WriteLine(Print(n));
        uint maskP = (uint)(n & ((1 << k) - 1) << p) >> p;
        uint maskQ = (uint)(n & ((1 << k) - 1) << q) >> q;

        //Console.WriteLine(Print(maskP));
        //Console.WriteLine(Print(maskQ));

        for (int i = 0; i < k; i++)
        {
            if ((maskP & (1 << i)) != 0)
            {
                n |= (uint)(1 << (q + i));
            }
            else
            {
                n &= (uint)~(1 << (q + i));
            }

            if ((maskQ & (1 << i)) != 0)
            {
                n |= (uint)(1 << (p + i));
            }
            else
            {
                n &= (uint)~(1 << (p + i));
            }
        }

        Console.WriteLine(Print(n));
       
    }
    static string Print(uint n)
    {
        return Convert.ToString(n, 2).PadLeft(32, '0');
    }

}

