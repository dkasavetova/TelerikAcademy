using System;

class SandGlass
{
    static int n;

    static void Main()
    {
        ReadInput();
        Solve();

    }

    static void Solve()
    {
        int starCount = n;
        int dotCount = 0;

        while (starCount > 0)
        {
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', starCount));
            Console.WriteLine(new string('.', dotCount));

            starCount -= 2;
            dotCount++;
        }
        starCount = 3;
        dotCount = (n - starCount) / 2;
        while (starCount <= n)
        {
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', starCount));
            Console.WriteLine(new string('.', dotCount));

            starCount += 2;
            dotCount--;
        }
    }

    static void ReadInput()
    {
        n = int.Parse(Console.ReadLine());
    }
}

