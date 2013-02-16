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
            int firstPos = 0;
            int count = 0;

            for (int j = 31; j >= 0; j--)
            {
                if (BitCheck(num, j))
                {
                    firstPos = j;
                    break;
                }
            }

            for (int j = firstPos; j >= 0; j--)
            {
                if (b == 1)
                {
                    if (BitCheck(num, j))
                    {
                        count++;
                    }
                }
                else
                {
                    if (!BitCheck(num, j))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }


    }

    static bool BitCheck(uint b, int pos)
    {
        bool result = (b & (1 << pos)) != 0;
        return result;
    }
}

