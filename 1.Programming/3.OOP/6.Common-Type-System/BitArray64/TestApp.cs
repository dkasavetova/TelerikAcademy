using System;
using System.Collections.Generic;

class TestApp
{
    static void Main()
    {
        BitArray64 bits = new BitArray64();

        //set all bits at even index
        for (int i = 0; i < 64; i++)
        {
            if (i % 2 == 0)
            {
                bits[i] = 1;  
            }
        }

        //clear all bits with index less than 10
        for (int i = 0; i < 10; i++)
        {
            bits[i] = 0;
        }

        IEnumerator<int> e = bits.GetEnumerator();
        e.MoveNext();
        Console.WriteLine();
       
        Console.WriteLine(bits);

        //foreach example
        foreach (var item in bits)
        {
            Console.WriteLine(item);
        }
    }
}

