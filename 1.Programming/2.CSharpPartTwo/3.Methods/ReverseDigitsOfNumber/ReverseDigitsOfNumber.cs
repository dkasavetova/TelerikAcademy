using System;

class ReverseDigitsOfNumber
{
    static void Main(string[] args)
    {
        int n = 123;
        ReverseDigits(ref n);
        Console.WriteLine(n);
    }

    static void ReverseDigits(ref int n)
    {
        int r = 0;
        while (n > 0)
        {
            r *= 10;
            r += (n % 10);
            n /= 10;
        }
        n = r;
    }
}

