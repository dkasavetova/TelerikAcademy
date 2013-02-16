using System;

class CalculateSum
{
    static void Main()
    {
        double previousSum = 1;
        double currentSum = 1;
        double eps = 0.001;

        int i = 2;
        while(true)
        {
            if (i % 2 == 0)
            {
                currentSum += (1.0 / i);
            }
            else
            {
                currentSum += (-1.0 / i);
            }

            if (Math.Abs(currentSum - previousSum) <= eps)
            {
                break;
            }
            previousSum = currentSum;
            i++;
        }
        Console.WriteLine(currentSum);
    }
}

