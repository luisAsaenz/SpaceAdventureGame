
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpaceAdventure
{
    class Display
    {
        public static int Sx1 = 9, Sx2 = 150, Sy1 = 4, Sy2 = 35, Sy3 = 41;

        public static void Screen()
        {          
            Console.BackgroundColor = ConsoleColor.DarkGray;
            
            for (int i = Sx1; i < Sx2+1; i++)
            {
                Cursor.WriteAt(" ", i, Sy1);
                Cursor.WriteAt(" ", i, Sy2);
                Cursor.WriteAt(" ", i, Sy3);
            }
            for (int j = Sy1; j < Sy3 + 1; j++)
            {
                Cursor.WriteAt(" ", Sx1, j);
                Cursor.WriteAt(" ", Sx2, j);
            }
            Console.ResetColor();
        }

        public static void ClearMapScreen()
        {
            Cursor.ClearArea(Sx1 + 1, Sx2 - 1, Sy1 + 1, Sy2 - 1);
        }
        public static void ClearMenuScreen()
        {
            Cursor.ClearArea(Sx1 + 1, Sx2 - 1, Sy2 + 1, Sy3 - 1);
        }
        public static List<(int, int)> ScreenBoudaries()
        {
            List<(int, int)> Boundaries = new List<(int, int)>();

            for (int i = Sx1; i < Sx2 + 1; i++)
            {
                Boundaries.Add((i, Sy1));
                Boundaries.Add((i, Sy2));
            }
            for (int i = Sy1; i < Sy2 + 1; i++)
            {
                Boundaries.Add((Sx1, i));
                Boundaries.Add((Sx2, i));

            }
            return Boundaries;
        }

        public static void UniverseMap(int x = 81, int y = 20)
        {
            Screen();
            // Print random stars as background
            Random rnd = new Random();
            for (int i = Sx1+1; i < Sx2; i += 5)
            {
                for (int j = Sy1+1; j < Sy2; j += 5)
                {
                    Cursor.WriteAt("*", rnd.Next(i, i+5), rnd.Next(j, j+5));
                }
            }

            // Print Planets
            var PlanetLocation = new List<(string color, (int x, int y)coord)> { ("Blue", (80, 20)), ("Red",(40,10)),
                ("Cyan",(50,28)),("Green",(120,10)),("Magenta",(110,25))}; 

            foreach (var item in PlanetLocation)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), item.color);
                Cursor.WriteAt("*", item.coord.x, item.coord.y);
            }
            Console.ResetColor();

            // Print Spaceship
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine((char)0x25B2);
            Console.ResetColor();

            Stats stats = new Stats(42, 37);
            Console.SetCursorPosition(51, 38);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Planets include: earth | vegeta | alphac | namek | yardrat");
            Console.ResetColor();
            Console.SetCursorPosition(61, 39);
            Console.Write("What Planet would you like to go to? ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "earth":
                    Console.Clear();
                    Stats.age += 8;
                    if (Stats.age < 65)
                    {
                        Earth earth = new Earth();
                    }else if (Stats.age >= 65)
                    {
                        Console.WriteLine("You have reached Death..");
                        Environment.Exit(0);
                    }
                    break;
                case "vegeta":
                    Console.Clear();
                    Stats.age += 8;
                    if (Stats.age < 65)
                    {
                        Vegeta vegeta = new Vegeta();
                    }
                    else if (Stats.age >= 65)
                    {
                        Console.WriteLine("You have reached Death..");
                        Environment.Exit(0);
                    }
                    break;
                case "alphac":
                    Console.Clear();
                    Stats.age += 8;
                    if (Stats.age < 65)
                    {
                        AlphaC alphac = new AlphaC();
                    }
                    else if (Stats.age >= 65)
                    {
                        Console.WriteLine("You have reached Death..");
                        Environment.Exit(0);
                    }
                    break;
                case "namek":
                    Console.Clear();
                    Stats.age += 8;
                    if (Stats.age < 65)
                    {
                        Namek namek = new Namek();
                    }
                    else if (Stats.age >= 65)
                    {
                        Console.WriteLine("You have reached Death..");
                        Environment.Exit(0);
                    }
                    break;
                case "yardrat":
                    Console.Clear();
                    Stats.age += 8;
                    if (Stats.age < 65)
                    {
                        Yardrat yardrat = new Yardrat();
                    }
                    else if (Stats.age >= 65)
                    {
                        Console.WriteLine("You have reached Death..");
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You didn't spell the planet correctly try again..");
                    UniverseMap();
                    break;

            }
            
        }


        //public static void SpaceTravelAnime()
        //{
        //    ClearMapScreen();
        //    Random rd = new Random();
        //    //for 
        //}
    }
}