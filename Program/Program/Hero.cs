using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    public class Hero //Hero Class
    {
        //Making the variables
        public int id;
        public string name; 
        public int hitpoint;
        public int lowattack;
        public int highattack;
        public int lowdefence;
        public int highdefence;

        public Hero(int id, string name, int hitpoint, int lowattack, int highattack, int lowdefence, int highdefence) //Constructor for making a Item
        {
            //Setting the variables
            this.id = id;
            this.name = name;
            this.hitpoint = hitpoint;
            this.lowattack = lowattack;
            this.highattack = highattack;
            this.lowdefence = lowdefence;
            this.highdefence = highdefence;
        }
    }
}