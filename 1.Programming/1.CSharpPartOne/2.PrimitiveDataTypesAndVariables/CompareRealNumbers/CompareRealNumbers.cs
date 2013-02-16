using System;

class CompareRealNumbers
{
    static void Main()
    {
        float eps = 0.000001f;
        Console.WriteLine(Compare(5.3, 6.01, eps));
        Console.WriteLine(Compare(5.00000001, 5.00000003, eps));
        Console.WriteLine(Compare(0.000001f, 0.000002f, eps));
    }

    static bool Compare(double firstNumber, double secondNumber, double epsilon)
    {
        return Math.Abs(firstNumber - secondNumber) <= epsilon;
    }

    static bool Compare(float firstNumber, float secondNumber, float epsilon)
    {
        return Math.Abs(firstNumber - secondNumber) <= epsilon;
    }
}

