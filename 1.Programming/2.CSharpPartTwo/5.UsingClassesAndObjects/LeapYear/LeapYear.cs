using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(IsLeapYear(year));
        //Console.WriteLine(DateTime.IsLeapYear(year));
    }

    static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        else if(year % 100 == 0) 
        {
            return false;
        }
        else if (year % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

