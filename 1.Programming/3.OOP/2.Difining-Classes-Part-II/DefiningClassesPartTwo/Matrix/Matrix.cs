using System;
using System.Text;

class Matrix<T>
{
    //Fields
    private T[,] matrix;

    //Constructors
    public Matrix(int rows, int cols)
    {
        matrix = new T[rows, cols];
    }

    public Matrix(T[,] arr)
    {
        matrix = (T[,])arr.Clone();
    }

    //Properties
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

    public T this[int row, int col]
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

    //Methods
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

    public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
    {
        if (a.RowsCount != b.RowsCount || a.ColsCount != b.ColsCount)
        {
            throw new ArgumentException("Can't add matrices of different dimensions!");
        }

        Matrix<T> r = new Matrix<T>(a.RowsCount, a.ColsCount);

        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < a.ColsCount; j++)
            {
                r[i, j] = (dynamic)a[i, j] + b[i, j];
            }
        }

        return r;
    }

    public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
    {
        if (a.RowsCount != b.RowsCount || a.ColsCount != b.ColsCount)
        {
            throw new ArgumentException("Can't substract matrices of different dimensions!");
        }

        Matrix<T> r = new Matrix<T>(a.RowsCount, a.ColsCount);

        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < a.ColsCount; j++)
            {
                r[i, j] = (dynamic)a[i, j] - b[i, j];
            }
        }

        return r;
    }

    public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
    {
        if (a.ColsCount != b.RowsCount)
        {
            throw new ArgumentException("The number or columns of the" +
                "first matrix must be equal to the number of rows of the second matrix!");
        }

        Matrix<T> r = new Matrix<T>(a.RowsCount, b.ColsCount);

        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < b.ColsCount; j++)
            {
                r[i, j] = (dynamic)0;
                for (int k = 0; k < a.ColsCount; k++)
                {
                    r[i, j] += (dynamic)a[i, k] * b[k, j];
                }
            }
        }

        return r;
    }

    public static bool operator true(Matrix<T> a)
    {
        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < a.ColsCount; j++)
            {
                if (a[i,j] != (dynamic)0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool operator false(Matrix<T> a)
    {
        for (int i = 0; i < a.RowsCount; i++)
        {
            for (int j = 0; j < a.ColsCount; j++)
            {
                if (a[i, j] != (dynamic)0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}

