using System;

class PrintMatrix
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        int n = 4;
        int[,] m = new int[n, n];

        //A
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = n * j + i + 1;
            }
        }
        PrintFormatedMatrix(m);
        Console.WriteLine();


        //B
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j % 2 == 0)
                {
                    m[i, j] = n * j + i + 1;
                }
                else
                {
                    m[i, j] = n * j + n - i;
                }
            }
        }

        PrintFormatedMatrix(m);
        Console.WriteLine();


        //C
        int numberToFill = 1;

        int beginRow = n - 1;
        int row = beginRow;
        int col = 0;

        while (beginRow >= 0)
        {  
            while (row < n)
            {
                m[row, col] = numberToFill;
                numberToFill++;
                row++;
                col++;
            }
            beginRow--;
            row = beginRow;
            col = 0;
        }

        int beginCol = 1;
        row = 0;
        col = 1;

        while (beginCol < n)
        {
            while (col < n)
            {
                m[row, col] = numberToFill;
                numberToFill++;
                row++;
                col++;
            }
            beginCol++;
            row = 0;
            col = beginCol;
        }

        PrintFormatedMatrix(m);
        Console.WriteLine();


        //D
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = 0;
            }
        }

        numberToFill = 1;
        row = -1;
        col = 0;
        int direction = 0; // 0 = down, 1 = left, 2 = up, 3 = right

        while (numberToFill <= n * n)
        {
            if (CanMove(m, row, col, direction))
            {
                Move(ref row, ref col, direction);

                m[row, col] = numberToFill;
                numberToFill++;
            }
            else
            {
                ChangeDirection(ref direction);
            }
        }

        PrintFormatedMatrix(m);
        Console.WriteLine();
    }

    static void Move(ref int row, ref int col, int direction)
    {
        switch (direction)
        {
            case 0:
                row++;
                break;
            case 1:
                col++;
                break;
            case 2:
                row--;
                break;
            case 3:
                col--;
                break;
            default:
                break;
        }
    }

    static bool CanMove(int[,] m, int row, int col, int direction)
    {
        int rowsCount = m.GetLength(0);
        int colsCount = m.GetLength(1);

        switch (direction)
        {
            case 0:
                if (row + 1 < rowsCount && m[row + 1, col] == 0)
                {
                    return true;
                }
                break;
            case 1:
                if (col + 1 < colsCount && m[row, col + 1] == 0)
                {
                    return true;
                }
                break;
            case 2:
                if (row - 1 >= 0 && m[row - 1, col] == 0)
                {
                    return true;
                }
                break;
            case 3:
                if (col - 1 >= 0 && m[row, col - 1] == 0)
                {
                    return true;
                }
                break;
            default:
                return false;
        }
        return false;
    }

    static void ChangeDirection(ref int direction)
    {
        direction = (direction + 1) % 4;
    }

    static void PrintFormatedMatrix(int[,] matrix)
    {
        int rowsCount = matrix.GetLength(0);
        int colsCount = matrix.GetLength(1);

        int maxNumberLength = (rowsCount * colsCount).ToString().Length + 1;
        string formatString = "{0," + maxNumberLength + "} ";

        for (int i = 0; i < rowsCount; i++)
        {
            for (int j = 0; j < colsCount; j++)
            {
                //removing the indent before the 1st column
                //if (j == 0)
                //{
                //    Console.Write(matrix[i, j] + " ");
                //}
                //else
                //{
                    Console.Write(formatString, matrix[i, j]);
                //}
            }
            Console.WriteLine();
        }
    }
}

