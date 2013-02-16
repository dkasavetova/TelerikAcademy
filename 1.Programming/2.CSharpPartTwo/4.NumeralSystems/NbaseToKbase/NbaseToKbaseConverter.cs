using System;
using System.Text;

class NbaseToKbaseConverter
{
    static void Main()
    {
        Console.WriteLine(BaseNToBaseK("123", 4, 2));                                           
    }

    static string BaseNToBaseK(string baseNNum, int n, int k)
    {
        int base10Num = BaseNToBase10(baseNNum, n);
        string baseKNum = Base10ToBaseN(base10Num, k);
        return baseKNum;
    }

    static int BaseNToBase10(string baseNNum, int n)
    {
        int base10Num = 0;
        for (int i = 0; i < baseNNum.Length; i++)
        {
            if (baseNNum[i] - '0' < 10)
            {
                base10Num += (int)Math.Pow(n, baseNNum.Length - 1 - i) * (baseNNum[i] - '0');
            }
            else
            {
                int currentDigit = char.ToUpper(baseNNum[i]); 
                base10Num += (int)Math.Pow(n, baseNNum.Length - 1 - i) * (baseNNum[i] - 'A' + 10);
            }
        }
        return base10Num;
    }

    static string Base10ToBaseN(int base10Num, int n)
    {
        StringBuilder sb = new StringBuilder();

        while (base10Num != 0)
        {
            int currentDigit = base10Num % n;

            if (currentDigit < 10)
            {
                sb.Append(currentDigit);
            }
            else
            {
                sb.Append((char)(currentDigit + 'A' - 10));
            }
            base10Num /= n;
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

