using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    internal interface IGUIService
    {
        void showallfighter(List<Hero> a);
        int SelectFighter1();
        int SelectFighter2(int choise1);
        void ShowFighters(int choise1, int choise2, List<Hero> a);
        int Fight(int choise1, int choise2, List<Hero> a);

    }
}
