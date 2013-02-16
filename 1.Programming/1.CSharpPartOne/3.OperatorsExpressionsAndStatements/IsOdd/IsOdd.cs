using System;

class IsOdd
{
    static void Main()
    {
        int number = 4;
        bool isOdd = (number & 1) == 1;
        Console.WriteLine(isOdd);      
    }
}

