using System;
using System.Linq;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] catVotes = new int[10];
        int i;
        for (i = 0; i < n; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            catVotes[vote - 1]++;
        }

        int maxVal = -1, maxIndex = -1;
        for (i = 0; i < 10; i++)
        {
            if (maxVal < catVotes[i])
            {
                maxVal = catVotes[i];
                maxIndex = i;
            }
        }
        Console.WriteLine(maxIndex + 1);
    }
}

