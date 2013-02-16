using System;
using System.Linq;

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] catScore = new int[10];

        for (int i = 0; i < n; i++)
        {
            int catNumber = int.Parse(Console.ReadLine());
            catScore[catNumber - 1]++;
        }

        int maxIndex = -1;
        int maxValue = -1;

        for (int i = 0; i < catScore.Length; i++)
        {
            if (catScore[i] > maxValue)
            {
                maxValue = catScore[i];
                maxIndex = i;
            }
        }

        Console.WriteLine(maxIndex + 1);
    }
}

