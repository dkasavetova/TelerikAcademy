using System;

class TestApp
{
    static void Main()
    {
        //Declare some matrices
        Matrix<int> a = new Matrix<int>(new int[,] { { 1, 2 }, { 3, 5 } });
        Matrix<int> b = new Matrix<int>(new int[,] { { 1, 2 }, { 3, 4 } });

        Matrix<int> c = new Matrix<int>(new int[,] { { 6, 3, 0 }, { 2, 5, 1 }, { 9, 8, 6 } });
        Matrix<int> d = new Matrix<int>(new int[,] { { 7, 4 }, { 6, 7 }, { 5, 0 } });

        //Test arithmetic operators
        Matrix<int> add = a + b;
        Matrix<int> sub = a - b;
        Matrix<int> mul = c * d;

        Console.WriteLine("Matrix A:\n" + a);
        Console.WriteLine("Matrix B:\n" + b);
        Console.WriteLine("Matrix A + B:\n" + add);
        Console.WriteLine("Matrix A - B:\n" + sub);
        Console.WriteLine();
        Console.WriteLine("Matrix C:\n" + c);
        Console.WriteLine("Matrix D:\n" + d);
        Console.WriteLine("Matrix C * D:\n" + mul);

        //Test boolean operators

        //Matrix A has non-zero fields => true
        if (a)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

        Matrix<double> e = new Matrix<double>(new double[,] { { 0 }, { 0 } }); 

        //Matrix E has only zero fields => false
        if (e)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

