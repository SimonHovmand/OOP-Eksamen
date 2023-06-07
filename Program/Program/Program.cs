namespace FightArena
{
    public class Program
    {
        static void Main(string[] args)
        {
            IController ctrl = new Controller(new GUIService(), new HeroService());

            ctrl.showallfighter(); //Calls Showallfighter to show all the fighters

            int choise1 = ctrl.SelectFighter1(); //An int variable that calls SelectFighter1

            int choise2 = ctrl.SelectFighter2(choise1); //An int variable that calls SelectFighter2

            ctrl.ShowFighters(choise1, choise2); //Calls ShowFighters

            int looser = ctrl.Fight(choise1, choise2); //An int variable that calls Fight

            ctrl.RemoveLooser(looser); //Calls RemoveLooser
        }
    }
}