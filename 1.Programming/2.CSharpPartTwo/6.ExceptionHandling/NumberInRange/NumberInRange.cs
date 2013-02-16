using System;

class NumberInRange
{
    static void Main()
    {
        int start = 0;
        int end = 99;
        int count = 10;
        int[] arr = new int[count];

        while (true)
        {
            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    Console.Write("{2}: Enter number in range [{0}, {1}]: ",
                        start, end, i+1);
                    try
                    {
                        arr[i] = ReadNumber(start, end);
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Invalid number, try again!");
                    }
                    catch (InvalidNumberException ex)
                    {
                        int n = (int)ex.Data["number"];
                        int s = (int)ex.Data["start"];
                        int e = (int)ex.Data["end"];

                        Console.WriteLine("Number {0} not in range [{1}, {2}]",
                            n, s, e);
                    }
                }
                start = arr[i] + 1;
                if (start + 1 > end)
                {
                    Console.WriteLine("You cant enter more numbers!!");
                    Console.WriteLine("You are starting all over again!!");
                    start = 0;
                    break;
                }
            }
        }
    }

    static int ReadNumber(int start, int end)
    {
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            throw ex;
        }

        if (number < start || number > end)
        {
            throw new InvalidNumberException(number, start, end);
        }
        
        return number;
    }
}

public class InvalidNumberException : ApplicationException
{
    public InvalidNumberException(int number, int start, int end)
        : base(string.Format("Number {0} not in range [{0}, {1}].",
            number, start, end)) 
    {
        this.Data.Add("number", number);
        this.Data.Add("start", start);
        this.Data.Add("end", end);
    }   
}

