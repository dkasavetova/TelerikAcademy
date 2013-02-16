using System;

class SequenceSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = arr[0];
        int start = 0;
        int end = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
            end = i;
            while(sum > s)
            {
                sum -= arr[start];
                start++;
            }
            if (sum == s)
            {
                break;
            }
        }

        for (int i = start; i <= end ; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

