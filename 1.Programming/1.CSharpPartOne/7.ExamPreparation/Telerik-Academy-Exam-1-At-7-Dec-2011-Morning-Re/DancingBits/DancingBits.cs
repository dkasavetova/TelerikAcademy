using System;
using System.Text;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        StringBuilder bitSequence = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            bitSequence.Append(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        }

        string bitSequenceStr = bitSequence.ToString();

        //Console.WriteLine(bitSequenceStr + " " +  bitSequenceStr.Length);

        int currentBitSequenceLength = 0;
        char currentBit = bitSequenceStr[0];
        int dancingBitCount = 0;

        for (int i = 0; i < bitSequenceStr.Length; i++)
        {
            if (currentBit == bitSequenceStr[i])
            {
                currentBitSequenceLength++;
            }
            else
            {
                if (currentBitSequenceLength == k)
                {
                    dancingBitCount++;
                }
                currentBitSequenceLength = 1;
                currentBit = bitSequenceStr[i];
            }
        }

        if (currentBitSequenceLength == k)
        {
            dancingBitCount++;
        }
         


        Console.WriteLine(dancingBitCount);
        

        
    }
}

