using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            int lastSetBit = LastSetBitIndex(num);
            int result = 0;

            for (int j = 0; j <= lastSetBit; j++)
            {
                if (CheckBit(num, j))
                {
                    result += (1 << (lastSetBit - j));
                }
            }

            Console.WriteLine(result);
        }
    }

    static int LastSetBitIndex(int num)
    {
        for (int i = 31; i >= 0; i--)
        {
            if ((num & 1 << i) != 0)
            {
                return i;
            }
        }
        return -1;
    }

    static bool CheckBit(int num, int pos)
    {
        return (num & 1 << pos) != 0;
    }

}

