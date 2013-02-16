using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(BitReverse(num));
            //Console.WriteLine(ToBinaryString(num));
            //Console.WriteLine(ToBinaryString(BitReverse(num)));
        }
    }

    static uint BitReverse(uint num)
    {
        uint reversedNum = 0;
        int firstSetIndex = -1;

        for (int i = 31; i >= 0 ; i--)
        {
            if (BitCheck(num, i))
            {
                firstSetIndex = i;
                break;
            }
        }
        for (int i = 0; i <= firstSetIndex; i++)
        {
            if (BitCheck(num, i))
            {
                BitSet(ref reversedNum, firstSetIndex - i);
            }
            else
            {
                BitClear(ref reversedNum, firstSetIndex - i);
            }
        }
        return reversedNum;
    }

    static bool BitCheck(uint b, int pos)
    {
        bool result = (b & (1 << pos)) != 0;
        return result;
    }

    static void BitSet(ref uint b, int pos)
    {
        b = (uint)(b | (1 << pos));
    }

    static void BitClear(ref uint b, int pos)
    {
        b = (uint)(b & (~(1 << pos)));
    }
    static string ToBinaryString(uint num)
    {
        string str = Convert.ToString(num, 2);
        if (str.Length < 32)
        {
            string zeroStr = new String('0', 32 - str.Length);
            str = zeroStr + str;
        }
        return str;
    }
}

