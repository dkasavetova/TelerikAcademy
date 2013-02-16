using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FactorialBigIntegers
{
    static void Main()
    {
        int n = 100;
        List<int> f = new List<int>();
        f.Add(1);
        for (int i = 1; i <= n; i++)
        {
            f = Mul(f.ToArray(), i).ToList();
        }

        f.Reverse();

        foreach (var item in f)
        {
            Console.Write(item);
        }
    }

    /* Works just for b in [0, 9] not in general case */
    /* a = 999 b = 0 => 000 */
    static int[] Mul(int[] a, int b)
    {
        int carry = 0;

        List<int> result = new List<int>(2 * a.Length);

        int current;
        for (int i = 0; i < a.Length; i++)
        {
            current = a[i] * b + carry;
            result.Add(current % 10);
            carry = current / 10;
        }

        while (carry != 0)
        {
            current = carry;
            result.Add(current % 10);
            carry = current / 10;
        }

        return result.ToArray();
    }
}

