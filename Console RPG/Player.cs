using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    //Inheritance
    class Player : Entity
    {
        
        public static Player player = new Player("Sophie", "Literally you.", 50, 5, new Stats(10, 0));

        public Player(string name, string description, int sanity, int energy, Stats stats) : base(name, description, sanity, energy, stats) { }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            Console.WriteLine("Who would you like to use this action on?");
            for (int i = 0; i < choices.Count; i++)
            {
                Console.Write($"{i + 1}: {choices[i].name}  ");
            }
            Console.WriteLine();

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
            
        }
        public override void Attack(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {this.stats.attack} damage!");
            target.currentSanity = target.currentSanity - this.stats.attack;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }

    }
}
