using System;

class Pillars
{
    static byte[] n = new byte[8];
    static int[] bitCntByCol = new int[8];
    static int lSum, rSum;

    static void Main()
    {
        ReadInput();

        int i, j;
        for (j = 7; j >= 0; j--)
        {
            for (i = 0; i < 8; i++)
            {
                if (CheckBit(n[i], j))
                {
                    bitCntByCol[j]++;
                    rSum++;
                }
            }
        }

        for (i = 7; i >= 0; i--)
        {
            rSum -= bitCntByCol[i];
            if (lSum == rSum)
            {
                Console.WriteLine(i);
                Console.WriteLine(lSum);
                return;
            }
            lSum += bitCntByCol[i];
        }
        Console.WriteLine("No");
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
}

