using System;

namespace Console_RPG
{
    class SanityPotion : Item
    {
        public int sanityAmount;

        public SanityPotion(string name, string flavorText, int shopPrice, int sellValue, string rarity, int sanityAmount) : base(name, flavorText, shopPrice, sellValue, rarity)
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
