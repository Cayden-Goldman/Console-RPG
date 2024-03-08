using System;
using System.Collections.Generic;
using System.Data;
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

    class Boots : Armor
    {
        public static Boots clothBoots = new Boots("Boots", "Just everyday regular boots.", 0, "Common", true, 0, 0);
        public static Boots leatherBoots = new Boots("Leather Boots", "Boots made of leather. They seem like they might provide a small amount of protection.", 0, "Common", false, 1, 5);
        public static Boots sturdyBoots = new Boots("Sturdy Boots", "Sturdy boots made of reinforced leather and metal sheets. They provide a medium amount of protection.", 10, "Uncommon", false, 5, 15);
        public Boots(string name, string flavorText, int shopPrice, string rarity, bool isEquipped, int defIncrease, int sanIncrease) : base(name, flavorText, shopPrice, rarity, isEquipped, defIncrease, sanIncrease)
        {

        }
    }
    class Chestpiece : Armor
    {
        public static Boots clothChestpiece = new Boots("Shirt", "Just an everyday regular shirt.", 0, "Common", true, 0, 0);
        public static Boots leatherChestpiece = new Boots("Leather Chestpiece", "Chestpiece made of leather. It seems like it might provide a small amount of protection.", 0, "Common", false, 1, 5);
        public static Boots sturdyChestpiece = new Boots("Sturdy Chestpiece", "Sturdy Chestpiece made of reinforced leather and metal sheets. It provides a medium amount of protection.", 10, "Uncommon", false, 5, 15);
        public Chestpiece(string name, string flavorText, int shopPrice, string rarity, bool isEquipped, int defIncrease, int sanIncrease) : base(name, flavorText, shopPrice, rarity, isEquipped, defIncrease, sanIncrease)
        {

        }
    }

    class Weapon : Equipment
    {
        public int dmgIncrease;

        public static Weapon stick = new Weapon("Stick", "Just a pointy stick. Seemingly taken from a birch tree", 0, "Common", true, 0);
        public static Weapon rustySword = new Weapon("Rusty Sword", "A rusty bronze sword. Should work for now.", 15, "Common", false, 5);
        public static Weapon swordOfThorns = new Weapon("Sword of Thorns", "A plant sword covered in thorns.", 30, "Rare", false, 15);
        public static Weapon gamblingSword = new Weapon("Sword of Fortune", "A sword seemingly touched by Midas. You feel like you should always bet on yourself while weilding it.", 50, "Epic", false, 15);
        public static Weapon swordOfVoices = new Weapon("The Sword of Voices", "All of the voices in your head channeled into a powerful blade. *Side effects may include schizophrenia*", 100, "Legendary", false, 35);

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
