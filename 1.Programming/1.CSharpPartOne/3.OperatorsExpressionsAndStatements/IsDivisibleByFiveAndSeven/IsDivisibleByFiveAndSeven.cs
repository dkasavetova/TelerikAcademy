using System;

class IsDivisibleByFiveAndSeven
{
    static void Main()
    {
        int number = 70;
        bool isDivisibleby5And7 = ((number % 5) == 0) && ((number % 7) == 0);
        Console.WriteLine(isDivisibleby5And7);
    }
}

