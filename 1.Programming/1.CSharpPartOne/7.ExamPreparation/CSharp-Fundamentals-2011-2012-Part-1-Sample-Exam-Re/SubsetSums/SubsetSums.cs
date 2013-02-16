using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        long[] nums = new long[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }

        int count = 0;
        long currentSum = 0L;
        for (int i = 1; i < (1 << n); i++) //i<=(1<<n)-1
        {
            for (int j = 0; j < n; j++)
            {
                if (CheckBit(i, j))
                {
                    currentSum += nums[j];
                }
            }

            if (currentSum == s)
            {
                count++;
            }

            currentSum = 0;
        }

        Console.WriteLine(count);
    }

    static bool CheckBit(int num, int pos)
    {
        return (num & 1 << pos) != 0;
    }
}

