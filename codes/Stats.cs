using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class Stats
    {
        public static int EMoney = 10000;
        public static int jade = 0;
        public static int diamond = 0;
        public static int ruby = 0;
        public static int crystal = 0;
        public static int age = 18;
        public static int dragonball = 0;


        public Stats(int x = 41, int y = 31)
        {
            Console.SetCursorPosition(x, y);
            if (dragonball >= 1)
            {
                Console.Write($"Age: {Age()}\tMoney: ${Money()}\tJade: {jade}\tDiamond: {diamond}\tRuby: {ruby}\tCrystal: {crystal}\tDragonBalls: {dragonball}");
            }
            else if (dragonball < 1)
            {
                Console.Write($"Age: {Age()}\tMoney: ${Money()}\tJade: {jade}\t\tDiamond: {diamond}\tRuby: {ruby}\t\tCrystal: {crystal}");
            }
        }

        private static int Age()
        {
            int x = age;
            return x;
        }
        private static int Money()
        {
            int x = EMoney;
            return x;
        }
        public static void BuyStore(int j = 500, int d = 1000, int r = 700, int c = 900)
        {
            Console.Clear();
            Console.WriteLine("Welsome!");
            Console.WriteLine("Choose what you want to buy?");
            Console.WriteLine($"a) Jade ${j}\nb) Diamond ${d}\nc) Ruby ${r}\nd) Cyrstal ${c}");
            string choice = Console.ReadLine();
            if (choice == "a")
            {
                if (Stats.EMoney >= j)
                {
                    Stats.EMoney -= j;
                    Stats.jade += 1;
                }
                else if (Stats.EMoney < j)
                {
                    Console.WriteLine("You do not have enough money to purchase");
                    Console.ReadKey();
                }
            }
            else if (choice == "b")
            {
                if (Stats.EMoney >= d)
                {
                    Stats.EMoney -= d;
                    Stats.diamond += 1;
                }
                else if (Stats.EMoney < d)
                {
                    Console.WriteLine("You do not have enough money to purchase");
                    Console.ReadKey();
                }
            }
            else if (choice == "c")
            {
                if (Stats.EMoney >= r)
                {
                    Stats.EMoney -= r;
                    Stats.ruby += 1;
                }
                else if (Stats.EMoney < r)
                {
                    Console.WriteLine("You do not have enough money to purchase");
                    Console.ReadKey();
                }
            }
            else if (choice == "d")
            {
                if (Stats.EMoney >= c)
                {
                    Stats.EMoney -= c;
                    Stats.crystal += 1;
                }
                else if (Stats.EMoney < c)
                {
                    Console.WriteLine("You do not have enough money to purchase");
                    Console.ReadKey();
                }
            }
            Console.Clear();
        }
        public static void SellStore(int j = 400, int d = 900, int r = 600, int c = 800)
        {
            Console.Clear();
            Console.WriteLine("What item would you like to sell?");
            Console.WriteLine($"a) Jade for ${j}\nb) Diamond for ${d}\nc) Ruby for ${r}\nd) Cyrstal for ${c}");
            string item = Console.ReadLine();
            if (item == "a")
            {
                if (Stats.jade >= 1)
                {
                    Console.WriteLine($"You sold a Jade for {j}.");
                    Stats.jade -= 1;
                    Stats.EMoney += j;
                }
                else if (Stats.jade < 1)
                {
                    Console.WriteLine("You do not have a Jade to sell..");
                    Console.ReadKey();
                }
            }
            else if (item == "b")
            {
                if (Stats.diamond >= 1)
                {
                    Console.WriteLine($"You sold a Diamond for {d}.");
                    Stats.diamond -= 1;
                    Stats.EMoney += d;
                }
                else if (Stats.diamond < 1)
                {
                    Console.WriteLine("You do not have a Diamond to sell..");
                    Console.ReadKey();
                }
            }
            else if (item == "c")
            {
                if (Stats.ruby >= 1)
                {
                    Console.WriteLine($"You sold a Ruby for {r}.");
                    Stats.ruby -= 1;
                    Stats.EMoney += r;
                }
                else if (Stats.ruby < 1)
                {
                    Console.WriteLine("You do not have a Ruby to sell..");
                    Console.ReadKey();
                }
            }
            else if (item == "d")
            {
                if (Stats.crystal >= 1)
                {
                    Console.WriteLine($"You sold a Crystal for {c}.");
                    Stats.crystal -= 1;
                    Stats.EMoney += c;
                }
                else if (Stats.crystal < 1)
                {
                    Console.WriteLine("You do not have a Crystal to sell..");
                    Console.ReadKey();
                }
            }
            Console.Clear();
        }


    }
}