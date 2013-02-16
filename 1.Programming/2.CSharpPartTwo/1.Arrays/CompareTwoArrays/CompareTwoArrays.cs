using System;

class CompareTwoArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[] arrA = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrA[i] = int.Parse(Console.ReadLine());
        }

        int[] arrB = new int[m];
        for (int i = 0; i < m; i++)
        {
            arrB[i] = int.Parse(Console.ReadLine());
        }

        if (arrA.Length != arrB.Length)
        {
            Console.WriteLine("False");
        }
        else
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] != arrB[i])
                {
                    Console.WriteLine("False");
                    return;
                }
            }
            Console.WriteLine("True");
        }
    }
}



