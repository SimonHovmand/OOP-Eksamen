namespace FightArena
{
    public class Program
    {
        static void Main(string[] args)
        {
            IController ctrl = new Controller(new GUIService(), new HeroService());

            ctrl.showallfighter();

            int choise1 = ctrl.SelectFighter1();

            int choise2 = ctrl.SelectFighter2(choise1);

            ctrl.ShowFighters(choise1, choise2);

            int looser = ctrl.Fight(choise1, choise2);

            ctrl.RemoveLooser(looser);
        }
    }
}