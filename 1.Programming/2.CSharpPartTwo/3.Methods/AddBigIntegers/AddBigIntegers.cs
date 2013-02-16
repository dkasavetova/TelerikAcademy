using System;
using System.Collections.Generic;
using System.Linq;

class AddBigIntegers
{
    static void Main()
    {
        int[] a =       { 9, 9, 9 };
        int[] b = { 9, 9, 9, 9, 9};
        //       1  0  0  9  9  8
        int[] r = Add(a, b);
        r = r.Reverse().ToArray();
        foreach (var num in r)
        {
            Console.Write(num);
        }
    }

    static int[] Add(int[] a, int[] b)
    {
        int carry = 0;
       
        List<int> result = new List<int>(Math.Max(a.Length, b.Length) + 1);

        int end = Math.Min(a.Length, b.Length);
        int current;
        for (int i = 0; i < end; i++)
        {
            current = a[i] + b[i] + carry;
            result.Add(current % 10);
            carry = current / 10;
        }

        if (a.Length <= b.Length)
        {
            for (int i = a.Length; i < b.Length; i++)
            {
                current = b[i] + carry;
                result.Add(current % 10);
                carry = current / 10;
            }
        }
        else
        {
            for (int i = b.Length; i < a.Length; i++)
            {
                current = a[i] + carry;
                result.Add(current % 10);
                carry = current / 10;
            }
        }
        if (carry != 0)
        {
            result.Add(carry);
        }

        return result.ToArray();
    }
}

