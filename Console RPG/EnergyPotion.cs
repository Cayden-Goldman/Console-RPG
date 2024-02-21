using System;

namespace Console_RPG
{
    class EnergyPotion : Item
    {
        public static EnergyPotion lesserEnergyPot = new EnergyPotion("Lesser Energy Potion", "A murky yellow elixir that restores your energy just a little bit.", 10, 8, "Common", 1);
        public static EnergyPotion energyPot = new EnergyPotion("Energy Potion", "A yellow elixir that restores your energy just a decent amount.", 20, 16, "Uncommon", 2);
        public static EnergyPotion GreaterEnergyPot = new EnergyPotion("Greater Energy Potion", "A vibrant yellow elixir that restores your energy by a lot.", 30, 24, "Rare", 3);

        public int energyAmount;

        public EnergyPotion(string name, string flavorText, int shopPrice, int sellValue, string rarity, int energyAmount) : base(name, flavorText, shopPrice, sellValue, rarity)
        {
            this.energyAmount = energyAmount;
        }

        public override void Use(Entity user, Entity target)
        {
            target.currentEnergy += this.energyAmount;
            Console.WriteLine(target.name + " has had their energy restored by " + this.energyAmount + ".");
        }
    }
}
