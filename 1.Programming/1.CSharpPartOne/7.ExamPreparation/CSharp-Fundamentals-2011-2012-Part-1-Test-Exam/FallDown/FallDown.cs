using System;

class FallDown
{
    static void Main()
    {
        byte[] arr = new byte[8];

        for (int i = 0; i < 8; i++)
        {
            arr[i] = byte.Parse(Console.ReadLine());
        }

        for (int j = 7; j >= 0; j--)
        {
            int a = 7;
            int b = 6;
            while (b >= 0)
            {
                if (BitCheck(arr[a], j))
                {
                    a--;
                    b--;
                }
                else
                {
                    if (BitCheck(arr[b], j))
                    {
                        BitSet(ref arr[a], j);
                        BitClear(ref arr[b], j);
                    }
                    else
                    {
                        b--;
                    }
                }
            }
        }

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static bool BitCheck(byte b, int pos)
    {
        bool result = (b & (1 << pos)) != 0;
        return result;
    }

    static void BitSet(ref byte b, int pos)
    {
        b = (byte)(b | (1 << pos));
    }
    static void BitClear(ref byte b, int pos)
    {
        b = (byte)(b & (~(1 << pos)));
    }
}

