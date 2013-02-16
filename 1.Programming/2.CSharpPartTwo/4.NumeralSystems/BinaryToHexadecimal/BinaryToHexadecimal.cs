using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        string base2Num = "111011110000";
        Console.WriteLine(Base2ToBase16(base2Num));
    }

    static string Base2ToBase16(string base2Num)
    {
        Dictionary<string, string> dict = new Dictionary<string,string>()
        {
            {"0000", "0"},
            {"0001", "1"},
            {"0010", "2"},
            {"0011", "3"},
            {"0100", "4"},
            {"0101", "5"},
            {"0110", "6"},
            {"0111", "7"},
            {"1000", "8"},
            {"1001", "9"},
            {"1010", "A"},
            {"1011", "B"},
            {"1100", "C"},
            {"1101", "D"},
            {"1110", "E"},
            {"1111", "F"},
        };
        StringBuilder sb = new StringBuilder();
        int offset, start;
        for (int i = base2Num.Length - 1; i >= 0; i -= 4)
        {
            if (i - 4 <= 0)
            {
                offset = i + 1;
                start = 0;
            }
            else
            {
                start = i - 4 + 1;
                offset = 4;
            }

            string fourBitSeq = base2Num.Substring(start, offset).PadLeft(4, '0');
            sb.Append(dict[fourBitSeq]);
        }
        for (int i = 0; i < sb.Length / 2; i++)
        {
            char temp = sb[i];
            sb[i] = sb[sb.Length - 1 - i];
            sb[sb.Length - 1 - i] = temp;
        }
        return sb.ToString();
    }
}

