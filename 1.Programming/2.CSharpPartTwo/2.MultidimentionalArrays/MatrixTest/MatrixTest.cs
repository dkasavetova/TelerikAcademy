using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MatrixTest
{
    static void Main()
    {
        Matrix a = new Matrix(new int[,] { { 1, 2 }, { 3, 5 } });
        Matrix b = new Matrix(new int[,] { { 1, 2 }, { 3, 4 } });

        Matrix c = new Matrix(new int[,] { {6, 3, 0}, {2, 5, 1}, {9, 8, 6} });
        Matrix d = new Matrix(new int[,] { { 7, 4 }, { 6, 7 }, { 5, 0 } });

        Matrix add = a + b;
        Matrix sub = a - b;
        Matrix mul = c * d;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(add);
        Console.WriteLine(sub);
        Console.WriteLine(mul);
    }
}

