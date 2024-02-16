using System;
using System.Collections.Generic;

namespace Console_RPG
{
    abstract class Enemy : Entity
    {
        public int coinsDropped;

        public Enemy(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats)
        {
            this.coinsDropped = coinsDropped;
        }

        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + " attacked " + target.name + "!");
        }
    }

    class Dog : Enemy
    {
        public Dog(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
        {

        }
    }
    class Creature : Enemy
    {
        public Creature(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
        {

        }
    }
    class Derek : Enemy
    {
        public Derek(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
        {

        }
    }

}
