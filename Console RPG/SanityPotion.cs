using System;

namespace Console_RPG
{
    class SanityPotion : Item
    {
        public static SanityPotion lesserSanityPot = new SanityPotion("Lesser Sanity Potion", "A murky blue elixir that restores your sanity just a little bit.", 10, "Common", 10);
        public static SanityPotion sanityPot = new SanityPotion("Sanity Potion", "A blue elixir that restores your sanity just a decent amount.", 20, "Uncommon", 20);
        public static SanityPotion greaterSanityPot = new SanityPotion("Greater Sanity Potion", "A vibrant blue elixir that restores your sanity by a lot.", 30, "Rare", 30);

        public int sanityAmount;

        public SanityPotion(string name, string flavorText, int shopPrice, string rarity, int sanityAmount) : base(name, flavorText, shopPrice, rarity)
        {
            this.sanityAmount = sanityAmount;
        }

        public override void Use(Entity user, Entity target)
        {
            if (target.currentSanity + this.sanityAmount > target.maxSanity)
            {
                target.currentSanity = target.maxSanity;
            }
            else
            {
                target.currentSanity += this.sanityAmount;

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(target.name + " has had their sanity restored by " + this.sanityAmount + ".");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{target.name} has ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{target.currentSanity} HP");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" left.");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
