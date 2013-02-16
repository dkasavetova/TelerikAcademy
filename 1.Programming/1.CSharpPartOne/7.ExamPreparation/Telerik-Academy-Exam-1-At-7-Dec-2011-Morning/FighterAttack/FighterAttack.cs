using System;

class FighterAttack
{
    static void Main()
    {

        int Px1 = int.Parse(Console.ReadLine());
        int Py1 = int.Parse(Console.ReadLine());
        int Px2 = int.Parse(Console.ReadLine());
        int Py2 = int.Parse(Console.ReadLine());
        int Fx = int.Parse(Console.ReadLine());
        int Fy = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int plantULx = Px1 < Px2 ? Px1 : Px2;
        int plantULy = Py1 > Py2 ? Py1 : Py2;
        int plantDRx = Px1 > Px2 ? Px1 : Px2;
        int plantDRy = Py1 < Py2 ? Py1 : Py2;

        int hitPointX = Fx + D;
        int hitPointY = Fy;

        int hitPointLeftX = hitPointX;
        int hitPointLeftY = hitPointY + 1;

        int hitPointRightX = hitPointX;
        int hitPointRightY = hitPointY - 1;

        int hitPointFowardX = hitPointX + 1;
        int hitPointFowardY = hitPointY;

        int dmg = 0;

        if (hitPointX >= plantULx && hitPointX <= plantDRx && hitPointY >= plantDRy && hitPointY <= plantULy)
        {
            dmg += 100;
        }
        if (hitPointRightX >= plantULx && hitPointRightX <= plantDRx && hitPointRightY >= plantDRy && hitPointRightY <= plantULy)
        {
            dmg += 50;
        }
        if (hitPointLeftX >= plantULx && hitPointLeftX <= plantDRx && hitPointLeftY >= plantDRy && hitPointLeftY <= plantULy)
        {
            dmg += 50;
        }
        if (hitPointFowardX >= plantULx && hitPointFowardX <= plantDRx && hitPointFowardY >= plantDRy && hitPointFowardY <= plantULy)
        {
            dmg += 75;
        }

        Console.WriteLine("{0}%", dmg);
    }
}

