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
        int damageTaken;
        public static Dog lesserShadowDog = new Dog("Lesser Shadow Hound", "A shadowy pup shaped creature. I wouldn't reccomend petting it...", 20, 5, new Stats(5, 0), 10);
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
            damageTaken = this.stats.attack - target.stats.defense;
            if (damageTaken <= 0)
            {
                damageTaken = 0;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {damageTaken} damage!");
            target.currentSanity = target.currentSanity - damageTaken;
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
    }
    class Creature : Enemy
    {
        int damageTaken;
        public static Creature lesserShadowCreature = new Creature("Lesser Shadow Creature", "A small shadowy blob filled with nothing but darkness.", 20, 5, new Stats(5, 0), 10);
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
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
        public override void Attack(Entity target)
        {
            damageTaken = this.stats.attack - target.stats.defense;
            if (damageTaken <= 0)
            {
                damageTaken = 0;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {(this.stats.attack - target.stats.defense)} damage!");
            target.currentSanity = target.currentSanity - (this.stats.attack - target.stats.defense);
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
    }
    class Derek : Enemy
    {
        int damageTaken;
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
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
        public override void Attack(Entity target)
        {
            damageTaken = this.stats.attack - target.stats.defense;
            if (damageTaken <= 0)
            {
                damageTaken = 0;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {(this.stats.attack - target.stats.defense)} damage!");
            target.currentSanity = target.currentSanity - (this.stats.attack - target.stats.defense);
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
    }

    class Thing : Enemy
    {
        int damageTaken;
        public static Thing thing = new Thing("@&)%^@(*&#$&%(!", "A creature that always seems blurry and faded...   ...)!&$*&!$#???", 200, 5, new Stats(60, 15), 0);

        public Thing(string name, string description, int sanity, int energy, Stats stats, int coinsDropped) : base(name, description, sanity, energy, stats, coinsDropped)
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
            damageTaken = this.stats.attack - target.stats.defense;
            if (damageTaken <= 0)
            {
                damageTaken = 0;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.name} attacked {target.name} and did {(this.stats.attack - target.stats.defense)} damage!");
            target.currentSanity = target.currentSanity - (this.stats.attack - target.stats.defense);
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
    }
}
