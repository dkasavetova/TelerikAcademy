using System;

class Presents
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int a1 = int.Parse(input[0]);
        int b1 = int.Parse(input[1]);
        int x1 = int.Parse(input[2]);
        int y1 = int.Parse(input[3]);

        int a = Math.Min(a1, b1);
        int b = Math.Max(a1, b1);
        int x = Math.Min(x1, y1);
        int y = Math.Max(x1, y1);

        int[,] rects = new int[4, 4];

        rects[0, 0] = b + y;
        rects[0, 1] = Math.Max(a, x);
        rects[1, 0] = b + x;
        rects[1, 1] = Math.Max(a, y);
        rects[2, 0] = a + x;
        rects[2, 1] = Math.Max(b, y);
        rects[3, 0] = a + y;
        rects[3, 1] = Math.Max(b, x);

        for (int i = 0; i < 4; i++)
        {
            rects[i, 2] = rects[i, 0] * rects[i, 1];
            rects[i, 3] = 2 * rects[i, 0] + 2 * rects[i, 1];
        }

        int minIndex = 0;
        for (int i = 1; i < 4; i++)
        {
            if (rects[minIndex, 2] >= rects[i, 2])
            {
                if (rects[minIndex, 3] > rects[i, 3]) 
                {
                    minIndex = i;
                }
            }
        }

        Console.WriteLine(
            Math.Min(rects[minIndex, 0], rects[minIndex, 1]) + " " + 
            Math.Max(rects[minIndex, 0], rects[minIndex, 1]));
    }
}

