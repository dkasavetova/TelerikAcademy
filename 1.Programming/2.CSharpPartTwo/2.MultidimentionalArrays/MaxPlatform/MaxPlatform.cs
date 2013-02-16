using System;

class MaxPlatform
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] inputRow = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(inputRow[j]);
            }
        }

        int platformSize = 3;

        int maxSum = 0;
        int currentSum = 0;
        int maxRowIndex = 0;
        int maxColIndex = 0;

        for (int i = 0; i < n - platformSize + 1; i++)
        {
            for (int j = 0; j < m - platformSize + 1; j++)
            {
                currentSum = 0;

                for (int pi = 0; pi < platformSize; pi++)
                {
                    for (int pj = 0; pj < platformSize; pj++)
                    {
                        currentSum += matrix[i + pi, j + pj];
                    }
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }

        for (int i = maxRowIndex; i < maxRowIndex + platformSize; i++)
        {
            for (int j = maxColIndex; j < maxColIndex + platformSize; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}

