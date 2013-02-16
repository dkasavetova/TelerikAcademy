using System;

class IsPointInsideCircleAndRectangle
{
    static void Main()
    {
        int x = 1;
        int y = 4;

        int xC = 1;
        int yC = 1;
        int rC = 3;

        int topR = 1;
        int leftR = -1;
        int widthR = 6;
        int heightR = 2;

        bool isInsideCircle = (x - xC) * (x - xC) + (y - yC) * (y - yC) < rC * rC;
        bool isInsideRectangle = y > topR && y < topR - heightR && x < leftR && x > leftR + widthR;

        bool result = isInsideCircle && !isInsideRectangle;

        Console.WriteLine(result);
    }
}

