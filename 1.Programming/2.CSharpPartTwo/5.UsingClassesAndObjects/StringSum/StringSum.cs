using System;

class StringSum
{
    static void Main()
    {
        string str = "1 2 3 4";
        Console.WriteLine(TokensSum(str));
    }

    static int TokensSum(string str) 
    {
        string[] tokens = str.Split(' ');
        int sum = 0;
        foreach (var item in tokens)
        {
            sum += int.Parse(item);
        }
        return sum;
    }
}

