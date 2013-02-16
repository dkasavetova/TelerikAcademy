using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        int number = 785;
        //bool result = (((number % 1000) - (number % 100)) / 100) == 7;
        bool result = ((number / 100) % 10) == 7;
        Console.WriteLine(result);
    }
}

