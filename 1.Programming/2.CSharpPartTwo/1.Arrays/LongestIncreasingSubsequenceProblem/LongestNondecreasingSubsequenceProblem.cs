using System;
using System.Collections.Generic;

//explanation: http://stackoverflow.com/questions/3992697/longest-increasing-subsequence

class LongestNondecreasingSubsequenceProblem
{
    static void Main()
    {
        int[] a = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        List<int> seq = new List<int>(a);
        List<int> lis = new List<int>(a.Length);
        LNS(seq, lis);

        for (int i = 0; i < lis.Count; i++)
        {
            Console.Write(seq[lis[i]] + " ");
        }
        Console.WriteLine();
    }

    static void LIS(List<int> a, List<int> b)
    {
        List<int> p = new List<int>(a.Count);
        for (int i = 0; i < p.Capacity; i++)
        {
            p.Add(0);
        }
        int u, v;

        if (a.Count == 0) return;

        b.Add(0);

        for (int i = 1; i < a.Count; i++) {
            if (a[b[b.Count-1]] < a[i]) {
                p[i] = b[b.Count-1];
                b.Add(i);
                continue;
            }

            for (u = 0, v = b.Count-1; u < v;) {
                int c = (u + v) / 2;
                if (a[b[c]] < a[i]) u=c+1; else v=c;
            }

            if (a[i] < a[b[u]]) {
                if (u > 0) p[i] = b[u-1];
                b[u] = i;
            }   
        }

        for (u = b.Count, v = b[b.Count-1]; u-- != 0; v = p[v]) b[u] = v;
    }

    static void LNS(List<int> a, List<int> b)
    {
        List<int> p = new List<int>(a.Count);
        for (int i = 0; i < p.Capacity; i++)
        {
            p.Add(0);
        }
        int u, v;

        if (a.Count == 0) return;

        b.Add(0);

        for (int i = 1; i < a.Count; i++)
        {
            if (a[b[b.Count - 1]] <= a[i])
            {
                p[i] = b[b.Count - 1];
                b.Add(i);
                continue;
            }

            for (u = 0, v = b.Count - 1; u < v; )
            {
                int c = (u + v) / 2;
                if (a[b[c]] <= a[i]) u = c + 1; else v = c;
            }

            if (a[i] <= a[b[u]])
            {
                if (u > 0) p[i] = b[u - 1];
                b[u] = i;
            }
        }

        for (u = b.Count, v = b[b.Count - 1]; u-- != 0; v = p[v]) b[u] = v;
    }
}

