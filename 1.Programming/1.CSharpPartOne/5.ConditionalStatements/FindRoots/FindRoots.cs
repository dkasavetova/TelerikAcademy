using System;

class FindRoots
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int discriminant = b * b - 4 * a * c;

        double? x1 = null, x2 = null;

        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
        }
        else if (discriminant == 0)
        {
            x1 = -b / (2 * a);
            x2 = x1;
        }

        if (x1.HasValue)
        {
            if (x1 == x2)
            {
                Console.WriteLine("x1 = {0}", x1);
            }
            else
            {
                Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
            }
        }
        else
        {
            Console.WriteLine("No real roots!");
        }
    }
}

