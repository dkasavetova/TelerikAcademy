using System;

class ConditionalInput
{
    static void Main()
    {
        Console.WriteLine("For int type 1\nFor double type 2\nFor string type 3");
        Console.Write("Choose option: ");
        int typeOfInput = int.Parse(Console.ReadLine());
        Console.Write("Enter input: ");
        switch (typeOfInput)
        {
            case 1:
                Console.Write("Result: " + int.Parse(Console.ReadLine()) + 1);
                break;
            case 2:
                Console.Write("Result: " + double.Parse(Console.ReadLine()) + 1);
                break;
            case 3:
                Console.Write("Result: " + Console.ReadLine() + "*");
                break;
        }
        Console.WriteLine();
    }
}

