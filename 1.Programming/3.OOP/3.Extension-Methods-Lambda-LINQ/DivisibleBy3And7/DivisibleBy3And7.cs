using System;
using System.Linq;

class DivisibleBy3And7
{
    /// <summary>
    /// Finds the numbers from given array that are divisible by 3 and 7
    /// </summary>
    static void Main()
    {
        int[] numbers = new int[] { 2, 3, 4, 6, 7, 9, 14, 15, 21, 27, 42 };
        Console.Write("Numbers: ");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //using extension methods
        var divisibleBy3And7 = numbers.Where(x => x % 3 == 0 && x % 7 == 0);

        Console.Write("Numbers divisible by 3 and 7: ");
        foreach (var num in divisibleBy3And7)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //using linq query
        var divisibleBy3And7Linq =
            from num in numbers
            where num % 3 == 0 && num % 7 == 0
            select num;

        Console.Write("Numbers divisible by 3 and 7: ");
        foreach (var num in divisibleBy3And7Linq)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

