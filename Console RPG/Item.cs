using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {
        public string name;
        public string flavorText;
        public int shopPrice;
        public int sellValue;
        public string rarity;

        public Item(string name, string flavorText, int shopPrice, int sellValue, string rarity)
        {
            this.name = name;
            this.flavorText = flavorText;
            this.shopPrice = shopPrice;
            this.sellValue = sellValue;
            this.rarity = rarity;
        }

        public abstract void Use(Entity user, Entity target);
    }
}
