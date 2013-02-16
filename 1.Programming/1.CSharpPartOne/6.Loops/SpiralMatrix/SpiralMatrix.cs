using System;

class SpiralMatrix
{
    static int n = 20;
    static int[,] matrix = new int[n, n];

    static int numberToFill = 1;
    static int direction = 0;
    static int i = 0;
    static int j = 0;

    static void Main()
    {
        FillMatix();
        PrintMatrix();
    }

    static void FillMatix()
    {
        while (numberToFill <= n * n)
        {
            matrix[i, j] = numberToFill++;

            if (NextIsOut() || NextIsFilled())
            {
                ChangeDirection();
            }
            GoToNext();
        }   
    }

    static bool NextIsOut() 
    {
        switch (direction)
        {
            case 0:
                if (j + 1 >= n)
                {
                    return true;
                }
                break;
            case 1:
                if (i + 1 >= n)
                {
                    return true;
                }
                break;
            case 2:
                if (j - 1 < 0)
                {
                    return true;
                }
                break;
            case 3:
                if (i - 1 < 0)
                {
                    return true;
                }
                break;
            default:
                break;
        }
        return false;
    }

    static bool NextIsFilled()
    {
        switch (direction)
        {
            case 0:
                if (matrix[i, j + 1] != 0)
                {
                    return true;
                }
                break;
            case 1:
                if (matrix[i + 1, j] != 0)
                {
                    return true;
                }
                break;
            case 2:
                if (matrix[i, j - 1] != 0)
                {
                    return true;
                }
                break;
            case 3:
                if (matrix[i - 1, j] != 0)
                {
                    return true;
                }
                break;
            default:
                break;
        }
        return false;
    }

    static void ChangeDirection()
    {
        direction = (direction + 1) % 4;
    }

    static void GoToNext()
    {
        switch (direction)
        {
            case 0:
                j++;
                break;
            case 1:
                i++;
                break;
            case 2:
                j--;
                break;
            case 3:
                i--;
                break;
            default:
                break;
        }
    }

    static void PrintMatrix()
    {
        int maxNumLen = (n * n).ToString().Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int currentNumLen = matrix[i, j].ToString().Length;
                int leftPadding = 0;

                if (j == 0)
                {
                    leftPadding = maxNumLen - currentNumLen - 1;
                }
                else
                {
                    leftPadding = maxNumLen - currentNumLen;
                }

                Console.Write("{0}{1} ", new string(' ', leftPadding), matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

