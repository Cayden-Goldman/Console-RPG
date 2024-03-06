using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Equipment : Item
    {
        public bool isEquipped;

        protected Equipment(string name, string flavorText, int shopPrice, string rarity, bool isEquipped) : base(name, flavorText, shopPrice, rarity)
        {
            this.isEquipped = isEquipped;
        }
    }

    class Armor : Equipment
    {
        public int defIncrease;
        public int sanIncrease;

        public Armor(string name, string flavorText, int shopPrice, string rarity, bool isEquipped, int defIncrease, int sanIncrease) : base(name, flavorText, shopPrice, rarity, isEquipped)
        {
            this.defIncrease = defIncrease;
            this.sanIncrease = sanIncrease;
        }

        public override void Use(Entity user, Entity target)
        {
            this.isEquipped = !this.isEquipped;

            if(this.isEquipped)
            {
                Console.WriteLine($"You have equipped {this.name}!");
                target.stats.defense += this.defIncrease;
                target.maxSanity += this.sanIncrease;
            }
            else
            {
                Console.WriteLine($"You have unequipped {this.name}!");
                target.stats.defense -= this.defIncrease;
                target.maxSanity -= this.sanIncrease;
            }
        }
    }

    class Weapon : Equipment
    {
        public int dmgIncrease;

        public static Weapon stick = new Weapon("Stick", "Just a pointy stick. Seemingly taken from a birch tree", 0, "Common", false, 0);
        public static Weapon rustySword = new Weapon("Rust Sword", "A rusty bronze sword. Should work for now.", 15, "Common", false, 5);
        public static Weapon swordOfVoices = new Weapon("The Sword of Voices", "All of the voices in your head channeled into a powerful blade. *Side effects may include schizophrenia", 100, "Legendary", false, 25);

        public Weapon(string name, string flavorText, int shopPrice, string rarity, bool isEquipped, int dmgIncrease) : base(name, flavorText, shopPrice, rarity, isEquipped)
        {
            this.dmgIncrease = dmgIncrease;
        }

        public override void Use(Entity user, Entity target)
        {
            this.isEquipped = !this.isEquipped;

            if (this.isEquipped)
            {
                Console.WriteLine($"You have equipped {this.name}!");
                target.stats.attack += this.dmgIncrease;
            }
            else
            {
                Console.WriteLine($"You have unequipped {this.name}!");
                target.stats.attack -= this.dmgIncrease;
            }
        }
    }
}
