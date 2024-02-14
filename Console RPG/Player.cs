using System;
using System.Collections.Generic;

namespace Console_RPG
{
    //Inheritance
    class Player : Entity
    {
        public Player(string name, int sanity, int mana, Stats stats) : base(name, sanity, mana, stats) { }

        public static Entity ChooseTarget(List<Entity> choices)
        {
            Console.WriteLine("Who would you like to use this action on?");
            Console.WriteLine();
            return choices[Int32.Parse(Console.ReadLine())];
            
        }
        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + " attacked " + target.name + "!");
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
    }
}
