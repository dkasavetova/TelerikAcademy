using System;

class ShipDamage
{
    static int SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, CY3;
    static int SXmin, SYmax, SXmax, SYmin;

    static void Main()
    {
        SX1 = int.Parse(Console.ReadLine());
        SY1 = int.Parse(Console.ReadLine());
        SX2 = int.Parse(Console.ReadLine());
        SY2 = int.Parse(Console.ReadLine());
        H = int.Parse(Console.ReadLine());
        CX1 = int.Parse(Console.ReadLine());
        CY1 = int.Parse(Console.ReadLine());
        CX2 = int.Parse(Console.ReadLine());
        CY2 = int.Parse(Console.ReadLine());
        CX3 = int.Parse(Console.ReadLine());
        CY3 = int.Parse(Console.ReadLine());

        SXmin = SX1 < SX2 ? SX1 : SX2;
        SYmax = SY1 > SY2 ? SY1 : SY2;
        SXmax = SX1 > SX2 ? SX1 : SX2;
        SYmin = SY1 < SY2 ? SY1 : SY2;

        int CY1hit = -1 * (CY1 - 2 * H);
        int CY2hit = -1 * (CY2 - 2 * H);
        int CY3hit = -1 * (CY3 - 2 * H);

        int dmg = 0;
        dmg += CalcDamage(CX1, CY1hit);
        dmg += CalcDamage(CX2, CY2hit);
        dmg += CalcDamage(CX3, CY3hit);

        Console.WriteLine(dmg + "%");
    }

    static int CalcDamage(int hitX, int hitY)
    {
        int dmg = 0;

        if (IsCornerHit(hitX, hitY))
        {
            dmg += 25;
        }
        else if (IsSideHit(hitX, hitY))
        {
            dmg += 50;
        }
        else if (IsBodyHit(hitX, hitY))
        {
            dmg += 100;
        }

        return dmg;
    }

    static bool IsBodyHit(int hitX, int hitY)
    {
        if (hitY > SYmin && hitY < SYmax)
        {
            if (hitX > SXmin && hitX < SXmax)
            {
                return true;
            }
        }
        return false;
    }

    static bool IsSideHit(int hitX, int hitY)
    {
        
        if (hitY > SYmin && hitY < SYmax)
        {
            // Left
            if (hitX == SXmin)
            {
                return true;
            }
            // Right
            if (hitX == SXmax)
            {
                return true;
            }
        }
        if (hitX > SXmin && hitX < SXmax)
        {
            // Top
            if (hitY == SYmax)
            {
                return true;
            }
            // Bottom
            if (hitY == SYmin)
            {
                return true;
            }
        }

        return false;
    }

    static bool IsCornerHit(int hitX, int hitY)
    {
        // Top Left
        if (hitX == SXmin && hitY == SYmax)
        {
            return true;
        }
        // Top Right
        if (hitX == SXmax && hitY == SYmax)
        {
            return true;
        }
        // Bottim Right
        if (hitX == SXmax && hitY == SYmin)
        {
            return true;
        }
        // Bottom Left
        if (hitX == SXmin && hitY == SYmin)
        {
            return true;
        }

        return false;
    }
}

