using System;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        int base10Num = 1337;
        Console.WriteLine(Base10ToBase16(base10Num));
    }

    static string Base10ToBase16(int base10Num)
    {
        StringBuilder sb = new StringBuilder();

        while (base10Num != 0)
        {
            int currentHexDigit = base10Num % 16;
            if (currentHexDigit < 10)
            {
                sb.Append((char)(currentHexDigit + '0'));
            }
            else
            {
                sb.Append((char)('A' + currentHexDigit - 10));
            }
            base10Num /= 16;
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

