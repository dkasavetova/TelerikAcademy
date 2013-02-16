using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        string base16Num = "F1";
        Console.WriteLine(Base16ToBase2(base16Num));
    }

    static string Base16ToBase2(string base16Num)
    {
        string[] map = {
            "0000",
            "0001",
            "0010",
            "0011",
            "0100",
            "0101",
            "0110",
            "0111",
            "1000",
            "1001",
            "1010",
            "1011",
            "1100",
            "1101",
            "1110",
            "1111"
        };

        StringBuilder sb = new StringBuilder();
        int currentHexDigit = 0;

        for (int i = 0; i < base16Num.Length; i++)
        {
            if (base16Num[i] <= '9')
            {
                currentHexDigit = base16Num[i] - '0';
            }
            else
            {
                currentHexDigit = base16Num[i] - 'A' + 10;
            }
            sb.Append(map[currentHexDigit]);
        }
        return sb.ToString();
    }
}

