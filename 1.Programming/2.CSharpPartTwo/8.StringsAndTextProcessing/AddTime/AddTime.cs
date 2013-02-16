using System;

class AddTime
{
    static void Main()
    {
        //string input = Console.ReadLine();
        string input = "2.01.2005 3:23:55";

        int spaceIndex = input.IndexOf(' ');

        string date = input.Substring(0, input.Length - spaceIndex + 1);
        string time = input.Substring(spaceIndex + 1);

        string[] dateSplitted = date.Split('.');
        string[] timeSpritted = time.Split(':');

        DateTime dateTime = new DateTime(
            int.Parse(dateSplitted[2]),
            int.Parse(dateSplitted[1]),
            int.Parse(dateSplitted[0]),
            int.Parse(timeSpritted[0]),
            int.Parse(timeSpritted[1]),
            int.Parse(timeSpritted[2]));

        DateTime newDateTime = dateTime.AddHours(6).AddMinutes(30);

        Console.WriteLine("{0:d.MM.yyyy HH:mm:ss}", newDateTime);

        switch (newDateTime.DayOfWeek)
        {
            case DayOfWeek.Friday:
                Console.WriteLine("Петък");
                break;
            case DayOfWeek.Monday:
                Console.WriteLine("Понеделник");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Събота");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Неделя");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Четвъртък");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Вторник");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Сряда");
                break;
            default:
                break;
        }
    }
}

