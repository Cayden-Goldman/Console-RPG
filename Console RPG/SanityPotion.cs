using System;

namespace Console_RPG
{
    class SanityPotion : Item
    {
        public static SanityPotion lesserSanityPot = new SanityPotion("Lesser Sanity Potion", "A murky blue elixir that restores your sanity just a little bit.", 10, "Common", 5);
        public static SanityPotion sanityPot = new SanityPotion("Sanity Potion", "A blue elixir that restores your sanity just a decent amount.", 20, "Uncommon", 10);
        public static SanityPotion greaterSanityPot = new SanityPotion("Greater Sanity Potion", "A vibrant blue elixir that restores your sanity by a lot.", 30, "Rare", 15);

        public int sanityAmount;

        public SanityPotion(string name, string flavorText, int shopPrice, string rarity, int sanityAmount) : base(name, flavorText, shopPrice, rarity)
        {
            this.sanityAmount = sanityAmount;
        }

        public override void Use(Entity user, Entity target)
        {
            target.currentSanity += this.sanityAmount;
            Console.WriteLine(target.name + " has had their sanity restored by " + this.sanityAmount + ".");
        }
    }
}
