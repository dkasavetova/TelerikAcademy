using System;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        //Console.WriteLine("n = {0}\nm = {1}\np = {2}", n, m, p);
        decimal result =
            ((n * n + (1 / (m * p)) + 1337) / (n - 128.523123123M * p)) + (decimal)Math.Sin((int)m % 180);
        Console.WriteLine("{0:F6}", result);
    }
}

