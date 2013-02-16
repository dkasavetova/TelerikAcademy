using System;

class ShipDamage
{
    static void Main()
    {
        int Sx1 = int.Parse(Console.ReadLine());
        int Sy1 = int.Parse(Console.ReadLine());
        int Sx2 = int.Parse(Console.ReadLine());
        int Sy2 = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        int Cx1 = int.Parse(Console.ReadLine());
        int Cy1 = int.Parse(Console.ReadLine());
        int Cx2 = int.Parse(Console.ReadLine());
        int Cy2 = int.Parse(Console.ReadLine());
        int Cx3 = int.Parse(Console.ReadLine());
        int Cy3 = int.Parse(Console.ReadLine());

        int shipULx = Sx1 < Sx2 ? Sx1 : Sx2;
        int shipULy = Sy1 > Sy2 ? Sy1 : Sy2;
        int shipDRx = Sx1 > Sx2 ? Sx1 : Sx2;
        int shipDRy = Sy1 < Sy2 ? Sy1 : Sy2;

        Cy1 = -1 * (Cy1 - 2 * H);
        Cy2 = -1 * (Cy2 - 2 * H);
        Cy3 = -1 * (Cy3 - 2 * H);


        int dmg = 0;

        if (Cx1 > shipULx && Cx1 < shipDRx && Cy1 > shipDRy && Cy1 < shipULy)
        {
            dmg += 100;
        }
        else if (Cx1 == shipULx && Cy1 == shipDRy || Cx1 == shipULx && Cy1 == shipULy || Cx1 == shipDRx && Cy1 == shipULy || Cx1 == shipDRx && Cy1 == shipDRy)
        {
            dmg += 25;
        }
        else if (Cx1 == shipULx && Cy1 <= shipULy && Cy1 >= shipDRy || Cx1 == shipDRx && Cy1 <= shipULy && Cy1 >= shipDRy || Cy1 == shipULy && Cx1 >= shipULx && Cx1 <= shipDRx || Cy1 == shipDRy && Cx1 >= shipULx && Cx1 <= shipDRx)
        {
            dmg += 50;
        }

        if (Cx2 > shipULx && Cx2 < shipDRx && Cy2 > shipDRy && Cy2 < shipULy)
        {
            dmg += 100;
        }
        else if (Cx2 == shipULx && Cy2 == shipDRy || Cx2 == shipULx && Cy2 == shipULy || Cx2 == shipDRx && Cy2 == shipULy || Cx2 == shipDRx && Cy2 == shipDRy)
        {
            dmg += 25;
        }
        else if (Cx2 == shipULx && Cy2 <= shipULy && Cy2 >= shipDRy || Cx2 == shipDRx && Cy2 <= shipULy && Cy2 >= shipDRy || Cy2 == shipULy && Cx2 >= shipULx && Cx2 <= shipDRx || Cy2 == shipDRy && Cx2 >= shipULx && Cx2 <= shipDRx)
        {
            dmg += 50;
        }

        if (Cx3 > shipULx && Cx3 < shipDRx && Cy3 > shipDRy && Cy3 < shipULy)
        {
            dmg += 100;
        }
        else if (Cx3 == shipULx && Cy3 == shipDRy || Cx3 == shipULx && Cy3 == shipULy || Cx3 == shipDRx && Cy3 == shipULy || Cx3 == shipDRx && Cy3 == shipDRy)
        {
            dmg += 25;
        }
        else if (Cx3 == shipULx && Cy3 <= shipULy && Cy3 >= shipDRy || Cx3 == shipDRx && Cy3 <= shipULy && Cy3 >= shipDRy || Cy3 == shipULy && Cx3 >= shipULx && Cx3 <= shipDRx || Cy3 == shipDRy && Cx3 >= shipULx && Cx3 <= shipDRx)
        {
            dmg += 50;
        }

        Console.WriteLine(dmg +"%");
    }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Rectangle
{
    public Point UpLeft;
    public Point DownRight;

    public Rectangle(int x1, int y1, int x2, int y2)
    {
        UpLeft = new Point(x1 < x2 ? x1 : x2, y1 > y2 ? y1 : y2);
        DownRight = new Point(x1 > x2 ? x1 : x2, y1 < y2 ? y1 : y2);

    }
    // 0 - outside
    // 1 - inside
    // 2 - on edge
    // 3 - on corner
    public int CheckPointPosition(Point p)
    {
        if (p.X > UpLeft.X && p.X < DownRight.X && p.Y > DownRight.Y && p.Y < UpLeft.Y)
        {
            return 1;
        }
        else if (p.X == UpLeft.X && p.Y == DownRight.Y || p.X == UpLeft.X && p.Y == UpLeft.Y || p.X == DownRight.X && p.Y == UpLeft.Y || p.X == DownRight.X && p.Y == DownRight.Y)
        {
            return 3;
        }
        else if (p.X == UpLeft.X && p.Y <= UpLeft.Y && p.Y >= DownRight.Y || p.X == DownRight.X && p.Y <= UpLeft.Y && p.Y >= DownRight.Y || p.Y == UpLeft.Y && p.X >= UpLeft.X && p.X <= DownRight.X || p.Y == DownRight.Y && p.X >= UpLeft.X && p.X <= DownRight.X)
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }
}


