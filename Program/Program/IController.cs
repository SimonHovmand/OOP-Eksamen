using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    internal interface IController
    {
        void showallfighter();
        int SelectFighter1();
        int SelectFighter2(int choise1);
        void ShowFighters(int choise1, int choise2);
        int Fight(int choise1, int choise2);
        void RemoveLooser(int looser);
    }
}
