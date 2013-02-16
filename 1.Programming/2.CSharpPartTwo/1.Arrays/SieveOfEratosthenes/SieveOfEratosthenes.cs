using System;
using System.Collections;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = 10000000;
        int m = (int)Math.Sqrt(n);
        BitArray sieve = new BitArray(n);

        int i = 2;
        while (i <= m)
        {
            for (int j = 2 * i; j < n; j += i)
            {
                sieve[j] = true;
            }
            do
            {
                i++;
            }
            while (sieve[i] == true);  
        }

        //print just the prime numbers up to 100
        for (int j = 2; j < 100; j++)
        {
            if (sieve[j] == false)
            {
                Console.WriteLine(j);
            }
        }

    }
}

