using System;
using System.Text;

class NumberInEnglish
{
    static int number = -1;
    static StringBuilder result = new StringBuilder();

    static void Main()
    {
        ReadInput();

        int hundreds = number / 100;
        int tens = (number % 100) / 10;
        int units = number % 10;

        switch (hundreds)
        {
            case 1:
                result.Append("one");
                break;
            case 2:
                result.Append("two");
                break;
            case 3:
                result.Append("three");
                break;
            case 4:
                result.Append("four");
                break;
            case 5:
                result.Append("five");
                break;
            case 6:
                result.Append("six");
                break;
            case 7:
                result.Append("seven");
                break;
            case 8:
                result.Append("eight");
                break;
            case 9:
                result.Append("nine");
                break;
            default:
                break;
        }

        if (hundreds != 0)
        {
            result.Append(" hundred ");
        }

        if (hundreds != 0 && tens < 2 && units != 0)
        {
            result.Append("and ");
        } 
        
        switch (tens)
        {
            case 1:
                switch (units)
                {
                    case 0:
                        result.Append("ten");
                        break;
                    case 1:
                        result.Append("eleven");
                        break;
                    case 2:
                        result.Append("twelve");
                        break;
                    case 3:
                        result.Append("thirteen");
                        break;
                    case 4:
                        result.Append("fourteen");
                        break;
                    case 5:
                        result.Append("fifteen");
                        break;
                    case 6:
                        result.Append("sixteen");
                        break;
                    case 7:
                        result.Append("seventeen");
                        break;
                    case 8:
                        result.Append("eighteen");
                        break;
                    case 9:
                        result.Append("nineteen");
                        break;
                }
                break;
            case 2:
                result.Append("twenty ");
                break;
            case 3:
                result.Append("thirty ");
                break;
            case 4:
                result.Append("fourty ");
                break;
            case 5:
                result.Append("fifty ");
                break;
            case 6:
                result.Append("sixty ");
                break;
            case 7:
                result.Append("seventy ");
                break;
            case 8:
                result.Append("eighty ");
                break;
            case 9:
                result.Append("ninety ");
                break;
            default:
                break;
        }

        if (tens != 1)
        {
            switch (units)
            {
                case 0:
                    if (hundreds == 0 && tens == 0)
                    {
                        result.Append("zero");
                    }
                    break;
                case 1:
                    result.Append("one");
                    break;
                case 2:
                    result.Append("two");
                    break;
                case 3:
                    result.Append("three");
                    break;
                case 4:
                    result.Append("four");
                    break;
                case 5:
                    result.Append("five");
                    break;
                case 6:
                    result.Append("six");
                    break;
                case 7:
                    result.Append("seven");
                    break;
                case 8:
                    result.Append("eigh");
                    break;
                case 9:

                    result.Append("nine");
                    break;
            }
        }
        PrintResult();
    }

    static void ReadInput()
    {
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Enter a number in the range [0, 999]");
            return;
        }
        else
        {
            if (number < 0 || number > 999)
            {
                Console.WriteLine("Enter a number in the range [0, 999]");
                return;
            }
        }
    }

    static void PrintResult()
    {
        result[0] -= (char)('a' - 'A');
        Console.WriteLine(result);
    }
   
}

