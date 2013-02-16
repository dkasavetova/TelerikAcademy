using System.IO;

class MaxPlatformInMatrix
{
    static void Main()
    {
        string inputFile = "test.000.in.txt";
        string outputFile = "test.000.out.txt";
        int[,] matrix;

        using (StreamReader reader = new StreamReader(inputFile))
        {
            int n = int.Parse(reader.ReadLine());
            matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] line = reader.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }
        }

        int sum;
        FindMaxPlatform(matrix, 2, out sum);

        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            writer.WriteLine(sum);
        }

    }

    public static void FindMaxPlatform(
        int[,] matrix, int platformSize, out int sum)
    {
        int currentSum = 0;
        sum = -1;

        for (int i = 0; i <= matrix.GetLength(0) - platformSize; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - platformSize; j++)
            {
                currentSum = 0;
                for (int ii = 0; ii < platformSize; ii++)
                {
                    for (int jj = 0; jj < platformSize; jj++)
                    {

                        currentSum += matrix[i + ii, j + jj];
                    }
                }
                if (currentSum > sum)
                {
                    sum = currentSum;
                }
            }
        }
    }
}
