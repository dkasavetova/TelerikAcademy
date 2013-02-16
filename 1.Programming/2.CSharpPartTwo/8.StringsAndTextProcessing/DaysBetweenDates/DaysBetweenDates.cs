using System;

class DaysBetweenDates
{
    static void Main()
    {

        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();

        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();

        string[] firstDateSplitted = firstDate.Split('.');
        string[] secondDateSplitted = secondDate.Split('.');

        DateTime first = new DateTime(
            int.Parse(firstDateSplitted[2]),
            int.Parse(firstDateSplitted[1]),
            int.Parse(firstDateSplitted[0]));

        DateTime second = new DateTime(
            int.Parse(secondDateSplitted[2]), 
            int.Parse(secondDateSplitted[1]), 
            int.Parse(secondDateSplitted[0]));


        TimeSpan distance = second - first;

        Console.WriteLine("Distance: {0}", distance.Days);
    }
}

