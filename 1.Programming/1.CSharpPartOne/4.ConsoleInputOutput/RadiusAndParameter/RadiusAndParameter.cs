using System;

class RadiusAndParameter
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine("area: {0,15:F5}", area);
        Console.WriteLine("perimeter: {0,10:F5}", perimeter);
    }
}

