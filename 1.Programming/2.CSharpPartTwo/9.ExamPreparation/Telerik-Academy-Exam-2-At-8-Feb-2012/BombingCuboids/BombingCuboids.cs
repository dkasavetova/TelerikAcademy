using System;

class BombingCuboids
{
    static int width, height, depth;
    static char[, ,] cube;
    static int bombWidth, bombHeight, bombDepth, bombPower;
    static int[] destroyedCubesByColor = new int[26];
    static int destroyedCubesCount = 0;

    const char Empty = ' ';

    static void Main()
    {
        ReadCube();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            ReadBomb();
            ExplodeBomb();
            FallDown();
        }

        PrintResult();
    }

    static void PrintResult()
    {
        Console.WriteLine(destroyedCubesCount);

        for (int i = 0; i < destroyedCubesByColor.Length; i++)
        {
            if (destroyedCubesByColor[i] != 0)
            {
                Console.WriteLine("{0} {1}", (char)(i + 'A'), destroyedCubesByColor[i]);
            }
        }
    }

    static void FallDown()
    {
        int widthStart = Math.Max(bombWidth - bombPower, 0);
        int widthEnd = Math.Min(bombWidth + bombPower + 1, width);
        int depthStart = Math.Max(bombDepth - bombPower, 0);
        int depthEnd = Math.Min(bombDepth + bombPower + 1, depth);

        for (int w = widthStart; w < widthEnd; w++)
        {
            for (int d = depthStart; d < depthEnd; d++)
            {
                int a = 0;
                int b = 1;
                while (b < height)
                {
                    if (cube[w, a, d] != Empty)
                    {
                        a++;
                        b++;
                    }
                    else
                    {
                        if (cube[w, b, d] != Empty)
                        {
                            char temp = cube[w, a, d];
                            cube[w, a, d] = cube[w, b, d];
                            cube[w, b, d] = temp;
                        }
                        else
                        {
                            b++;
                        }
                    }
                }
            }
        }
    }

    //static void ExplodeBomb()
    //{
    //    for (int h = bombHeight - bombPower; h <= bombHeight + bombPower; h++)
    //    {
    //        for (int w = bombWidth - bombPower; w <= bombWidth + bombPower; w++)
    //        {
    //            for (int d = bombDepth - bombPower; d <= bombDepth + bombPower; d++)
    //            {
    //                if (h >= 0 && h < height && w >= 0 && w < width && d >= 0 && d < depth)
    //                {
    //                    if (cube[w, h, d] != Empty)
    //                    {
    //                        if ((bombHeight - h) * (bombHeight - h) + (bombWidth - w) * (bombWidth - w) + (bombDepth - d) * (bombDepth - d) <= bombPower * bombPower)
    //                        {
    //                            cube[w, h, d] = Empty;
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}

    static void ExplodeBomb()
    {
        int heightStart = Math.Max(bombHeight - bombPower, 0);
        int heightEnd = Math.Min(bombHeight + bombPower + 1, height);
        int widthStart = Math.Max(bombWidth - bombPower, 0);
        int widthEnd = Math.Min(bombWidth + bombPower + 1, width);
        int depthStart = Math.Max(bombDepth - bombPower, 0);
        int depthEnd = Math.Min(bombDepth + bombPower + 1, depth);

        for (int h = heightStart; h < heightEnd; h++)
        {
            for (int w = widthStart; w < widthEnd; w++)
            {
                for (int d = depthStart; d < depthEnd; d++)
                {
                    if (cube[w, h, d] != Empty)
                    {
                        if ((bombHeight - h) * (bombHeight - h) + (bombWidth - w) * (bombWidth - w) + (bombDepth - d) * (bombDepth - d) <= bombPower * bombPower)
                        {
                            destroyedCubesCount++;
                            destroyedCubesByColor[cube[w, h, d] - 'A']++;
                            cube[w, h, d] = Empty;
                        }
                    }
                }
            }
        }
    }

    static void ReadBomb()
    {
        string[] bombInfo = Console.ReadLine().Split(' ');

        bombWidth = int.Parse(bombInfo[0]);
        bombHeight = int.Parse(bombInfo[1]);
        bombDepth = int.Parse(bombInfo[2]);
        bombPower = int.Parse(bombInfo[3]);
    }

    static void ReadCube()
    {
        string[] dims = Console.ReadLine().Split(' ');

        width = int.Parse(dims[0]);
        height = int.Parse(dims[1]);
        depth = int.Parse(dims[2]);

        cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] layer = Console.ReadLine().Split(' ');

            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = layer[d][w];
                }
            }
        }
    }

    static void PrintCube()
    {
        for (int h = 0; h < height; h++)
        {
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    Console.Write(cube[w,h,d]);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

