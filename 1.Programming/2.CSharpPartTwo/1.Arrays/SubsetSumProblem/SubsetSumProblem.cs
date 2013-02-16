using System;

class SubsetSumProblem
{
    static void Main()
    {
        int[] a = { 2, 1, 2, 4, 3, 5, 2, 6};
        int sum = 14;

        int n = 0;
        int p = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 0) n += a[i];
            if (a[i] > 0) p += a[i];
        }

        bool[,] q = new bool[a.Length, Math.Abs(n) + 1 + p];

        for (int s = n; s <= p; s++)
        {
            q[0, s + Math.Abs(n)] = (a[0] == s);
        }

        for (int i = 1; i < a.Length; i++)
        {
            for (int s = n; s <= p; s++)
            {
                //TODO: Do it without try catch
                bool bla;
                try
                {
                    bla = q[i - 1, s + Math.Abs(n) - a[i]];
                }
                catch (IndexOutOfRangeException) 
                {
                    bla = false;
                }

                q[i, s + Math.Abs(n)] = q[i - 1, s + Math.Abs(n)] || (a[i] == s) || bla;
            }
        }

        //Print table
        Console.Write("  ");
        for (int i = n; i <= p; i++)
        {
            Console.Write("{0,3}", i);
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < q.GetLength(0); i++)
        {
            for (int j = 0; j < q.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write("{0,-4}", a[i]);
                }
                Console.Write(q[i, j] ? "1  " : "0  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        if (q[a.Length - 1, sum + Math.Abs(n)])
        {
            Console.WriteLine("yes");
            //Find subset elements
            int num = sum;
            int i = a.Length - 1;
            int j = sum + Math.Abs(n);
            while (num > 0)
            {
                while (i - 1 >= 0 && q[i - 1,j] == true)
                {
                    i--;
                }
                Console.WriteLine(a[i]);
                num -= a[i];
                j = num + Math.Abs(n);
                i = a.Length - 1;
            }
        }
        else
	    {
            Console.WriteLine("no");
	    }
    }
}

