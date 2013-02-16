using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {

        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        BigInteger first = new BigInteger(t1);
        BigInteger second = new BigInteger(t2);
        BigInteger third = new BigInteger(t3);
        BigInteger next = new BigInteger(0);


        if (n > 3)
        {
            for (int i = 4; i <= n; i++)
            {

                next = first + second + third;
                first = second;
                second = third;
                third = next;
                if (i == n)
                {
                    Console.WriteLine(next);
                }
            }
        }
        else if (n == 1)
        {
            Console.WriteLine(first);
        }
        else if (n == 2)
        {
            Console.WriteLine(second);
        }
        else if (n == 3)
        {
            Console.WriteLine(third);
        }
    }
}

