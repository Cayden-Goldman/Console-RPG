using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    abstract class Enemy : Entity
    {
        public int coinsDropped;

        public Enemy(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats)
        {
            this.coinsDropped = coinsDropped;
        }

    }

    class Dog : Enemy
    {
        public static Dog lesserShadowDog = new Dog("Lesser Shadow Hound", "A shadowy pup shaped creature. I wouldn't reccomend petting it...", 30, 5, new Stats(5, 0), 10);
        public static Dog greaterShadowDog = new Dog("Greater Shadow Hound", "A shadowy wolf shaped creature. I definitely wouldn't reccomend petting it...", 80, 5, new Stats(15, 5), 50);

        public Dog(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
        {

        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            return choices[0];
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
        public override void Attack(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {this.stats.attack} damage!");
            target.currentSanity = target.currentSanity - this.stats.attack;
            Console.WriteLine($"{target.name} has {target.currentSanity} left!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Creature : Enemy
    {
        public static Creature lesserShadowCreature = new Creature("Lesser Shadow Creature", "A small shadowy blob filled with nothing but darkness.", 30, 5, new Stats(5, 0), 10);
        public static Creature greaterShadowCreature = new Creature("Greater Shadow Creature", "A lanky shadow blob filled with nothing but hatred and darkness.", 150, 5, new Stats(10, 10), 50);
        public Creature(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
        {

        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            return choices[0];
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }
        public override void Attack(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {this.stats.attack} damage!");
            target.currentSanity = target.currentSanity - this.stats.attack;
            Console.WriteLine($"{target.name} has {target.currentSanity} left!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Derek : Enemy
    {

        public static Derek derek = new Derek("Ghost of Derek Herrera Sturm", "The fallen spirit of Derek Herrera Sturm. What an unfortunate way to go out...", 30, 0, new Stats(1, 0), 10);

        public Derek(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
        {

        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            return choices[0];
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }
        public override void Attack(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {this.stats.attack} damage!");
            target.currentSanity = target.currentSanity - this.stats.attack;
            Console.WriteLine($"{target.name} has {target.currentSanity} left!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Thing : Enemy
    {

        public static Thing thing = new Thing("@&)%^@(*&#$&%(!", "A creature that always seems blurry and faded...   ...)!&$*&!$#???", 200, 5, new Stats(15, 15), 0);

        public Thing(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
        {

        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            return choices[0];
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }
        public override void Attack(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {this.stats.attack} damage!");
            target.currentSanity = target.currentSanity - this.stats.attack;
            Console.WriteLine($"{target.name} has {target.currentSanity} left!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
