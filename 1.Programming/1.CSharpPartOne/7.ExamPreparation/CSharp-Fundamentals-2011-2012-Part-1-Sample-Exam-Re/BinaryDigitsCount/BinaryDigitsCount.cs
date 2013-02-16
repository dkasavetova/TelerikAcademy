using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            uint num = uint.Parse(Console.ReadLine());
            int index = LastSetBitIndex(num);
            int count = 0;
            for (int j = index; j >= 0; j--)
            {
                if (b == 1)
                {
                    if (CheckBit(num, j))
                    {
                        count++;
                    }
                }
                else
                {
                    if (!CheckBit(num, j))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

    }

    static int LastSetBitIndex(uint num)
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

    static bool CheckBit(uint num, int pos)
    {
        return (num & 1 << pos) != 0;
    }
}

