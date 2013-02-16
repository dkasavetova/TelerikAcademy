using System;

class LargestElementEqualOrSmallerThanK
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int resultIndex = Array.BinarySearch(arr, k);

        if (resultIndex >= 0)
        {
            //elem with value k is found
            Console.WriteLine(arr[resultIndex]);
        }
        else
        {
            resultIndex = ~resultIndex;
            if (resultIndex < arr.Length)
            {
                //there is element > with value k
                //the element with value < than k must be the previous element
                if (resultIndex - 1 < 0)
                {
                    Console.WriteLine("No element with value <= than " + k);
                }
                else
                {
                    Console.WriteLine(arr[resultIndex - 1]);
                }
            }
            else
            {
                Console.WriteLine(arr[arr.Length - 1]);
            }

        }
        


    }
}

