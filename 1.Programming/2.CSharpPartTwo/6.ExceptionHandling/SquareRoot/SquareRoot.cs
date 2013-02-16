using System;

class SquareRoot
{
    static void Main()
    {
        string str = Console.ReadLine();
        Sqrt(str);
    }

    static void Sqrt(string str)
    {
        try
        {
            double num = double.Parse(str);

            if (num < 0)
            {
                throw new ArgumentException(
                    "Argument must be a positive number.", "str");
            }
           
            Console.WriteLine(Math.Sqrt(num));
        }
        catch (Exception ex)
        {
            if (ex is FormatException || ex is ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                throw ex;
            }
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
    }
}



