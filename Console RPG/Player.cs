using System;
using System.Collections.Generic;

namespace Console_RPG
{
    //Inheritance
    class Player : Entity
    {
        public Player(string name, int hp, int mana, Stats stats) : base(name, hp, mana, stats) { }

        public override Entity ChooseTarget(List<Entity> choices)
        {

        }
        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + " attacked " + target.name + "!");
        }
    }
}
