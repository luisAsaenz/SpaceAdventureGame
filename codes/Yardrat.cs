using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class Yardrat
    {
        public static List<(int, int)> yBound = new List<(int, int)>();
        public Yardrat(int x = 49, int y = 12)
        {
            Console.WriteLine("\t\t\t\tYARDRAT");
            YardratMap();
            Console.SetCursorPosition(x, y);
            while(true)
            {
                MoveCharacter(MapBound());
            }
        }

        private void YardratMap()
        {
            char b = ' ';
            char s = ' ';
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(41, 4);
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(b);
            }

            for (int j = 4; j <= 30; j++)
            {

                Console.SetCursorPosition(41, j);
                Console.Write(s);
            }

            for (int a = 4; a <= 30; a++)
            {
                Console.SetCursorPosition(142, a);

                Console.WriteLine(s);
            }

            Console.SetCursorPosition(42, 30);
            for (int j = 0; j <= 99; j++)
            {

                Console.Write(b);
            }
            Console.ResetColor();
            Sand();
            Grass();
            Water();
            YMissionAndObstacles();
            Stats stats = new Stats();
        }
        private List<(int, int)> MapBound()
        {
            for (int i = 13; i <= 23; i += 2)
            {
                yBound.Add((46, i));
                yBound.Add((137, i));
                if (i == 15 | i == 21)
                {
                    yBound.Add((46, i));
                    yBound.Add((137, i));
                }
            }
            for (int i = 69; i <= 79; i += 2)
            {
                yBound.Add((i, 10));
                if (i == 73)
                {
                    yBound.Add((i, 10));
                }
            }
            for (int i = 99; i <= 109; i += 2)
            {
                yBound.Add((i, 24));
                if (i == 105)
                {
                    yBound.Add((i, 24));
                }
            }
            //Water
            for (int i = 54; i <= 124; i++)
            {
               yBound.Add((i, 17));
               yBound.Add((i, 18));
            }
            //Sand
            for ( int i = 45; i <= 53; i++)
            {
                yBound.Add((i, 7));
                yBound.Add((i, 27));
            }
            for (int i = 65; i <= 83; i++)
            {
                yBound.Add((i, 7));
                yBound.Add((i, 27));
            }
            for (int i = 95; i <= 113; i++)
            {
                yBound.Add((i, 7));
                yBound.Add((i, 27));
            }
            for (int i = 125; i <= 138; i++)
            {
                yBound.Add((i, 7));
                yBound.Add((i, 27));
            }
            for (int i = 8; i <= 26; i++)
            {
                yBound.Add((44, i));
                yBound.Add((139, i));
            }
            //Grass
            for (int j = 8; j <= 13; j++)
            {
                yBound.Add((54, j));
                yBound.Add((64, j));
                yBound.Add((84, j));
                yBound.Add((94, j));
                yBound.Add((114, j));
                yBound.Add((124, j));
            }
            for (int j = 21; j <= 26; j++)
            {
                yBound.Add((54, j));
                yBound.Add((64, j));
                yBound.Add((84, j));
                yBound.Add((94, j));
                yBound.Add((114, j));
                yBound.Add((124, j));
            }
            for (int i = 54; i <= 64; i++)
            {
                yBound.Add((i, 13));
                yBound.Add((i, 21));
            }
            for (int i = 84; i <= 94; i++)
            {
                yBound.Add((i, 13));
                yBound.Add((i, 21));
            }
            for (int i = 114; i <= 124; i++)
            {
                yBound.Add((i, 13));
                yBound.Add((i, 21));
            }
            //SpaceShip
            yBound.Add((49, 11));
            return yBound;
        }

        private void YMissionAndObstacles()
        {
            char h = 'H';
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 13; i <= 23; i += 2)
            {
                Console.SetCursorPosition(46, i);
                Console.Write(h);
                Console.SetCursorPosition(137, i);
                Console.Write(h);
                if (i == 15 | i == 21)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(46, i);
                    Console.Write('S');
                    Console.SetCursorPosition(137, i);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            for (int i = 69; i <= 79; i += 2)
            {
                Console.SetCursorPosition(i, 10);
                Console.Write(h);
                if (i == 73)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(i, 10);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            for (int i = 99; i <= 109; i += 2)
            {
                Console.SetCursorPosition(i, 24);
                Console.Write(h);
                if (i == 105)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(i, 24);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            Console.ResetColor();
            Console.SetCursorPosition(49, 11);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write((char)0x25B2);
            Console.ResetColor();
        }

        private void Water()
        {
            char w = 'w';
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 54; i <= 124; i++)
            {
                Console.SetCursorPosition(i, 17);
                Console.Write(w);
                Console.SetCursorPosition(i, 18);
                Console.Write(w);
            }
        }

        private void Grass()
        {
            char g = 'g';
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 54; i <= 64; i++)
            {
                for (int j = 8; j <= 13; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(g);
                }for (int j = 21; j <= 26; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(g);
                }
            }   
            for (int i = 84; i <= 94; i++)
            {
                for (int j = 8; j <= 13; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(g);
                }for (int j = 21; j <= 26; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(g);
                }
            } 
            for (int i = 114; i <= 124; i++)
            {
                for (int j = 8; j <= 13; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(g);
                }for (int j = 21; j <= 26; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(g);
                }
            }
        }

        private void Sand()
        {
            char s = 's';
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 42; i <= 141; i++)
            {
                for (int j = 5; j <= 7; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(s);
                }
                for (int j = 27; j <= 29; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(s);
                }
            }
            for (int i = 8; i <= 26; i++)
            {
                for (int j = 42; j <= 44; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(s);
                }
                for (int j = 139; j <= 141; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(s);
                }
            }
        }
        public static void MoveCharacter(List<(int, int)> Boundaries = null, string s = "x")
        {
            Boundaries = Boundaries ?? new List<(int, int)>();
            Console.Write(s);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            try
            {
                Console.CursorVisible = false;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Boundaries.Contains((Console.CursorLeft, Console.CursorTop - 1)))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(" ");
                            Cursor.WriteAt(s, Console.CursorLeft - 1, Console.CursorTop - 1);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        if (Boundaries.Contains((Console.CursorLeft, Console.CursorTop + 1)))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(" ");
                            Cursor.WriteAt(s, Console.CursorLeft - 1, Console.CursorTop + 1);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        if (Boundaries.Contains((Console.CursorLeft - 1, Console.CursorTop)))
                        {
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(s + " ");
                            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        if (Boundaries.Contains((Console.CursorLeft + 1, Console.CursorTop)))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(" " + s);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    // To be Modified - Jump to the next line
                    case ConsoleKey.Enter:

                        MissionAndObstacles.YardratM();

                        //else if (mission.Count == 2)
                        //{
                        //    MissionAndObstacles.Vegeta(mission);
                        //}
                        break;
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Write("\b" + s);
            }
        }
    }
}
