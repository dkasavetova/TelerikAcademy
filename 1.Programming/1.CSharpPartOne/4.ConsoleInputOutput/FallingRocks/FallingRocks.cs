using System;
using System.Threading;
using System.Text;
using System.Collections.Generic;

namespace FallingRocks
{

    class Rock
    {
        public int Left;
        public int Width;
        public char Sign;
        public ConsoleColor Color;
    }

    class FallingRocks
    {
        const int WIDTH = 80;
        const int HEIGHT = 40;

        static int dwarfPosition = WIDTH / 2 - 1;

        static List<Rock>[] rocks = new List<Rock>[HEIGHT];

        static int score = 0;

        static Random randomGenerator = new Random();

        static Rock CreateRock()
        {
            Rock r = new Rock();
            //TODO: make it random sign
            int sign = randomGenerator.Next(1, 12);
            switch (sign)
            {
                case 1:
                    r.Sign = '^';
                    break;
                case 2:
                    r.Sign = '@';
                    break;
                case 3:
                    r.Sign = '*';
                    break;
                case 4:
                    r.Sign = '&';
                    break;
                case 5:
                    r.Sign = '+';
                    break;
                case 6:
                    r.Sign = '%';
                    break;
                case 7:
                    r.Sign = '$';
                    break;
                case 8:
                    r.Sign = '#';
                    break;
                case 9: r.Sign = '!';
                    break;
                case 10:
                    r.Sign = '.';
                    break;
                case 11:
                    r.Sign = ';';
                    break;
            }
            r.Width = randomGenerator.Next(1, 5);
            r.Left = randomGenerator.Next(0, WIDTH - r.Width + 1);
            int color = randomGenerator.Next(1, 6);
            switch (color)
            {
                case 1:
                    r.Color = ConsoleColor.Blue;
                    break;
                case 2:
                    r.Color = ConsoleColor.Yellow;
                    break;
                case 3:
                    r.Color = ConsoleColor.Magenta;
                    break;
                case 4:
                    r.Color = ConsoleColor.Green;
                    break;
                case 5:
                    r.Color = ConsoleColor.Cyan;
                    break;
            }
            return r;
        }

        static List<Rock> CreateRockRow()
        {
            List<Rock> newRow = new List<Rock>();
            int rockCount = randomGenerator.Next(2, 6);
            //TODO: make it random number
            for (int i = 0; i < rockCount; i++)
            {
                newRow.Add(CreateRock());
            }

            return newRow;
        }

        static void DrawRockRow(List<Rock> rockRow)
        {
            foreach (var rock in rockRow)
            {
                for (int i = 0; i < rock.Width; i++)
                {
                    Console.SetCursorPosition(rock.Left + i, 0);
                    Console.ForegroundColor = rock.Color;
                    Console.Write(rock.Sign);
                    //Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            
        }

        static void MoveLastRow()
        {
            Console.MoveBufferArea(0, HEIGHT - 2, WIDTH, 1, 0, HEIGHT - 1);
            DwarfInit();
        }

        static bool DetectCollisionTop()
        {
            if (rocks[rocks.Length-2] == null)
            {
                return false;
            }
            foreach (var rock in rocks[rocks.Length-2])
            {
            
                if (rock.Left <= dwarfPosition  && (rock.Left + rock.Width) >= (dwarfPosition + 3) ||
                   (rock.Left + rock.Width) > dwarfPosition && (rock.Left + rock.Width) < (dwarfPosition + 3) ||
                    rock.Left > dwarfPosition && rock.Left < (dwarfPosition + 3))
                {
                    return true;
                }    
            }
            return false;
        }
        static bool DetectColliosionLeftRight()
        {
            if (rocks[rocks.Length - 1] == null)
            {
                return false;
            }
            foreach (var rock in rocks[rocks.Length - 1])
            {

                if (rock.Left + rock.Width -1 == dwarfPosition ||
                    rock.Left == dwarfPosition + 2)
                  
                {
                    return true;
                }
            }
            return false;
        }
        static void GameOver()
        {
            Console.SetCursorPosition(WIDTH / 2, HEIGHT / 2);
            Console.Write("GAME OVER! SCORE: " + score);
            Console.ReadKey();
            rocks = new List<Rock>[HEIGHT];
            Console.Clear();
            DwarfInit();
            score = 0;
            ConsoleInit();
            
        }

        static void MoveRocks()
        {
            if (DetectCollisionTop() == false)
            {
                MoveLastRow();
            }
            else
            {
                GameOver();
            }
            for (int i = rocks.Length - 2; i >= 1; i--)
            {
                rocks[i] = rocks[i - 1];
                Console.MoveBufferArea(0, i - 1, WIDTH, 1, 0, i);
            }
           
            List<Rock> rockRow = CreateRockRow();
            rocks[0] = rockRow;
            DrawRockRow(rockRow);

            foreach (var item in rocks[0])
            {
                score++;
            }

            PrintScore();
        }

        static void ConsoleInit()
        {
            Console.SetWindowSize(WIDTH + 15, HEIGHT);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.Title = "Falling Rocks";
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < HEIGHT; i++)
            {
                Console.SetCursorPosition(WIDTH, i);
                Console.Write("|");
            }

            Console.SetCursorPosition(WIDTH + 1, 0);
            Console.Write("    SCORE");
            PrintScore();
            
        }

        static void PrintScore()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(WIDTH + 1, 1);
            Console.Write("{0,14}", score);
        }

        static void DwarfInit()
        {
            Console.SetCursorPosition(dwarfPosition, HEIGHT - 1);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("(O)");
        }

        static void MoveDwarfLeft()
        {
            if (dwarfPosition - 1 >= 0)
            {
                Console.MoveBufferArea(dwarfPosition, HEIGHT - 1, 3, 1, dwarfPosition - 1, HEIGHT - 1);
                dwarfPosition--;
            }  
        }

        static void MoveDwarfRight()
        {
           if (dwarfPosition + 3 < WIDTH) 
           {
               Console.MoveBufferArea(dwarfPosition, HEIGHT - 1, 3, 1, dwarfPosition + 1, HEIGHT - 1);
               dwarfPosition++;
           }
        }

        static void Main()
        {
            ConsoleInit();
            DwarfInit();
            int moveRocksTimer = 0;
            while (true)
            {
                Console.SetCursorPosition(0, 0);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();


                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        //Console.Beep(1000, 100);
                        MoveDwarfLeft();
                    }
                    else if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        //Console.Beep(1000, 100);
                        MoveDwarfRight();
                    }
                    if (DetectColliosionLeftRight() == true)
                    {
                        GameOver();
                    }
                }
                if (moveRocksTimer == 40)
                {
                    Console.Beep(500, 150);
                    MoveRocks();
                    moveRocksTimer = 0;
                }   

                Thread.Sleep(5);
                moveRocksTimer++;
            }
        }
    }
}
