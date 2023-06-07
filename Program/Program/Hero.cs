using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    public class Hero
    {
        public int id;
        public string name;
        public int hitpoint;
        public int lowattack;
        public int highattack;
        public int lowdefence;
        public int highdefence;

        public Hero(int id, string name, int hitpoint, int lowattack, int highattack, int lowdefence, int highdefence)
        {
            this.id = id;
            this.name = name;
            this.hitpoint = hitpoint;
            this.lowattack = lowattack;
            this.highattack = highattack;
            this.lowdefence = lowdefence;
            this.highdefence = highdefence;
        }
    }

    //public class KongFuHarry : Hero
    //{
    //    public int attack;
    //    public int defence;

    //    public KongFuHarry(int hitpoint, int attack, int defence) :base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.attack = attack;
    //        this.defence = defence;
    //    }
    //}

    //public class Dino : Hero
    //{
    //    public IEnumerable<int> attack;
    //    public IEnumerable<int> defence;

    //    public Dino(int hitpoint, IEnumerable<int> attack, IEnumerable<int> defence) : base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.attack = attack;
    //        this.defence = defence;
    //    }
    //}

    //public class HurtigKarl : Hero
    //{
    //    public int uppercut;
    //    public int left;

    //    public HurtigKarl(int hitpoint, int uppercut, int left) : base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.uppercut = uppercut;
    //        this.left = left;
    //    }
    //}

    //public class GiftGunner : Hero
    //{
    //    public IEnumerable<int> attack;
    //    public int defence;

    //    public GiftGunner(int hitpoint, IEnumerable<int> attack, int defence) : base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.attack = attack;
    //        this.defence = defence;
    //    }
    //}

    //public class MinimusenMikkel : Hero
    //{
    //    public int attack;
    //    public int defence;

    //    public MinimusenMikkel(int hitpoint, int attack, int defence) : base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.attack = attack;
    //        this.defence = defence;
    //    }
    //}

    //public class KattenTiger : Hero
    //{
    //    public int attack;
    //    public int defence;

    //    public KattenTiger(int hitpoint, int attack, int defence) : base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.attack = attack;
    //        this.defence = defence;
    //    }
    //}

    //public class GummigedenIvan : Hero
    //{
    //    public int attack;
    //    public int defence;

    //    public GummigedenIvan(int hitpoint, int attack, int defence) : base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.attack = attack;
    //        this.defence = defence;
    //    }
    //}

    //public class elgenEgon : Hero
    //{
    //    public IEnumerable<int> attack;
    //    public int defence;

    //    public elgenEgon(int hitpoint, IEnumerable<int> attack, int defence) : base(hitpoint)
    //    {
    //        this.hitpoint = hitpoint;
    //        this.attack = attack;
    //        this.defence = defence;
    //    }
    //}
}
