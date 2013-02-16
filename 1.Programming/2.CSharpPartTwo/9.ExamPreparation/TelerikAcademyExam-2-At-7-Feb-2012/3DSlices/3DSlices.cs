using System;

class Program
{
    static int width, height, depth;
    static int[, ,] cube;
    static int[] widthVal, heightVal, depthVal;

    static int cubeSum = 0;
    static int answer = 0;

    static void Main()
    {
        ReadCube();

        Solve(widthVal, cubeSum);
        Solve(heightVal, cubeSum);
        Solve(depthVal, cubeSum);

        Console.WriteLine(answer);
    }

    private static void Solve(int[] vals, int total)
    {
        //int right = total - vals[0];
        //int left = vals[0];

        //for (int i = 0; i < vals.Length - 1; i++)
        //{
        //    if (left == right)
        //    {
        //        answer++;
        //    }
        //    else
        //    {
        //        if (i != vals.Length - 2)
        //        {
        //            left += vals[i + 1];
        //            right -= vals[i];
        //        }
        //    }
        //}

        int left = 0;
        int right = total;

        for (int i = 0; i < vals.Length-1 ; i++)
        {
            left += vals[i];
            right -= vals[i];

            if (left == right)
            {
                answer++;
            }
        }
    }

    private static void ReadCube()
    {
        string[] dims = Console.ReadLine().Split();
        width = int.Parse(dims[0]);
        height = int.Parse(dims[1]);
        depth = int.Parse(dims[2]);

        cube = new int[width, height, depth];
        

        widthVal = new int[width];
        heightVal = new int[height];
        depthVal = new int[depth];

        for (int h = 0; h < height; h++)
        {
            string[] line = Console.ReadLine().Split(new char[]{' ', '|'}, StringSplitOptions.RemoveEmptyEntries);
            for (int w = 0; w < width; w++)
            {
                for (int d = 0; d < depth; d++)
                {
                    cube[w, h, d] = int.Parse(line[d * width + w]);

                    heightVal[h] += cube[w, h, d];
                    widthVal[w] += cube[w, h, d];
                    depthVal[d] += cube[w, h, d];

                    cubeSum += cube[w, h, d];
                }
            }
        }
    }

}

