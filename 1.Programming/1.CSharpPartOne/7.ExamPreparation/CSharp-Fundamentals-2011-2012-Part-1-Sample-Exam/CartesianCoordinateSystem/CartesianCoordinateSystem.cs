using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        if (x == 0m)
        {
            if (y == 0m)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(5);
            }
        }
        else
        {
            if (x > 0m)
            {
                if (y == 0m)
                {
                    Console.WriteLine(6);
                }
                else
                {
                    if (y > 0m)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(4);
                    }
                }
            }
            else
            {
                if (y == 0m)
                {
                    Console.WriteLine(6);
                }
                else
                {
                    if (y > 0m)
                    {
                        Console.WriteLine(2);
                    }
                    else
                    {
                        Console.WriteLine(3);
                    }
                }
            }
        }
    }
}

