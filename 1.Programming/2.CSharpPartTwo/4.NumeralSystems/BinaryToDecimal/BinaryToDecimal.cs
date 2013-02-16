using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryToDecimal
{
    static void Main()
    {
        string base2Num = "1110";
        Console.WriteLine(Base2ToBase10(base2Num));
    }

    static int Base2ToBase10(string base2Num)
    {
        int base10Num = 0;
        for (int i = 0; i < base2Num.Length; i++)
        {
            if (base2Num[i] == '1')
            {
                base10Num += (1 << (base2Num.Length - 1 - i));
            }
        }
        return base10Num;
    }
}

