using System;
using System.Text;

class Indices
{
    static int n;
    static int[] arr;
    static StringBuilder sb;
    static bool[] used;

    static void Main()
    {
        Init();
        sb.Append("0 ");
        Next(0);
        Console.WriteLine(sb.ToString());
    }

    static void Init()
    {
        n = int.Parse(Console.ReadLine());
        arr = new int[n];
        string[] arrElems = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(arrElems[i]);
        }

        sb = new StringBuilder(n * 2);
        used = new bool[n];
    }

    static void Next(int index)
    {
   
        if (arr[index] < 0 || arr[index] >= n) //out
        {
            sb.Remove(sb.Length - 1, 1); //remove the last space
            return;
        }

        if (used[arr[index]] || arr[index] == index) //loop
        {
            if (index == 0)
            {
                sb.Clear();
                sb.Append("(0)");
                return;
            }

            sb[sb.Length-1] = ')';
            int i = sb.ToString().IndexOf(arr[index].ToString());
            if (i - 1 < 0)
            {
                sb.Insert(0, '(');
            }
            else
            {
                sb[i - 1] = '(';
            }
            
            return;
        }

        used[index] = true;
        sb.Append(arr[index]);
        sb.Append(" ");
        Next(arr[index]);
    }
    
}

