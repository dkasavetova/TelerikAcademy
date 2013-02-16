using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        int base10Num = 1337;
        Console.WriteLine(Base10ToBase2(base10Num));
    }

    static string Base10ToBase2(int base10Num)
    {
        StringBuilder sb = new StringBuilder();

        while (base10Num != 0) 
        {
            int currentBinaryDigit = base10Num % 2;
            sb.Append(currentBinaryDigit);
            base10Num /= 2;
        }

        for (int i = 0; i < sb.Length / 2; i++)
        {
            char temp = sb[i];
            sb[i] = sb[sb.Length - 1 - i];
            sb[sb.Length - 1 - i] = temp;
        }

        return sb.ToString();
    }
}

