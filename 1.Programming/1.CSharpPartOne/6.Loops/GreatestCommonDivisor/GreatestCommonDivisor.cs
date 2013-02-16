using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int a = 505;
        int b = 55;
            
        while (a > 0)
        {
            int temp = a;
            a = b % a;
            b = temp;
        }
        Console.WriteLine(b);
    }
}

