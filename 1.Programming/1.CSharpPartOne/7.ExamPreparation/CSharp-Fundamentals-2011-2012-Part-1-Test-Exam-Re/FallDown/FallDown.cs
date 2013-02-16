using System;

class FallDown
{
    static byte[] n = new byte[8];
    static int[] bitCntByCol = new int[8];

    static void Main()
    {
        ReadInput();
        BitCountByColumn();
        n = new byte[8];

        for (int j = 7; j >= 0; j--)
        {
            for (int i = 7; i >= 8 - bitCntByCol[j]; i--)
            {
                SetBit(ref n[i], j);
            }
        }

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(n[i]);
        }

        
    }

    static void ReadInput()
    {
        for (int i = 0; i < 8; i++)
        {
            n[i] = byte.Parse(Console.ReadLine());
        }
    }

    static bool CheckBit(int num, int pos)
    {
        return (num & 1 << pos) != 0;
    }

    static void SetBit(ref byte num, int pos)
    {
        num |= (byte)(1 << pos);
    }

    static void BitCountByColumn()
    {
        for (int j = 7; j >= 0; j--)
        {
            for (int i = 0; i < 8; i++)
            {
                if (CheckBit(n[i], j))
                {
                    bitCntByCol[j]++;
                }
            }
        }
    }
}

