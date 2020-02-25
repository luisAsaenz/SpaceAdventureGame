using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class Vegeta
    {
        public static List<(int, int)> vBound = new List<(int, int)>();
        public Vegeta(int x = 120, int y = 20)
        {
            

            Console.Clear();

            Console.WriteLine("\t\t\t\t\t WELCOME TO VEGETA");
            VegetaMap();
            Console.SetCursorPosition(x, y);
            while (true)
            {
                MoveCharacter(MapBound());
            }
        }

        private void VegetaMap()
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

            Grass();

            Water();

            VMissionAndObstacles();
            Stats stats = new Stats();

        }
        //private List<(int, int)> MAO()
        //{
        //    List<(int, int)> moa = new List<(int, int)>();
        //    moa.Add((88, 12));
        //    moa
        //}

        private List<(int, int)> MapBound()
        {
            //Water Boundaries
            for (int i = 70; i <= 115; i++)
            {
                vBound.Add((i, 15));
                vBound.Add((i, 20));
            }
            for (int i = 16; i <= 19; i++)
            {
                vBound.Add((70, i));
                vBound.Add((115, i));
            }
            //Grass
            for (int i = 57; i <= 126; i++)
            {
                vBound.Add((i, 9));
                vBound.Add((i, 25));
            }
            for (int i = 9; i <= 25; i++)
            {
                vBound.Add((57, i));
                vBound.Add((126, i));
            }
            //Mission and Obstacles
            for(int i = 68; i <= 118; i += 4)
            {
                vBound.Add((i, 13));
                vBound.Add((i, 22));
            }
            for (int i = 15; i<= 21; i +=2)
            {
                vBound.Add((68, i));
                vBound.Add((118, i));
            }
            //Space Ship
            vBound.Add((122, 23));

            return vBound;
        }

        private void VMissionAndObstacles()
        {
            char hut = 'H';

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 68; i <= 118; i += 4)
            {
                Console.SetCursorPosition(i, 13);
                Console.Write(hut);

                Console.SetCursorPosition(i, 22);
                Console.Write(hut);
                if (i == 88 || i == 108)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(i, 13);
                    Console.Write("S");
                    Console.SetCursorPosition(i, 22);
                    Console.Write("S");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            for (int i = 15; i <= 21; i += 2)
            {
                Console.SetCursorPosition(68, i);
                Console.Write(hut);

                Console.SetCursorPosition(118, i);
                Console.Write(hut);
                if (i == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(68, i);
                    Console.Write("S");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                if (i == 21)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(118, i);
                    Console.Write("S");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            Console.ResetColor();

            Console.SetCursorPosition(122, 23);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write((char)0x25B2);
            Console.ResetColor();

        }

        private void Water()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int j = 70; j <= 115; j++)
            {
                for (int i = 15; i <= 20; i++)
                {

                    Console.SetCursorPosition(j, i);
                    Console.Write('w');
                }
            }
            Console.ResetColor();
        }
        private void Grass()
        {
            char grass = 'g';
            Console.ForegroundColor = ConsoleColor.Green;
            for (int j = 42; j <= 141; j++)
            {
                for (int i = 5; i <= 9; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(grass);
                }
                for (int i = 25; i <= 29; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(grass);
                }
            }
            for (int j = 9; j <= 25; j++)
            {
                for (int i = 42; i <= 57; i++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(grass);
                }
                for (int i = 126; i <= 141; i++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(grass);
                }
            }
            Console.ResetColor();
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

                        MissionAndObstacles.VegetaM();

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