using System;

class InitArray
{
    static void Main()
    {
        int n = 20;
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
            Console.WriteLine("[{0}] = {1}", i, arr[i]);
        }
    }
}
