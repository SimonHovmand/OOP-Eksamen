using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    internal class GUIService : IGUIService
    {
        public void showallfighter(List<Hero> a) //Prints all the fighters
        {
            foreach (Hero hero in a)
            {
                Console.WriteLine($"{hero.id} = {hero.name}, {hero.hitpoint}, {hero.lowattack} - {hero.highattack}, {hero.lowdefence} - {hero.highdefence}");
            }
        }

        public int SelectFighter1() //Makes you select a fighter
        {
            Console.WriteLine("Indtast ID'et på den første fighter.");

            int choise1 = 0;

            String Line = Console.ReadLine();

            while (!Int32.TryParse(Line, out choise1)) //Checks if the input is a number
            {
                Console.WriteLine("Der skete en fejl, indtast ID'et på den første fighter.");

                Line = Console.ReadLine();
            }
            return choise1; //Returns the choise
        }

        public int SelectFighter2(int choise1) //Makes you select a fighter
        {
            while (true)
            {
                Console.WriteLine("Indtast ID'et på den anden fighter.");

                int choise2 = 0;

                String Line = Console.ReadLine();

                while (!Int32.TryParse(Line, out choise2))  //Checks if the input is a number
                {
                    Console.WriteLine("der skete en fejl, indtast ID'et på den anden fighter.");

                    Line = Console.ReadLine();
                }

                if (choise1 == choise2) //Checks if choise2 is the same as choise1
                {
                    Console.WriteLine("Du må ikke intaste det samme ID som på den første figther!");

                    String Line2 = Console.ReadLine();

                    while (!Int32.TryParse(Line2, out choise2))  //Checks if the input is a number
                    {
                        Console.WriteLine("der skete en fejl, indtast ID'et på den anden fighter.");

                        Line2 = Console.ReadLine();
                    }
                } else
                {
                    return choise2;  //Returns the choise
                }
            }
        }

        public void ShowFighters (int choise1, int choise2, List<Hero> a) //Prints the list of the choosen heros/fighters
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
        public int Fight(int choise1, int choise2, List<Hero> a) //The fight
        {
            Random rnd = new Random();

            int f1H = 0;
            int f1A = 0;
            int f1D = 0;

            int f2H = 0;
            int f2A = 0;
            int f2D = 0;

            foreach (Hero hero in a) //Sets the hitpoint, attack and defence values
            {
                if (choise1 == hero.id)
                {
                    f1H = hero.hitpoint;
                    f1A = rnd.Next(hero.lowattack, hero.highattack); //Sets the attack to be a number between the low and high attack
                    f1D = rnd.Next(hero.lowattack, hero.highattack);  //Sets the defence  to be a number between the low and high defence
                }
                if (choise2 == hero.id)
                {
                    f2H = hero.hitpoint;
                    f2A = rnd.Next(hero.lowattack, hero.highattack);  //Sets the attack to be a number between the low and high attack
                    f2D = rnd.Next(hero.lowattack, hero.highattack); //Sets the defence  to be a number between the low and high defence
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
