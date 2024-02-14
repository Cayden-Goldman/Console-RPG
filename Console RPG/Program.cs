using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entities
                //Player
                Player player = new Player("Derek", 10, 10, new Stats(1, 1, 1, 1));
                //Enemies
                Enemy richDerek = new Enemy("Rich Derek", 1, 1, new Stats(1, 1, 1, 1), 10000);
            //Items
                //Sanity Potions
                SanityPotion lesserSanitypot = new SanityPotion("Lesser Sanity Potion", "A murky blue elixir that restores your sanity just a little bit.", 10, 8, "Common", 5);
                SanityPotion Sanitypot = new SanityPotion("Sanity Potion", "A blue elixir that restores your sanity just a decent amount.", 10, 8, "Common", 10);
                SanityPotion GreaterSanitypot = new SanityPotion("Greater Sanity Potion", "A vibrant blue elixir that restores your sanity by a lot.", 10, 8, "Common", 15);
                //Energy Potions
                EnergyPotion lesserEnergypot = new EnergyPotion("Lesser Energy Potion", "A murky yellow elixir that restores your energy just a little bit.", 10, 8, "Common", 5);
                EnergyPotion Energypot = new EnergyPotion("Energy Potion", "A yellow elixir that restores your energy just a decent amount.", 10, 8, "Common", 10);
                EnergyPotion EnergySanitypot = new EnergyPotion("Energy Sanity Potion", "A vibrant yellow elixir that restores your energy by a lot.", 10, 8, "Common", 15);
        }
    }
}
