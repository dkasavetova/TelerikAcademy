using System;

class MaxOfThree
{
    static void Main()
    {
        int a = -4;
        int b = 3;
        int c = 4;

        if (a < b)
        {
            if (a < c)
            {
                if (b < c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        else
        {
            if (b < c)
            {
                if (a < c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}

