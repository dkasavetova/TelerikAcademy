using System;

class ElectronicMessage
{
    static void Main()
    {
        string msg = Console.ReadLine();
        int maxLen = 0;
        int curLen = 0;
        for (int i = 0; i < msg.Length; i++)
        {
            if (!IsLittleLeter(msg[i]) && !IsBigLeter(msg[i]) && !IsDigit(msg[i]) && !IsSpace(msg[i]))
            {
                curLen++;
            }
            else
            {
                if (curLen > maxLen)
                {
                    maxLen = curLen;
                }
                curLen = 0;
            }
        }
        if (curLen - 1 > maxLen)
        {
            maxLen = curLen - 1;
        }
        Console.WriteLine(maxLen);
    }

    static bool IsLittleLeter(char a) 
    {
        return a >= 'a' && a <= 'z';
    }
    static bool IsBigLeter(char a) 
    {
        return a >= 'A' && a <= 'Z';
    }
    static bool IsDigit(char a) 
    {
        return a >= '0' && a <= '9';
    }
    static bool IsSpace(char a) 
    {
        return a == ' ';
    }
}

