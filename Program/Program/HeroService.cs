
namespace FightArena
{
    internal class HeroService
    {

        public List<Hero> heroes = new List<Hero>(); //Making a list to store the heros

        public HeroService() //Constructor making the herom
        {
            heroes.Add(new Hero(1, "Kong Fu Harry", 120, 2,2, 5,5));
            heroes.Add(new Hero(2, "Super Hunden Dino", 70, 6,8, 2,8));
            heroes.Add(new Hero(3, "Hurtig Karl" ,90, 2,5, 3,3));
            heroes.Add(new Hero(4, "GiftGunner", 90, 1,13, 5,5));
            heroes.Add(new Hero(5, "Minimusen Mikkel", 40, 9,9, 9,9));
            heroes.Add(new Hero(6, "Katten Tiger", 35, 3,6, 4,4));
            heroes.Add(new Hero(7, "Gummigeden Ivan", 70, 6,6, 8,8));
            heroes.Add(new Hero(8, "Elgen Egon", 90, 5,11, 4,4));
        }

        public void RemoveLooser(int looser) 
        {
            foreach (Hero hero in heroes)
            {
                if (looser == hero.id)
                {
                    Console.WriteLine("test1");
                }
            }
        }
    }
}
