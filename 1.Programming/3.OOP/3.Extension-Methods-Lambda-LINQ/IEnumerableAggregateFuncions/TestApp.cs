using System;
using System.Collections.Generic;

using System.Threading.Tasks;


class TestApp
{
    static void Main()
    {
        IEnumerable<int> collection = new List<int> { 1, 2, 3, 4 };

        Console.WriteLine("Sum: " + collection.Sum(x => x));

        Console.WriteLine("Product: " + collection.Product(x => x));

        Console.WriteLine("Min: " + collection.Min(x => x));

        Console.WriteLine("Max: " + collection.Max(x => x));

        Console.WriteLine("Average: " + collection.Average(x => x));
    }
}

