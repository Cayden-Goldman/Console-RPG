using System;
using System.Collections.Generic;

namespace Console_RPG
{
    //Inheritance
    class Player : Entity
    {
        
        public static Player player = new Player("Sophie", "Literally you.", 50, 5, new Stats(10, 0));

        public Player(string name, string description, int sanity, int energy, Stats stats) : base(name, description, sanity, energy, stats) { }

        public static Entity ChooseTarget(List<Entity> choices)
        {
            Console.WriteLine("Who would you like to use this action on?");
            return null;
            
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
