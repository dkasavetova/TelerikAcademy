using System;

class CardDeck
{
    static void Main()
    {
        for (int value = 0; value < 13; value++)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                switch (value)
                {
                    case 0:
                        Console.Write("Ace");
                        break;
                    case 1:
                        Console.Write("Two");
                        break;
                    case 2:
                        Console.Write("Three");
                        break;
                    case 3:
                        Console.Write("Four");
                        break;
                    case 4:
                        Console.Write("Five");
                        break;
                    case 5:
                        Console.Write("Six");
                        break;
                    case 6:
                        Console.Write("Seven");
                        break;
                    case 7:
                        Console.Write("Eight");
                        break;
                    case 8:
                        Console.Write("Nine");
                        break;
                    case 9:
                        Console.Write("Ten");
                        break;
                    case 10:
                        Console.Write("Jack");
                        break;
                    case 11:
                        Console.Write("Queen");
                        break;
                    case 12:
                        Console.Write("King");
                        break;
                    default:
                        break;
                }

                Console.Write(" of ");

                switch (suit)
                {
                    case 0:
                        Console.WriteLine("Spades");
                        break;
                    case 1:
                        Console.WriteLine("Hearts");
                        break;
                    case 2:
                        Console.WriteLine("Diamonds");
                        break;
                    case 3:
                        Console.WriteLine("Clubs");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

