﻿using System;

class PrintDigit
{
    static void Main()
    {
        int number = 0;
        bool result = int.TryParse(Console.ReadLine(), out number); 
        if (!result)
        {
            Console.WriteLine("Enter a digit next time :)");
            return;
        }

        switch (number)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Enter a digit next time :)");
                break;
        }
    }
}

