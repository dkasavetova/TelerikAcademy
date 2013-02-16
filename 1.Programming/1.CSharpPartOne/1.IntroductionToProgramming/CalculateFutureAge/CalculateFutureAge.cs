using System;

class CalculateFutureAge
{
    static void Main()
    {
        byte age;
        while (true)
        {
            Console.Write("Enter your age: ");
            try
            {
                age = byte.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered something bad :( Please enter a positive number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Stop cheating and enter your real age :)");
            }
        }  
        Console.WriteLine("Your age after 10 years will be: {0}", age + 10);
    }
}