using System;

class SortThreeNumbers
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
                    Console.WriteLine("{0} <= {1} <= {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} <= {1} <= {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0} <= {1} <= {2}", c, a, b);
            }
        }
        else
        {
            if (b < c)
            {
                if (a < c)
                {
                    Console.WriteLine("{0} <= {1} <= {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} <= {1} <= {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0} <= {1} <= {2}", c, b, a);
            }
        }
    }
}

