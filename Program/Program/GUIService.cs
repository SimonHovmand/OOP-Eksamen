using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    internal class GUIService : IGUIService
    {
        public void showallfighter(List<Hero> a)
        {
            foreach (Hero hero in a)
            {
                Console.WriteLine($"{hero.id} = {hero.name}, {hero.hitpoint}, {hero.lowattack} - {hero.highattack}, {hero.lowdefence} - {hero.highdefence}");
            }
        }

        public int SelectFighter1()
        {
            Console.WriteLine("Indtast ID'et på den første fighter.");

            int choise1 = 0;

            String Line = Console.ReadLine();

            while (!Int32.TryParse(Line, out choise1))
            {
                Console.WriteLine("Der skete en fejl, indtast ID'et på den første fighter.");

                Line = Console.ReadLine();
            }
            return choise1;
        }

        public int SelectFighter2(int choise1)
        {
            while (true)
            {
                Console.WriteLine("Indtast ID'et på den anden fighter.");

                int choise2 = 0;

                String Line = Console.ReadLine();

                while (!Int32.TryParse(Line, out choise2))
                {
                    Console.WriteLine("der skete en fejl, indtast ID'et på den anden fighter.");

                    Line = Console.ReadLine();
                }

                if (choise1 == choise2)
                {
                    Console.WriteLine("Du må ikke intaste det samme ID som på den første figther!");

                    String Line2 = Console.ReadLine();

                    while (!Int32.TryParse(Line2, out choise2))
                    {
                        Console.WriteLine("der skete en fejl, indtast ID'et på den anden fighter.");

                        Line2 = Console.ReadLine();
                    }
                } else
                {
                    return choise2;
                }
            }
        }

        public void ShowFighters (int choise1, int choise2, List<Hero> a)
        {
            int count1 = 0;
            int count2 = 0;
            foreach (Hero hero in a)
            {
                if (count1 < a.Count)
                {
                    if (choise1 == hero.id)
                    {
                        Console.WriteLine($"{hero.id} = {hero.name}, {hero.hitpoint}, {hero.lowattack} - {hero.highattack}, {hero.lowdefence} - {hero.highdefence}");
                    } else {
                        count1++;
                    }
                } else {
                    Console.WriteLine("Fighteren findes ikke");
                }

                if (count2 < a.Count)
                {
                    if (choise2 == hero.id)
                    {
                        Console.WriteLine($"{hero.id} = {hero.name}, {hero.hitpoint}, {hero.lowattack} - {hero.highattack}, {hero.lowdefence} - {hero.highdefence}");
                    } else {
                        count2++;
                    }
                } else {
                    Console.WriteLine("Fighteren findes ikke");
                }
            }
        }
        public int Fight(int choise1, int choise2, List<Hero> a)
        {
            Random rnd = new Random();

            int f1H = 0;
            int f1A = 0;
            int f1D = 0;

            int f2H = 0;
            int f2A = 0;
            int f2D = 0;

            foreach (Hero hero in a)
            {
                if (choise1 == hero.id)
                {
                    f1H = hero.hitpoint;
                    f1A = rnd.Next(hero.lowattack, hero.highattack);
                    f1D = rnd.Next(hero.lowattack, hero.highattack);
                }
                if (choise2 == hero.id)
                {
                    f2H = hero.hitpoint;
                    f2A = rnd.Next(hero.lowattack, hero.highattack);
                    f2D = rnd.Next(hero.lowattack, hero.highattack);
                }
            }

            bool run = true;

            while (run)
            {
                if (f1H > 0)
                {
                    f2H = f2H - (f2D - f1A);
                } else
                {
                    Console.WriteLine($"Fighter 1 død ({f1H})");
                    run = false;
                    return choise1;
                }

                if (f2H > 0)
                {
                    f1H = f1H - (f1D - f2A);
                } else
                {
                    Console.WriteLine($"Fighter 2 død ({f2H})");
                    run = false;
                    return choise2;
                }
            }
            return 0;

        }

    }
}
