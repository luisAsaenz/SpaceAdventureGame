using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpaceAdventure
{
    public class MissionAndObstacles
    {
        public static int t = 0;
        public static int t2 = 0;
        public static int t3 = 0;
        public static int t4 = 0;
        public static int t5 = 0;
        public static int t6 = 0;
        public static int t7 = 0;
        
        public static void EarthM()
        {
            if (Console.CursorLeft == 139 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.WriteLine("This ride cost $2000. See you later");
                Console.ReadKey();
                if (Stats.EMoney >= 2000)
                {
                    Stats.EMoney -= 2000;
                    Stats.age += 1;
                    Display.UniverseMap(81, 20);
                }
                else if (Stats.EMoney < 2000)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry you didn't have enough money...");
                    Console.ReadKey();
                    Console.Clear();
                    Earth earth = new Earth(139, 17);
                }
            }
            else if (Console.CursorLeft == 47 && Console.CursorTop == 24)
            {
                if (t < 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\nCollected..");
                    Stats.EMoney += 1000;
                    Console.WriteLine("\n$1000");
                    
                    t ++;
                }
                else if (t >= 1 )
                {
                    return;
                }
                Console.ReadKey();

                Console.Clear();
                Earth earth = new Earth(47, 24);

            }
            else if (Console.CursorLeft == 122 && Console.CursorTop == 27)
            {
                if (t2 < 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\nCollected..");
                    Stats.jade += 3;
                    Console.WriteLine("\n3 Jades Collected");
                    t2++;
                }
                else if (t2 >= 1)
                {
                    return;
                }
                Console.ReadKey();
                Console.Clear();
                Earth earth = new Earth(122, 27);


            }
            else if (Console.CursorLeft == 103 && Console.CursorTop == 18)
            {
                Stats.BuyStore();

                Earth earth = new Earth(103, 18);

            }
            else if (Console.CursorLeft == 97 && Console.CursorTop == 20)
            { 
                Stats.SellStore();

                Earth earth = new Earth(97, 20);

            }
            else if (Console.CursorLeft == 96 && Console.CursorTop == 18)
            {
                Stats.SellStore(800, 1200, 600, 100);

                Earth earth = new Earth(96, 18);

            }
            else if (Console.CursorLeft == 112 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.WriteLine("You walked into a 'store' and got robbed..\nAll your money was taken and one of each stone.");
                Console.ReadKey();
                Stats.EMoney -= Stats.EMoney;
                if (Stats.diamond >= 1)
                {
                    Stats.diamond -= 1;
                }
                if (Stats.jade >= 1)
                {
                    Stats.jade -= 1;
                }
                if (Stats.crystal >= 1)
                {
                    Stats.crystal -= 1;
                }
                if (Stats.ruby >= 1)
                {
                    Stats.ruby -= 1;
                }
                Console.Clear();
                Earth earth = new Earth(112, 20);

            }
        }

        public static void VegetaM()
        {
            if (Console.CursorLeft == 122 && Console.CursorTop == 24)
            {
                Console.Clear();
                Console.WriteLine("This trip cost $1000. See you later");
                Console.ReadKey();
                if (Stats.EMoney >= 1000)
                {
                    Stats.EMoney -= 1000;
                    Stats.age += 1;
                    Console.Clear();
                    Display.UniverseMap(121, 10);
                }
                else if (Stats.EMoney < 1000)
                {
                    Console.Clear();
                    Console.WriteLine("You're broke.");
                    Console.ReadKey();
                    Console.Clear();
                    Vegeta vegeta = new Vegeta(122, 24);
                }
            }
            else if (Console.CursorLeft == 88 && Console.CursorTop == 14)
            {
                Stats.SellStore(200, 3000, 600, 2500);
                Vegeta vegeta = new Vegeta(88, 14);

            }
            else if (Console.CursorLeft == 108 && Console.CursorTop == 14)
            {
                if (t6 < 1)
                {
                    Console.WriteLine("This store is being runned by King Vegeta's warriors...\nTry not to stand out.");
                    Console.WriteLine("You found $2000..");
                    Stats.EMoney += 2000;
                    t6++;
                }
                else if (t6 >= 1)
                {
                    Console.WriteLine("This store is being runned by Kind Vegeta's warriors...\nTry not to stand out.");
                }
                Console.ReadKey();
                Console.Clear(); Vegeta vegeta = new Vegeta(108, 14);
            }
            else if (Console.CursorLeft == 88 && Console.CursorTop == 21)
            {
                Stats.SellStore(800, 1200, 600, 100);
                Vegeta vegeta = new Vegeta(88, 21);
            }
            else if (Console.CursorLeft == 108 && Console.CursorTop == 21)
            {
                Stats.BuyStore(1000, 100, 2000, 200);
                Vegeta vegeta = new Vegeta(108, 21);
            }
            else if (Console.CursorLeft == 69 && Console.CursorTop == 17)
            {
                Stats.BuyStore();
                Vegeta vegeta = new Vegeta(69, 17);
            }
            else if (Console.CursorLeft == 117 && Console.CursorTop == 21)
            {
                Stats.BuyStore(200, 600, 300, 800);
                Vegeta vegeta = new Vegeta(117, 21);
            }
        }
        public static void AlphaM()
        {
            if (Console.CursorLeft == 64 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.WriteLine("This trip cost $800. Catch ya later.");
                Console.ReadKey();
                if (Stats.EMoney >= 800)
                {
                    Stats.EMoney -= 800;
                    Stats.age += 1;
                    Console.Clear();
                    Display.UniverseMap(41, 10);
                }
                else if (Stats.EMoney < 800)
                {
                    Console.Clear();
                    Console.WriteLine("You're broke.");
                    Console.ReadKey();
                    Console.Clear();
                    AlphaC alphac = new AlphaC(64, 17);
                }
            }
            else if (Console.CursorLeft == 94 && Console.CursorTop == 19)
            {
                if (t3 < 1)
                {
                    Console.Clear();
                    Console.Write("YOU FOUND A DRAGON BALL");
                    Stats.dragonball += 1;
                    t3++;
                }
                else if (t3 >= 1)
                {
                    return;
                }
                Console.ReadKey();
                Console.Clear();
                AlphaC alpha = new AlphaC(94, 19);
            }else if (Console.CursorLeft == 76 && Console.CursorTop == 17)
            {
                Stats.BuyStore(1000, 200, 600, 100);
                AlphaC alpha = new AlphaC(76, 17);
            }
            else if (Console.CursorLeft == 114 && Console.CursorTop == 17)
            {
                Console.WriteLine("Dragon ball checkpoint..");
                if (Stats.dragonball == 7)
                {
                    Console.Clear();
                    Console.WriteLine("You have achieved immortality. GAME OVER!");
                    Environment.Exit(0);
                }
                else if (Stats.dragonball < 7)
                {
                    Console.Clear();
                    Console.WriteLine("You have not collected all 7 Dragon Balls.");
                    Console.Clear();
                    Console.ReadKey();
                    AlphaC alpha = new AlphaC(114, 17);
                }
            }
            else if (Console.CursorLeft == 95 && Console.CursorTop == 14)
            {
                Stats.SellStore(1300, 500, 300, 200);
                AlphaC alpha = new AlphaC(95, 14);
            }
            else if (Console.CursorLeft == 95 && Console.CursorTop == 20)
            {
                Stats.BuyStore();
                AlphaC alpha = new AlphaC(95, 20);
            }
            else if (Console.CursorLeft == 86 && Console.CursorTop == 17)
            {
                Stats.SellStore();
                Console.Clear();
                AlphaC alpha = new AlphaC(86, 17);
            }
            else if (Console.CursorLeft == 104 && Console.CursorTop == 17)
            {
                Stats.BuyStore(100, 2000, 300, 800); 
                AlphaC alpha = new AlphaC(104, 17);
            }
        }
        public static void NamekM()
        {
            if (Console.CursorLeft == 93 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.WriteLine("This trip will cost $1200. Have fun!");
                Console.ReadKey();
                if (Stats.EMoney >= 1200)
                {
                    Stats.EMoney -= 1200;
                    Stats.age += 1;
                    Console.Clear();
                    Display.UniverseMap(51, 28);
                }
                else if (Stats.EMoney < 1200)
                {
                    Console.Clear();
                    Console.WriteLine("You're broke.");
                    Console.ReadKey();
                    Console.Clear();
                    Namek namek = new Namek(93, 20);
                }
            }
            else if (Console.CursorLeft == 58 && Console.CursorTop == 14)
            {
                Stats.BuyStore();
                Namek namek = new Namek(58, 14);
            }
            else if (Console.CursorLeft == 62 && Console.CursorTop == 14)
            {
                Stats.SellStore();
                Namek namek = new Namek(62, 14);
            }
            else if (Console.CursorLeft == 62 && Console.CursorTop == 20)
            {
                Stats.SellStore();

                Namek namek = new Namek(62, 20);
            }
            else if (Console.CursorLeft == 58 && Console.CursorTop == 20)
            {
                Stats.BuyStore();

                Namek namek = new Namek(58, 20);
            }
            else if (Console.CursorLeft == 51 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You entered one of Frieza's hut.. Raccoon has spotted you and strucked a pose.\n You died from intense arrousal");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (Console.CursorLeft == 69 && Console.CursorTop == 17)
            {
                Stats.SellStore(100, 600, 200, 1000);
                Namek namek = new Namek(69, 17);
            }
            else if (Console.CursorLeft == 114 && Console.CursorTop == 17)
            {
                Stats.SellStore(600, 100, 1000, 200);

                Namek namek = new Namek(114, 17);
            }
            else if (Console.CursorLeft == 132 && Console.CursorTop == 17)
            {
                Stats.BuyStore(100, 100, 100, 100);
                Namek namek = new Namek(132, 17);
            }
            else if (Console.CursorLeft == 121 && Console.CursorTop == 14)
            {
                Stats.BuyStore(300, 200, 600, 400);
                Namek namek = new Namek(121, 14);
            }
            else if (Console.CursorLeft == 121 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.Write("You entered one of Friez's huts.\nCaptian Ginyu has spotted you and blew you up..");
                Environment.Exit(0);
            }
            else if (Console.CursorLeft == 125 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.WriteLine("You walked into a 'store' and got robbed..\nAll your money and stones were taken.");
                Console.ReadKey();
                Stats.EMoney -= Stats.EMoney;
                if (Stats.diamond >= 1)
                {
                    Stats.diamond -= Stats.diamond;
                }
                if (Stats.jade >= 1)
                {
                    Stats.jade -= Stats.jade;
                }
                if (Stats.crystal >= 1)
                {
                    Stats.crystal -= Stats.crystal;
                }
                if (Stats.ruby >= 1)
                {
                    Stats.ruby -= Stats.ruby;
                }
                Console.Clear();
                Namek namek = new Namek(125, 14);
            }
            else if (Console.CursorLeft == 125 && Console.CursorTop == 20)
            {
                Console.Clear();
                if (t4 < 1)
                {
                    Console.WriteLine("This store is being runned by Frieza's goons...\nTry not to stand out.");
                    Console.WriteLine("You found $2000..");
                    Stats.EMoney += 2000;
                    t4++;
                }
                else if (t4 >= 1)
                {
                    Console.WriteLine("This store is being runned by Frieza's goons...\nTry not to stand out.");
                }
                Console.ReadKey();
                Console.Clear();
                Namek namek = new Namek(125, 20);
            }
            else if (Console.CursorLeft == 93 && Console.CursorTop == 14 || Console.CursorLeft == 92 && Console.CursorTop == 14 || Console.CursorLeft == 91 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.Write("You were caught in Frieza's ship and hit with a lazer.\n\n YOU DIED!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (Console.CursorLeft == 93 && Console.CursorTop == 15 || Console.CursorLeft == 92 && Console.CursorTop == 15 || Console.CursorLeft == 91 && Console.CursorTop == 15)
            {
                if (t5 < 1)
                {
                    Console.Clear();
                    Console.Write("You obtained a dragon ball. This item is priceless.\n\nBy the way this is Frieza's ship be careful...");
                    Stats.dragonball += 1;
                    t5++;
                }
                else if (t5 >=1)
                {
                    return;
                }
                Console.ReadKey();
                Console.Clear();
                Namek namek = new Namek(93, 16);
            }
            else if (Console.CursorLeft == 89 && Console.CursorTop == 20 || Console.CursorLeft == 96 && Console.CursorTop == 13)
            {
                Console.Clear();
                Console.Write("You were hit by a random Special Beam Cannon. \n\nCONGRATS BUD...");
                using (StreamReader sr = new StreamReader(@"C:\Users\Luis Saenz\source\repos\Class Project\Space_Adventure\SpaceAdventure\Example.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (Console.CursorLeft == 60 && Console.CursorTop == 18)
            {
                Console.Clear();
                Console.Write("YOU TELEPORTED, WOAH!!!");
                Console.ReadKey();
                Console.Clear();
                Namek namek = new Namek(123, 18);
            }
            else if (Console.CursorLeft == 123 && Console.CursorTop == 18)
            {
                Console.Clear();
                Console.Write("YOU TELEPORTED, WOAH!!!");
                Console.ReadKey();
                Console.Clear();
                Namek namek = new Namek(60, 18);
            }
        }
        public static void YardratM()
        {
            if (Console.CursorLeft == 49 && Console.CursorTop == 12)
            {
                Console.Clear();
                Console.WriteLine("It cost 2 Diamonds to take the ship.");
                Console.ReadKey();
                if (Stats.diamond >= 2)
                {
                    Stats.diamond -= 2;
                    Stats.age += 1;
                    Console.Clear();
                    Display.UniverseMap(111, 25);
                }
                else if (Stats.diamond < 2)
                {
                    Console.Clear();
                    Console.WriteLine("You do not have enough Diamonds to take this ship.");
                    Console.ReadKey();
                    Console.Clear();
                    Yardrat yardrat = new Yardrat(49, 12);
                }
            }
            else if (Console.CursorLeft == 47 && Console.CursorTop == 15)
            {
                Console.Clear();
                Console.WriteLine("A local 'alien' transported you to outter space causing a very quick death..");
                Console.ReadKey();
                Environment.Exit(0);
            }          
            else if (Console.CursorLeft == 47 && Console.CursorTop == 21)
            {
                if (t7 < 1)
                {
                    Console.Clear();
                    Console.Write("You obtained a dragon ball. This item is priceless.\n\nBy the way this is Frieza's ship be careful...");
                    Stats.dragonball += 1;
                    t7++;
                }
                else if (t7 >= 1)
                {
                   return;
                }
                Console.ReadKey();
                Console.Clear();
                Yardrat yardrat = new Yardrat(47, 21);
            }           
            else if (Console.CursorLeft == 136 && Console.CursorTop == 15)
            {
                Stats.SellStore(100, 600, 1000, 2000);
                Yardrat yardrat = new Yardrat(136, 15);
            }
            else if (Console.CursorLeft == 136 && Console.CursorTop == 15)
            {
                Stats.SellStore(300, 1800, 100, 500);
                Yardrat yardrat = new Yardrat(136, 21);
            }
            else if (Console.CursorLeft == 73 && Console.CursorTop == 11)
            {
                Stats.BuyStore(500, 1000, 600, 300);
                Yardrat yardrat = new Yardrat(73, 11);
            }
            else if (Console.CursorLeft == 105 && Console.CursorTop == 23)
            {
                Stats.BuyStore();
                Yardrat yardrat = new Yardrat(105, 23);
            }
        }
    }
}

