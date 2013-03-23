using System;

class TestApp
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int input = int.Parse(Console.ReadLine());
        int startNumber = 1;
        int endNumber = 100;

        if (input < startNumber || input > endNumber)
        {
            throw new InvalidRangeException<int>(startNumber, endNumber, "Value not in the specified range.");
        }

        Console.Write("Enter date [YYYY/MM/DD]: ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        DateTime startDate = new DateTime(1980, 1, 1);
        DateTime endDate = new DateTime(2013, 12, 31);

        if (inputDate < startDate || inputDate > endDate)
        {
            throw new InvalidRangeException<DateTime>(startDate, endDate, "Value not in the specified range.");
        }
    }
}

