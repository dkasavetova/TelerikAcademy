using System;

class Lines
{
    static byte[] n = new byte[8];

    static int[,] resultRight = new int[8, 2];
    static int[,] resultDown = new int[8, 2];

    static void Main()
    {
        ReadInput();

        int longestLineLength;
        int longestLineCount;
        int currentLineLength;

        for (int i = 0; i < 8; i++)
        {
            longestLineLength = 0;
            longestLineCount = 0;
            currentLineLength = 0;

            for (int j = 0; j < 8; j++)
            {
                if (CheckBit(n[i], j))
                {
                    currentLineLength++;   
                }
                else
                {
                    if (currentLineLength > 0 && currentLineLength == longestLineLength)
                    {
                        longestLineCount++;
                    }
                    else if (currentLineLength > 0 && currentLineLength > longestLineLength)
                    {
                        longestLineLength = currentLineLength;
                        longestLineCount = 1;
                    }
                    currentLineLength = 0;
                }
            }
            if (currentLineLength > 0 && currentLineLength == longestLineLength)
            {
                longestLineCount++;
            }
            else if (currentLineLength > 0 && currentLineLength > longestLineLength)
            {
                longestLineLength = currentLineLength;
                longestLineCount = 1;
            }

            resultRight[i, 0] = longestLineCount;
            resultRight[i, 1] = longestLineLength;
        }

        for (int j = 0; j < 8; j++)
        {
            longestLineLength = 0;
            longestLineCount = 0;
            currentLineLength = 0;

            for (int i = 0; i < 8; i++)
            {
                if (CheckBit(n[i], j))
                {
                    currentLineLength++;
                }
                else
                {
                    if (currentLineLength > 0 && currentLineLength == longestLineLength)
                    {
                        longestLineCount++;
                    }
                    else if (currentLineLength > 0 && currentLineLength > longestLineLength)
                    {
                        longestLineLength = currentLineLength;
                        longestLineCount = 1;
                    }
                    currentLineLength = 0;
                }
            }
            if (currentLineLength > 0 && currentLineLength == longestLineLength)
            {
                longestLineCount++;
            }
            else if (currentLineLength > 0 && currentLineLength > longestLineLength)
            {
                longestLineLength = currentLineLength;
                longestLineCount = 1;
            }

            resultDown[j, 0] = longestLineCount;
            resultDown[j, 1] = longestLineLength;
        }

        longestLineLength = 0;
        longestLineCount = 0;

        for (int i = 0; i < 8; i++)
        {
            if (longestLineLength == resultRight[i, 1])
            {
                longestLineCount += resultRight[i, 0];
            }
            else if (longestLineLength < resultRight[i, 1])
            {
                longestLineLength = resultRight[i, 1];
                longestLineCount = resultRight[i, 0];
            }
        }
        for (int j = 0; j < 8; j++)
        {
            if (longestLineLength == resultDown[j, 1])
            {
                longestLineCount += resultDown[j, 0];
            }
            else if (longestLineLength < resultDown[j, 1])
            {
                longestLineLength = resultDown[j, 1];
                longestLineCount = resultDown[j, 0];
            }
        }

        if (longestLineLength != 1)
        {
            Console.WriteLine(longestLineLength);
            Console.WriteLine(longestLineCount);
        }
        else
        {
            Console.WriteLine(longestLineLength);
            Console.WriteLine(longestLineCount / 2);
        }
    }

    static void ReadInput()
    {
        for (int i = 0; i < 8; i++)
        {
            n[i] = byte.Parse(Console.ReadLine());
        }
    }

    static bool CheckBit(int num, int pos)
    {
        return (num & (1 << pos)) != 0;
    }
}

