using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string base16Num = "FF";
        Console.WriteLine(Base16ToBase10(base16Num));
    }

    static int Base16ToBase10(string base16Num)
    {
        int base10Num = 0;
        int currentHexDigit = 0;
        for (int i = base16Num.Length - 1; i >= 0; i--)
        {
            if (base16Num[i] <= '9')
            {
                currentHexDigit = base16Num[i] - '0';
            }
            else
            {
                currentHexDigit = base16Num[i] - 'A' + 10;
            }

            base10Num += currentHexDigit * (1 << ((base16Num.Length - 1 - i) << 2));
        }
        return base10Num;
    }
}

