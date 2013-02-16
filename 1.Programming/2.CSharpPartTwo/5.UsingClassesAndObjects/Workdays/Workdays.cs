using System;
using System.Collections.Generic;
using System.Linq;

class Workdays
{
    static void Main()
    {
        //DateTime start = DateTime.Now;
        DateTime start = new DateTime(2013, 2, 10);
        DateTime end = new DateTime(2013, 10, 10); 
        Console.WriteLine(WorkdaysCount(start, end));
    }

    static int WorkdaysCount(DateTime s, DateTime e)
    {
        DateTime[] holidays = 
        {
            new DateTime(1, 1, 1),
            new DateTime(1, 3, 3),
            new DateTime(1, 5, 1),
            new DateTime(1, 5, 6),
            new DateTime(1, 5, 24),
            new DateTime(1, 9, 6),
            new DateTime(1, 9, 22),
            new DateTime(1, 11, 1),
            new DateTime(1, 12, 24),
            new DateTime(1, 12, 25),
            new DateTime(1, 12, 26)
        };

        int count = 0;
        for (DateTime i = new DateTime(s.Year, s.Month, s.Day); i <= e; i = i.AddDays(1))
        {
            if (i.DayOfWeek != DayOfWeek.Saturday &&
                i.DayOfWeek != DayOfWeek.Sunday &&
                !holidays.Contains(i, new SameDayAndMonthComparer()))
            {
                count++;
            }
        }
        return count;
    }
}

class SameDayAndMonthComparer : IEqualityComparer<DateTime>
{
    public bool Equals(DateTime x, DateTime y)
    {
        if (x.Month == y.Month && x.Day == y.Day)
        {
            return true;
        }
        return false;
    }

    public int GetHashCode(DateTime obj)
    {
        return obj.GetHashCode();
    }
}

