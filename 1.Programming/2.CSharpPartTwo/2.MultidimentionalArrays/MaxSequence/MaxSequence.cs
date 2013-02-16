using System;

class MaxSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] inputRow = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = inputRow[j];
            }
        }

        int colLen, colStartRow, colStartCol;
        int rowLen, rowStartRow, rowStartCol;
        int leftDiaLen, leftDiaStartRow, leftDiaStartCol;
        int rightDiaLen, rightDiaStartRow, rightDiaStartCol;
        LongestSequenceByCol(matrix, out colLen, out colStartRow, out colStartCol);
        LongestSequenceByRow(matrix, out rowLen, out rowStartRow, out rowStartCol);
        LongestSequenceByLeftDia(matrix, out leftDiaLen, out leftDiaStartRow, out leftDiaStartCol);
        LongestSequenceByRightDia(matrix, out rightDiaLen, out rightDiaStartRow, out rightDiaStartCol);

        int maxLen = Math.Max(colLen, Math.Max(rowLen, Math.Max(leftDiaLen, rightDiaLen)));

        if (maxLen == colLen)
        {
            for (int i = colStartRow; i < colStartRow + colLen; i++)
            {
                Console.Write(matrix[i, colStartCol] + " ");
            }
        }
        else if (maxLen == rowLen)
        {
            for (int i = rowStartCol; i < rowStartCol + rowLen; i++)
            {
                Console.Write(matrix[rowStartRow, i] + " ");
            }
        }
        else if (maxLen == leftDiaLen)
        {
            for (int i = leftDiaStartRow, j = leftDiaStartCol; j < leftDiaStartCol + leftDiaLen; i--, j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        else if (maxLen == rightDiaLen)
        {
            for (int i = rightDiaStartRow, j = rightDiaStartCol; i > rightDiaStartRow - rightDiaLen; i--, j--)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
        

    static void LongestSequenceByRow(
        string[,] matrix, out int length, out int startRowIndex, out int startColIndex)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int longestLengthByRow = 0;
        int currentLengthByRow = 0;
        int longestLengthByRowStartColIndex = 0;
        int currentLengthByRowStartColIndex = 0;

        int longestLengthForAllRows = 0;
        int longestLengthForAllRowsStartRowIndex = 0;
        int longestLengthForAllRowsStartColIndex = 0;


        for (int i = 0; i < n; i++)
        {
            currentLengthByRowStartColIndex = 0;
            currentLengthByRow = 1;

            longestLengthByRow = 0;

            for (int j = 1; j < m; j++)
            {
                if (matrix[i, j - 1] == matrix[i, j])
                {
                    currentLengthByRow++;
                }
                else
                {
                    if (currentLengthByRow > longestLengthByRow)
                    {
                        longestLengthByRow = currentLengthByRow;
                        longestLengthByRowStartColIndex = currentLengthByRowStartColIndex;
                    }

                    currentLengthByRowStartColIndex = j;
                    currentLengthByRow = 1;
                }
            }
            if (currentLengthByRow > longestLengthByRow)
            {
                longestLengthByRow = currentLengthByRow;
                longestLengthByRowStartColIndex = currentLengthByRowStartColIndex;
            }

            if (longestLengthByRow > longestLengthForAllRows)
            {
                longestLengthForAllRows = longestLengthByRow;
                longestLengthForAllRowsStartColIndex = longestLengthByRowStartColIndex;
                longestLengthForAllRowsStartRowIndex = i;
            }
        }

        length = longestLengthForAllRows;
        startRowIndex = longestLengthForAllRowsStartRowIndex;
        startColIndex = longestLengthForAllRowsStartColIndex;
    }

    static void LongestSequenceByCol(
        string[,] matrix, out int length, out int startRowIndex, out int startColIndex)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int longestLengthByCol = 0;
        int currentLengthByCol = 0;
        int longestLengthByColStartRowIndex = 0;
        int currentLengthByColStartRowIndex = 0;

        int longestLengthForAllCols = 0;
        int longestLengthForAllColsStartRowIndex = 0;
        int longestLengthForAllColsStartColIndex = 0;

        for (int j = 0; j < m; j++)
        {
            currentLengthByColStartRowIndex = 0;
            currentLengthByCol = 1;

            longestLengthByCol = 0;

            for (int i = 1; i < n; i++)
            {
                if (matrix[i - 1, j] == matrix[i, j])
                {
                    currentLengthByCol++;
                }
                else
                {
                    if (currentLengthByCol > longestLengthByCol)
                    {
                        longestLengthByCol = currentLengthByCol;
                        longestLengthByColStartRowIndex = currentLengthByColStartRowIndex;
                    }

                    currentLengthByColStartRowIndex = i;
                    currentLengthByCol = 1;
                }
            }

            if (currentLengthByCol > longestLengthByCol)
            {
                longestLengthByCol = currentLengthByCol;
                longestLengthByColStartRowIndex = currentLengthByColStartRowIndex;
            }

            if (longestLengthByCol > longestLengthForAllCols)
            {
                longestLengthForAllCols = longestLengthByCol;
                longestLengthForAllColsStartRowIndex = longestLengthByColStartRowIndex;
                longestLengthForAllColsStartColIndex = j;
            }
        }

        length = longestLengthForAllCols;
        startRowIndex = longestLengthForAllColsStartRowIndex;
        startColIndex = longestLengthForAllColsStartColIndex; 

    }

    static void LongestSequenceByLeftDia(
        string[,] matrix, out int length, out int startRowIndex, out int startColIndex)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int longestLengthByDia = 0;
        int currentLengthByDia = 0;
        int longestLengthByDiaStartRowIndex = 0;
        int longestLengthByDiaStartColIndex = 0;
        int currentLengthByDiaStartRowIndex = 0;
        int currentLengthByDiaStartColIndex = 0;

        int longestLengthForAllDias = 0;
        int longestLengthForAllDiasStartRowIndex = 0;
        int longestLengthForAllDiasStartColIndex = 0;

        int i = 0;
        int j = 0;
        int r = 0;

        for (r = 0; r < n; r++)
        {
            currentLengthByDiaStartRowIndex = r;
            currentLengthByDiaStartColIndex = 0;
            currentLengthByDia = 1;

            longestLengthByDia = 0;

            i = r - 1;
            j = 1;

            while (j < m && i >= 0)
            {
                if (matrix[i + 1, j - 1] == matrix[i, j])
                {
                    currentLengthByDia++;
                }
                else
                {
                    if (currentLengthByDia > longestLengthByDia)
                    {
                        longestLengthByDia = currentLengthByDia;
                        longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                        longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
                    }

                    currentLengthByDiaStartRowIndex = i;
                    currentLengthByDiaStartColIndex = j;
                    currentLengthByDia = 1;
                }
                j++;
                i--;
            }
            if (currentLengthByDia > longestLengthByDia)
            {
                longestLengthByDia = currentLengthByDia;
                longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
            }

            if (longestLengthByDia > longestLengthForAllDias)
            {
                longestLengthForAllDias = longestLengthByDia;
                longestLengthForAllDiasStartRowIndex = longestLengthByDiaStartRowIndex;
                longestLengthForAllDiasStartColIndex = longestLengthByDiaStartColIndex;
            }
        }

        for (r = 1; r < m; r++)
        {
            currentLengthByDiaStartRowIndex = n - 1;
            currentLengthByDiaStartColIndex = r;
            currentLengthByDia = 1;

            longestLengthByDia = 0;

            i = n - 2;
            j = r + 1;

            while (j < m && i >= 0)
            {
                if (matrix[i + 1, j - 1] == matrix[i, j])
                {
                    currentLengthByDia++;
                }
                else
                {
                    if (currentLengthByDia > longestLengthByDia)
                    {
                        longestLengthByDia = currentLengthByDia;
                        longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                        longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
                    }

                    currentLengthByDiaStartRowIndex = i;
                    currentLengthByDiaStartColIndex = j;
                    currentLengthByDia = 1;
                }

                j++;
                i--;
            } if (currentLengthByDia > longestLengthByDia)
            {
                longestLengthByDia = currentLengthByDia;
                longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
            }

            if (longestLengthByDia > longestLengthForAllDias)
            {
                longestLengthForAllDias = longestLengthByDia;
                longestLengthForAllDiasStartRowIndex = longestLengthByDiaStartRowIndex;
                longestLengthForAllDiasStartColIndex = longestLengthByDiaStartColIndex;
            }
        }

        length = longestLengthForAllDias;
        startColIndex = longestLengthForAllDiasStartColIndex;
        startRowIndex = longestLengthForAllDiasStartRowIndex;
    }

    static void LongestSequenceByRightDia(
        string[,] matrix, out int length, out int startRowIndex, out int startColIndex)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int longestLengthByDia = 0;
        int currentLengthByDia = 0;
        int longestLengthByDiaStartRowIndex = 0;
        int longestLengthByDiaStartColIndex = 0;
        int currentLengthByDiaStartRowIndex = 0;
        int currentLengthByDiaStartColIndex = 0;

        int longestLengthForAllDias = 0;
        int longestLengthForAllDiasStartRowIndex = 0;
        int longestLengthForAllDiasStartColIndex = 0;

        int i = 0;
        int j = 0;
        int r = 0;

        for (r = 0; r < m; r++)
        {
            currentLengthByDiaStartRowIndex = n - 1;
            currentLengthByDiaStartColIndex = r;
            currentLengthByDia = 1;

            longestLengthByDia = 0;

            i = n - 2;
            j = r - 1;

            while (j >= 0 && i >= 0)
            {
                if (matrix[i + 1, j + 1] == matrix[i, j])
                {
                    currentLengthByDia++;
                }
                else
                {
                    if (currentLengthByDia > longestLengthByDia)
                    {
                        longestLengthByDia = currentLengthByDia;
                        longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                        longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
                    }

                    currentLengthByDiaStartRowIndex = i;
                    currentLengthByDiaStartColIndex = j;
                    currentLengthByDia = 1;
                }
                j--;
                i--;
            }
            if (currentLengthByDia > longestLengthByDia)
            {
                longestLengthByDia = currentLengthByDia;
                longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
            }

            if (longestLengthByDia > longestLengthForAllDias)
            {
                longestLengthForAllDias = longestLengthByDia;
                longestLengthForAllDiasStartRowIndex = longestLengthByDiaStartRowIndex;
                longestLengthForAllDiasStartColIndex = longestLengthByDiaStartColIndex;
            }
        }

        for (r = n - 2; r >= 0; r--)
        {
            currentLengthByDiaStartRowIndex = r;
            currentLengthByDiaStartColIndex = m - 1;
            currentLengthByDia = 1;

            longestLengthByDia = 0;

            i = r - 1;
            j = m - 2;

            while (j>= 0 && i >= 0)
            {
                if (matrix[i + 1, j + 1] == matrix[i, j])
                {
                    currentLengthByDia++;
                }
                else
                {
                    if (currentLengthByDia > longestLengthByDia)
                    {
                        longestLengthByDia = currentLengthByDia;
                        longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                        longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
                    }

                    currentLengthByDiaStartRowIndex = i;
                    currentLengthByDiaStartColIndex = j;
                    currentLengthByDia = 1;
                }

                j--;
                i--;
            }
            if (currentLengthByDia > longestLengthByDia)
            {
                longestLengthByDia = currentLengthByDia;
                longestLengthByDiaStartRowIndex = currentLengthByDiaStartRowIndex;
                longestLengthByDiaStartColIndex = currentLengthByDiaStartColIndex;
            }

            if (longestLengthByDia > longestLengthForAllDias)
            {
                longestLengthForAllDias = longestLengthByDia;
                longestLengthForAllDiasStartRowIndex = longestLengthByDiaStartRowIndex;
                longestLengthForAllDiasStartColIndex = longestLengthByDiaStartColIndex;
            }
        }

        length = longestLengthForAllDias;
        startColIndex = longestLengthForAllDiasStartColIndex;
        startRowIndex = longestLengthForAllDiasStartRowIndex;
    }

}

