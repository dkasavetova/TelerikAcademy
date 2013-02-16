using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tubes
{
    static int n, m;
    static long upperBound;
    static int[] tubes;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());
        tubes = new int[n];
        for (int i = 0; i < n; i++)
        {
            tubes[i] = int.Parse(Console.ReadLine());
            upperBound += tubes[i];
        }
        
        long p = 0;
        long r = upperBound;
        long q = (p + r) / 2;
        while (p <= r)
        {
            int res = IsSolution(q);
            if (res < 0)
            {
                r = q - 1;
            }
            else if (res >= 0)
            {
                p = q + 1;
            }
            q = (p + r) / 2;
            
        }
        Console.WriteLine(q);
    }

    static int IsSolution(long g)
    {
        long curr = 0;
        for (int i = 0; i < tubes.Length; i++)
        {
            curr += tubes[i] / g;
        }

        return curr.CompareTo(m);
    }
}

