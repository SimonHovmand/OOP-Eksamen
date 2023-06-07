using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    internal class Controller : IController
    {
        private readonly IGUIService _guiservice;
        private readonly HeroService _heroservice;

        public Controller(IGUIService gui, HeroService item)
        {
            _guiservice = gui;
            _heroservice = item;
        }

        public void showallfighter()
        {
            this._guiservice.showallfighter(_heroservice.heroes);
        }

        public int SelectFighter1()
        {
            return this._guiservice.SelectFighter1();
        }

        public int SelectFighter2(int choise1)
        {
            return this._guiservice.SelectFighter2(choise1);
        }

        public void ShowFighters(int choise1, int choise2)
        {
            this._guiservice.ShowFighters(choise1, choise2, _heroservice.heroes);
        }

        public int Fight(int choise1, int choise2)
        {
            return this._guiservice.Fight(choise1, choise2, _heroservice.heroes);
        }
        public void RemoveLooser(int looser)
        {
            this._heroservice.RemoveLooser(looser);
        }
    }
}
