using System;

class PrintNull
{
    static void Main()
    {
        int? nullableInt = null;
        Console.WriteLine(nullableInt);
        Console.WriteLine(nullableInt + null);
        Console.WriteLine(nullableInt + 1);

        double? nullableDouble = null;
        Console.WriteLine(nullableDouble);
        Console.WriteLine(nullableDouble + null);
        Console.WriteLine(nullableDouble + 1.0);
    }
}

