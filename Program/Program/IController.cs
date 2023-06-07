using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    internal interface IController
    {
        void showallfighter(); //Sets showallfighter to void
        int SelectFighter1(); //Sets the value SelectFighter1 to int
        int SelectFighter2(int choise1); //sets the value of SelectFighter2 to int, with the refrence to int choise1
        void ShowFighters(int choise1, int choise2); //sets the value of ShowFighters to int, with the refrence to int choise1 and int choise2
        int Fight(int choise1, int choise2); //Sets the value of Fight to int, with the refrence to int choise1 and int choise2
        void RemoveLooser(int looser); //Sets the value of RemoveLooser to void, with the refrence to int looser
    }
}
