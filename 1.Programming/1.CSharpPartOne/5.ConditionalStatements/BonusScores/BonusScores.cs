using System;

class BonusScores
{
    static void Main()
    {
        int score = -1;
        if (!int.TryParse(Console.ReadLine(), out score))
        {
            Console.WriteLine("ERROR");
        }
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                break;
            default:
                Console.WriteLine("ERROR");
                return;
        }
        Console.WriteLine(score);
    }
}

