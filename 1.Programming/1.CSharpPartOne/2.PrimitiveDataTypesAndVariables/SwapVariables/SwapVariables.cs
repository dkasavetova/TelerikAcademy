using System;

class SwapVariables
{
    static void Main()
    {
        int firstVar = 5;
        int secondVar = 10;
        int temp = firstVar;
        firstVar = secondVar;
        secondVar = temp;
        Console.WriteLine(firstVar);
        Console.WriteLine(secondVar);
    }
}

