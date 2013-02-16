using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MathProgram
{
    static void Main()
    {
        int option = ReadOption();

        switch (option)
        {
            case 1:
                ReverseDigitMenu();              
                break;
            case 2:
                GetAverageMenu();
                break;
            case 3:
                SolveLinearEquationMenu();
                break; 
            default :
                Console.WriteLine("Error between keyboard and chair!");
                break;
        }
    }

    private static void SolveLinearEquationMenu()
    {
        Console.Clear();
        double a, b;

        Console.WriteLine("Math Program v1.337 - Linear Equation Solver");
        while (true)
        {
            Console.Write("Enter coeficient A: ");
            string input = Console.ReadLine();
            bool numberEnterResult = double.TryParse(input, out a);

            if (numberEnterResult)
            {
                if (a <= 0)
                {
                    Console.WriteLine("A shold not be negative!");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("ERROR!!! Enter valid real number!");
            }
        }
        while (true)
        {
            Console.Write("Enter coeficient B: ");
            string input = Console.ReadLine();
            bool numberEnterResult = double.TryParse(input, out b);

            if (numberEnterResult)
            {
                break;
            }
            else
            {
                Console.WriteLine("ERROR!!! Enter valid real number!");
            }
        }
        Console.WriteLine("The solution is: " + SolveLinearEquation(a, b));
    }

    private static void GetAverageMenu()
    {
        Console.Clear();

        List<int> l = new List<int>();
        int number;
        Console.WriteLine("Math Program v1.337 - Average of a sequence");
        Console.WriteLine("Enter sequence numbers or type \"stop\" to stop.");
        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            bool numberEnterResult = int.TryParse(input, out number);

            if (numberEnterResult)
            {
                l.Add(number);
            }
            else if (input == "stop")
            {
                if (l.Count > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR!!! Sequence should not be empty!");
                }
            }
            else 
            {
                Console.WriteLine("ERROR!!! Enter valid integer number!");
            }
        }
        Console.WriteLine("The average of your sequnse is: " + Average(l.ToArray()));
    }

    private static void ReverseDigitMenu()
    {
        Console.Clear();

        int number;
        while (true)
        {
            Console.WriteLine("Math Program v1.337 - Digit Reverser");
            Console.Write("Enter digit: ");
            
            bool numberEnterResult = int.TryParse(Console.ReadLine(), out number);

            if (numberEnterResult && number > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR!!! Enter valid positive integer number!");
            }
        }
        ReverseDigits(ref number);
        Console.WriteLine("Your number with reversed digits:" + number);
    }

    private static int ReadOption()
    {
        int option;
        while (true)
        {
            Console.WriteLine("Math Program v1.337");
            Console.WriteLine("1. Reverse digits of a number");
            Console.WriteLine("2. Find the average of a sequence of numbers");
            Console.WriteLine("3. Solve linear equation ax + b = 0");
            Console.Write("Chose Option: ");

            bool chooseOptResult = int.TryParse(Console.ReadLine(), out option);

            if (chooseOptResult && option >= 1 && option <= 3)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR!!! Option must be integer in range [1, 3]!");
            }
        }
        return option;
    }

    static void ReverseDigits(ref int n)
    {
        int r = 0;
        while (n > 0)
        {
            r *= 10;
            r += (n % 10);
            n /= 10;
        }
        n = r;
    }

    static double Average(int[] a)
    {
        double sum = 0;
        foreach (var num in a)
        {
            sum += num;
        }
        double avg = sum / a.Length;
        return avg;
    }

    static double SolveLinearEquation(double a, double b)
    {
        double x = -b / a;
        return x;
    }
}

