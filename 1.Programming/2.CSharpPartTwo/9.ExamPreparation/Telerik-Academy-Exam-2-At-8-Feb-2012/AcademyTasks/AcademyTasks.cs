using System;

class AcademyTasks
{
    static int[] variationElements;
    static int k;
    static int[] p;
    static int v;

    static int answer = int.MaxValue;

    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        p = new int[input.Length];
        for (int i = 0; i < p.Length; i++)
        {
            p[i] = int.Parse(input[i]);
        }
        v = int.Parse(Console.ReadLine());
       
        k = p.Length;
        variationElements = new int[k];
        Var(1, 1);
        Console.WriteLine(answer);

    }

    static void Var(int pos, int num)
    {
        Console.Write("pos: {0,3} num: {0,3}", pos, num);
        if (variationElements[pos -1] >= k)
        {
            return;
        }
        if (pos >= k || variationElements[pos] >= k)
        {

            OnVariationReady(pos);
            return;
        }

        OnVariationReady(pos);
        for (int i = num; i < num + 2; i++ )
        {
            
            variationElements[pos] = i;
            Console.WriteLine(" i: {0, 3}", i);
            Var(pos + 1, num + 1);

            variationElements[pos] = ++i;
            Console.WriteLine(" i: {0, 3}", i);
            Var(pos + 1, num + 2);
        }
     
    }

    static void OnVariationReady(int pos)
    {
        if (pos < answer)
        {
            int min = p[0]; int max = p[0];
            for (int i = 1; i < pos; i++)
            {
                if (p[variationElements[i]] < min)
                {
                    min = p[variationElements[i]];
                }
                if (p[variationElements[i]] > max)
                {
                    max = p[variationElements[i]];
                }
            }
            if (max - min >= v)
            {
                answer = pos;
            }
        }
    }
}

