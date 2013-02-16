using System;

class TriangleSurface
{
    static void Main()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double gama = 90;

        Console.WriteLine(SurfaceBySideAndAltitude(a, b));
        Console.WriteLine(SurfaceByThreeSides(a, b, c));
        Console.WriteLine(SurfaceByTwoSidesAndAngle(a, b, gama));  
    }

    static double SurfaceBySideAndAltitude(double a, double ha)
    {
        return (a * ha) / 2.0;
    }

    static double SurfaceByThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static double SurfaceByTwoSidesAndAngle(double a, double b, double angle)
    {
        angle = DegreesToRadians(angle);
        Console.WriteLine(angle);
        return (a * b * Math.Sin(angle)) / 2.0;
    }

    static double DegreesToRadians(double degrees)
    {
        return Math.PI * degrees / 180.0;
    }
}

