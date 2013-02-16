using System;
using System.Text;

class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols)
    {
        matrix = new int[rows, cols];
    }

    public Matrix(int[,] arr)
    {
        matrix = (int[,])arr.Clone();
    }

    public int RowsCount
    {
        get
        {
            return matrix.GetLength(0);
        }
    }

    public int ColsCount
    {
        get
        {
            return matrix.GetLength(1);
        }
    }

    public int this[int row, int col]
    {
        get
        {
            return matrix[row, col];
        }
        set
        {
            matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                str.Append(matrix[i, j] + " ");
            }
            str.Append("\n");
        }
        return str.ToString();
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.RowsCount != b.RowsCount || a.ColsCount != b.ColsCount)
        {
            throw new ArgumentException("Can't add matrices of different dimentions!");
        }

        Matrix r = new Matrix(a.RowsCount, a.ColsCount);

        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < a.ColsCount; j++)
            {
                r[i, j] = a[i, j] + b[i, j];
            }
        }

        return r;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.RowsCount != b.RowsCount || a.ColsCount != b.ColsCount)
        {
            throw new ArgumentException("Can't substract matrices of different dimentions!");
        }

        Matrix r = new Matrix(a.RowsCount, a.ColsCount);

        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < a.ColsCount; j++)
            {
                r[i, j] = a[i, j] - b[i, j];
            }
        }

        return r;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.ColsCount != b.RowsCount)
        {
            throw new ArgumentException("The number or columns of the" + 
                "first matrix must be equal to the number of rows of the second matrix!");
        }

        Matrix r = new Matrix(a.RowsCount, b.ColsCount);

        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < b.ColsCount; j++)
            {
                r[i, j] = 0;
                for (int k = 0; k < a.ColsCount; k++)
                {
                    r[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return r;
    }
}

