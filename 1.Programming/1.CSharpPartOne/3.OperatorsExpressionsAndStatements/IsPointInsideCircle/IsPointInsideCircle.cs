using System;

class IsPointInsideCircle
{
    static void Main()
    {
        int xP = 1;
        int yP = 4;

        int xC = 0;
        int yC = 0;
        int rC = 5;

        bool isInside = (xP - xC) * (xP - xC) + (yP - yC) * (yP - yC) < rC * rC;
        Console.WriteLine(isInside);

    }
}

