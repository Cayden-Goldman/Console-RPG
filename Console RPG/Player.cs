using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    //Inheritance
    class Player : Entity
    {
        public static List<Item> Inventory = new List<Item>() { SanityPotion.lesserSanityPot };
        public static int CoinCount = 0;
        
        public static Player player = new Player("Sophie", "Literally you.", 50, 5, new Stats(10, 0));

        public Armor headgear, chestpiece, legwear;
        public Weapon weapon;

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
            Console.Clear();
            return choices[index - 1];
            
        }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("Which item would you like to use?");
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
            if (target.currentSanity < 0)
            {
                target.currentSanity = 0;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{target.name} has ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{target.currentSanity} HP");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" left.");
            Console.WriteLine();
            Console.WriteLine();
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("ATTACK | ITEM");
            string choice = Console.ReadLine().ToLower();
            if (choice == "attack")
            {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
            }
            else if (choice == "item")
            {
                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                item.Use(this, target);
                Inventory.Remove(item);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                DoTurn(players, enemies);
            }
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }

    }
}
