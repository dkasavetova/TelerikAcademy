using System;
using System.Numerics;
using System.Collections.Generic;

class Change
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        BigInteger money, price;

        BigInteger.TryParse(input[0], out money);
        BigInteger.TryParse(input[1], out price);

        Console.WriteLine(money - price);        
    }
}

