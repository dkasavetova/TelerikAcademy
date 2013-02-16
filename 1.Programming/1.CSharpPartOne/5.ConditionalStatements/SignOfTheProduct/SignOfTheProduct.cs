using System;

class SignOfTheProduct
{
    static void Main()
    {
        int first = -4;
        int second = 3;
        int third = 4;

        if (first > 0)
        {
            if (second > 0)
            {
                if (third > 0)
                {
                    Console.WriteLine("+");//+++
                }
                else
                {
                    if (third < 0)
                    {
                        Console.WriteLine("-");//++-
                    }
                    else
                    {
                        Console.WriteLine("0");//++0
                    }
                }
            }
            else
            {
                if (second < 0)
                {
                    if (third > 0)
                    {
                        Console.WriteLine("-");//+-+
                    }
                    else
                    {
                        if (third < 0)
                        {
                            Console.WriteLine("+");//+--
                        }
                        else
                        {
                            Console.WriteLine("0");//+-0
                        }
                    }
                }
                else
                {
                    Console.WriteLine("0");//+0?
                }
            }
        }
        else
        {
            if (first < 0)
            {
                if (second > 0)
                {
                    if (third > 0)
                    {
                        Console.WriteLine("-");//-++
                    }
                    else
                    {
                        if (third < 0)
                        {
                            Console.WriteLine("+");//-+-
                        }
                        else
                        {
                            Console.WriteLine("0");//-+0
                        }
                    }
                }
                else
                {
                    if (second < 0)
                    {
                        if (third > 0)
                        {
                            Console.WriteLine("+");//--+
                        }
                        else
                        {
                            if (third < 0)
                            {
                                Console.WriteLine("-");//---
                            }
                            else
                            {
                                Console.WriteLine("0");//--0
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("0");//-0?
                    }
                }
            }
            else
            {
                Console.WriteLine("0");//0??
            }
        }
    }
}

