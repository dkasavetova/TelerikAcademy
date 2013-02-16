using System;

class Pillars
{
    static void Main()
    {
        byte[] arr = new byte[8];
        int[] vals = new int[8];

        for (int i = 0; i < 8; i++)
        {
            arr[i] = byte.Parse(Console.ReadLine());

            for (int j = 0; j < 8; j++)
            {
                if (BitCheck(arr[i], j))
                {
                    vals[j]++;
                }
            }
        }

        int right = 0;
        for (int i = 0; i <= 6; i++)
        {
            right += vals[i];
        }
        int left = 0;

        int pillar;
        for (pillar = 7; pillar >= 0; pillar--)
        {
            if (left == right)
            {
                break;
            }
            else
            {
                if (pillar != 0)
                {
                    left += vals[pillar];
                    right -= vals[pillar - 1];
                }
            }

        }

        if (pillar != -1)
        {
            Console.WriteLine("{0}\n{1}", pillar, left);
        }
        else
        {
            Console.WriteLine("No");
        }     
    }

    static bool BitCheck(byte b, int pos)
    {
        bool result = (b & (1 << pos)) != 0;
        return result;
    }
}

