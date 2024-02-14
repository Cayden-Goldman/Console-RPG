using System;

namespace Console_RPG
{
    class EnergyPotion : Item
    {
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
