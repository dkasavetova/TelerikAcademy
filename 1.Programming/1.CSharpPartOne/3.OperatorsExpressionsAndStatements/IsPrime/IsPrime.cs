using System;

class IsPrime
{
    static void Main()
    {
        Console.WriteLine(IsPrimeCheck(1337));
    }

    static bool IsPrimeCheck(int n)
    {
        if (n == 1)
        {
            return false;
        }
        else if (n < 4)
        {
            return true;
        }
        else if (n % 2 == 0)
        {
            return false;
        }
        else if (n < 9)
        {
            return true;
        }
        else if (n % 3 == 0)
        {
            return false;
        }
        else
        {
            int r = (int)Math.Floor(Math.Sqrt(n));
            int f = 5;
            while (f <= r)
            {
                if (n % f == 0)
                {
                    return false;
                }
                if (n % (f + 2) == 0)
                {
                    return false;
                }
                f += 6;
            }
            return true;
        }
    }
}

