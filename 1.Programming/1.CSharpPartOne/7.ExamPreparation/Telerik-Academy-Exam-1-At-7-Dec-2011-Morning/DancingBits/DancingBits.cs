using System;
using System.Text;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        StringBuilder bitSequence = new StringBuilder(25600);
        for (int i = 0; i < n; i++)
        {
            bitSequence.Append(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        }
        //for (int i = 0; i < bitSequence.Length; i++)
        //{
        //    Console.WriteLine(bitSequence[i]);
        //}

        int a = 0;
        int b = 0;
        int kk = 0;
        int total = 0;
        while (b < bitSequence.Length)
        {
            if (bitSequence[a] == bitSequence[b])
            {
                kk++;
                b++;
            }
            else
            {
                if (kk == k)
                {
                    total++;
                }
                a = b;
                kk = 0;
            }  
        }
        if (kk == k)
        {
            total++;
        }

        Console.WriteLine(total);
    }
}

