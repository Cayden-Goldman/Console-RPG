using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Enemy : Entity
    {
        public int coinsDropped;

        public Enemy(string name, int hp, int mana, Stats stats, int coinsDropped) : base(name, hp, mana, stats)
        {
            this.coinsDropped = coinsDropped;
        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            Random random = new Random();
            return choices[random.Next(0, choices.Count)];
        }

        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + " attacked " + target.name + "!");
        }
    }
}
