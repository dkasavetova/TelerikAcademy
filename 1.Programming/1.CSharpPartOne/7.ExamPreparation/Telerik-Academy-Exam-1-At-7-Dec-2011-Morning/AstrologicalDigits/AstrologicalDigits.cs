using System;

class AstrologicalDigits
{
    static void Main()
    {
        string inputN = Console.ReadLine();
        int n = 0;
        for (int i = 0; i < inputN.Length ; i++)
        {
            if (inputN[i] != '.' && inputN[i] != '-' && inputN[i] != '+')
            {
                n += inputN[i] - '0';
            }
        }
        AstroDigit(n);
    }
    static void AstroDigit(int n)
    {
        if (n <= 9)
        {
            Console.WriteLine(n);
            return;
        }
        AstroDigit(SumOfDigits(n));
    }

    static int SumOfDigits(int n)
    {
        string nStr = n.ToString();
        int sum = 0;
        for (int i = 0; i < nStr.Length; i++)
        {
            sum += nStr[i] - '0';
        }
        return sum;
    }
}

