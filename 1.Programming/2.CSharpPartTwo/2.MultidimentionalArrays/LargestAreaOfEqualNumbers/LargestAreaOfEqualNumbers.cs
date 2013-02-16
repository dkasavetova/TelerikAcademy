using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Elem
{
    public Elem(int r, int c)
    {
        Row = r;
        Col = c;
    }
    public int Row;
    public int Col;
}

class LargestAreaOfEqualNumbers
{
    static string[,] matrix;
    static bool[,] used;
    static int n;
    static int m;
    static int max = 0;

    static void Main(string[] args)
    {
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());
        matrix = new string[n, m];
        used = new bool[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] inputRow = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = inputRow[j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (used[i, j] == false)
                {
                    int c = DFS(i, j);
                    if (c > max)
                    {
                        max = c;
                    }
                }
            }
        }
        Console.WriteLine(max);
    }

    static int DFS(int i, int j)
    {
        int currentMax = 0;
        Queue<Elem> q = new Queue<Elem>();

        q.Enqueue(new Elem(i, j));
        used[i, j] = true;

        while (q.Count != 0)
        {
            Elem t = q.Dequeue();
            currentMax++;
            int ii = t.Row;
            int jj = t.Col;

            if (ii + 1 < n && matrix[ii + 1, jj] == matrix[ii, jj])
            {
                if (used[ii + 1, jj] == false)
                {
                    used[ii + 1, jj] = true;
                    q.Enqueue(new Elem(ii + 1, jj));
                }
            }
            if (jj + 1 < m && matrix[ii, jj + 1] == matrix[ii, jj])
            {
                if (used[ii, jj + 1] == false)
                {
                    used[ii, jj + 1] = true;
                    q.Enqueue(new Elem(ii, jj + 1));
                }
            }
            if (ii - 1 >= 0 && matrix[ii - 1, jj] == matrix[ii, jj])
            {
                if (used[ii - 1, jj] == false)
                {
                    used[ii - 1, jj] = true;
                    q.Enqueue(new Elem(ii - 1, jj));
                }
            }
            if (jj - 1>= 0 && matrix[ii, jj - 1] == matrix[ii, jj])
            {
                if (used[ii, jj - 1] == false)
                {
                    used[ii, jj - 1] = true;
                    q.Enqueue(new Elem(ii, jj - 1));
                }
            }
        }
        return currentMax;
    }
}

