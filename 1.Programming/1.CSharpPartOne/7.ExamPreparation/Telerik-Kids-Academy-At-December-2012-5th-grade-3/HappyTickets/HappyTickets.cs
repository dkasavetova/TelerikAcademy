using System;

class HappyTickets
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int winnerCount = 0;
        int prizeMoney = 0;

        while(input != "0") 
        {
            int a = 10 * (input[0] - '0') + input[4] - '0';
            int b = 100 * (input[1] - '0') + 10 * (input[2] - '0') + input[3] - '0';

            if (b % a== 0)
            {
                winnerCount++;
                prizeMoney += (b / a);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(prizeMoney);
        Console.WriteLine(winnerCount);
    }
}

