using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Enemy : Entity
    {
        public int coinsDropped;

        public Enemy(string name, int sanity, int mana, Stats stats, int coinsDropped) : base(name, sanity, mana, stats)
        {
            this.coinsDropped = coinsDropped;
        }

        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + " attacked " + target.name + "!");
        }
    }
}
