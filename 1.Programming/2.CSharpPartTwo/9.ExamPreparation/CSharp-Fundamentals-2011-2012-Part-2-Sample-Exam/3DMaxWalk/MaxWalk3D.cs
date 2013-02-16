using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxWalk3D
{

    static int width, height, depth;
    static int[, ,] cube;
    static bool[, ,] isVisited;
    static int currWidth, currHeight, currDepth;
    static int maxWalkVal = 0;

    static void Main()
    {
        ReadInput();

        Solve(currWidth, currHeight, currDepth);
        Console.WriteLine(maxWalkVal);

    }

    static void Solve(int cw, int ch, int cd)
    {
        isVisited[cw, ch, cd] = true;
        maxWalkVal += cube[cw, ch, cd];
        int max = int.MinValue;
        int maxCnt = 0;
        int maxW = 0, maxH = 0, maxD = 0;

        for (int w = cw + 1; w < width; w++)
        {
            if (cube[w, ch, cd] > max)
            {
                max = cube[w, ch, cd];
                maxCnt = 1;
                maxW = w;
                maxH = ch;
                maxD = cd;
            }
            else if (cube[w, ch, cd] == max) 
            {
                maxCnt++;
            }
        }
        for (int w = cw - 1; w >= 0; w--)
        {
            if (cube[w, ch, cd] > max)
            {
                max = cube[w, ch, cd];
                maxCnt = 1;
                maxW = w;
                maxH = ch;
                maxD = cd;
            }
            else if (cube[w, ch, cd] == max)
            {
                maxCnt++;
            }
        }
        /////////////////////////////////////
        for (int h = ch + 1; h < height; h++)
        {
            if (cube[cw, h, cd] > max)
            {
                max = cube[cw, h, cd];
                maxCnt = 1;
                maxW = cw;
                maxH = h;
                maxD = cd;
            }
            else if (cube[cw, h, cd] == max)
            {
                maxCnt++;
            }
        }
        for (int h = ch - 1; h >= 0; h--)
        {
            if (cube[cw, h, cd] > max)
            {
                max = cube[cw, h, cd];
                maxCnt = 1;
                maxW = cw;
                maxH = h;
                maxD = cd;
            }
            else if (cube[cw, h, cd] == max)
            {
                maxCnt++;
            }
        }
        /////////////////////////////////////
        for (int d = cd + 1; d < depth; d++)
        {
            if (cube[cw, ch, d] > max)
            {
                max = cube[cw, ch, d];
                maxCnt = 1;
                maxW = cw;
                maxH = ch;
                maxD = d;
            }
            else if (cube[cw, ch, d] == max)
            {
                maxCnt++;
            }
        }
        for (int d = cd - 1; d >= 0; d--)
        {
            if (cube[cw, ch, d] > max)
            {
                max = cube[cw, ch, d];
                maxCnt = 1;
                maxW = cw;
                maxH = ch;
                maxD = d;
            }
            else if (cube[cw, ch, d] == max)
            {
                maxCnt++;
            }
        }

        if (maxCnt > 1)
        {
            return;
        }
        else if (isVisited[maxW, maxH, maxD])
        {
            return;
        }
        else
        {
            Solve(maxW, maxH, maxD);
        }
    }

    static void ReadInput()
    {
        string[] dims = Console.ReadLine().Split(' ');

        width = int.Parse(dims[0]);
        height = int.Parse(dims[1]);
        depth = int.Parse(dims[2]);

        cube = new int[width, height, depth];
        isVisited = new bool[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = int.Parse(line[d * width + w]);
                }
            }
        }

        currWidth = width / 2;
        currHeight = height / 2;
        currDepth = depth / 2;
    }
}
