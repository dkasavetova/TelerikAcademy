using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int width, height, depth;
    static char[, ,] cube;
    static int[] lettersCount = new int[26];


    static void Main(string[] args)
    {
        ReadCube();
        int counter = 0;
        for (int w = 1; w < width - 1; w++)
        {
            for (int h = 1; h < height -1; h++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    if (cube[w,h,d] == cube[w+1,h,d] && cube[w,h,d] == cube[w-1,h,d] &&
                       cube[w, h, d] == cube[w, h + 1, d] && cube[w,h,d] == cube[w, h-1, d] &&
                        cube[w, h, d] == cube[w, h, d + 1] && cube[w, h, d] == cube[w, h, d-1]
                        )
                    {
                        counter++;
                        lettersCount[cube[w, h, d] - 'A']++;
                    }

                }
            }
        }
        Console.WriteLine(counter);
        for (int i = 0; i < lettersCount.Length; i++)
        {
            if (lettersCount[i] != 0 )
            {
                Console.WriteLine("{0} {1}", (char)(i + 'A'), lettersCount[i]);
            }
        }

    }

    private static void ReadCube()
    {
        string[] dims = Console.ReadLine().Split(' ');
        width = int.Parse(dims[0]);
        height = int.Parse(dims[1]);
        depth = int.Parse(dims[2]);

        cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = line[d][w];
                }
            }
        }
    }
}

