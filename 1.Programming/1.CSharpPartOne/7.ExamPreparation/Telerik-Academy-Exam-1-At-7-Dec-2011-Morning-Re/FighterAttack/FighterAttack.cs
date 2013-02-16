using System;

class FighterAttack
{

    static int pX1, pY1, pX2, pY2, fX, fY, d;
    static int pULX, pULY, pDRX, pDRY;
    static int hDiX, hDiY, hFX, hFY, hUX, hUY, hDX, hDY;
    static int sum = 0;

    static void Main()
    {
        ReadInput();

        LocatePlantPosition();
        LocateHitsPosition();

        CalculateDamage(hDiX, hDiY, 100);
        CalculateDamage(hFX, hFY, 75);
        CalculateDamage(hUX, hUY, 50);
        CalculateDamage(hDX, hDY, 50);

        PrintOutput();
    }

    static void PrintOutput()
    {
        Console.WriteLine(sum + "%");
    }

    static void CalculateDamage(int hitX, int hitY, int dmg)
    {
        if (hitX >= pULX && hitX <= pDRX)
        {
            if (hitY <= pULY && hitY >= pDRY)
            {
                sum += dmg;
            }
        }
    }

    static void LocateHitsPosition()
    {
        hDiX = fX + d;
        hDiY = fY;

        hFX = hDiX + 1;
        hFY = hDiY;

        hUX = hDiX;
        hUY = hDiY + 1;

        hDX = hDiX;
        hDY = hDiY - 1;
    }

    static void LocatePlantPosition()
    {
        pULX = pX1 < pX2 ? pX1 : pX2;
        pULY = pY1 > pY2 ? pY1 : pY2;
        pDRX = pX1 > pX2 ? pX1 : pX2;
        pDRY = pY1 < pY2 ? pY1 : pY2;
    }

    static void ReadInput()
    {
        pX1 = int.Parse(Console.ReadLine());
        pY1 = int.Parse(Console.ReadLine());
        pX2 = int.Parse(Console.ReadLine());
        pY2 = int.Parse(Console.ReadLine());
        fX = int.Parse(Console.ReadLine());
        fY = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
    }
}

