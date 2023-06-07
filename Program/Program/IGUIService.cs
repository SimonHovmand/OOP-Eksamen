using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    internal interface IGUIService
    {
        void showallfighter(List<Hero> a);  //Sets shwoallfighter to void, with the refrence to the Item list
        int SelectFighter1(); //Sets SelectFighter1 to int
        int SelectFighter2(int choise1); //Sets SelectFighter2 to int
        void ShowFighters(int choise1, int choise2, List<Hero> a); //Sets ShowFighter to void, with the refrence to int choise1, int choise2 and the Item list
        int Fight(int choise1, int choise2, List<Hero> a); //Sets Fight to int, with the refrence to int choise1, int choise2 and the Item list

    }
}
