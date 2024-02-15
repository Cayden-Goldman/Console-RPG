using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entities
                //Player
                Console.WriteLine("What is your name, child?");
                Player player = new Player(Console.ReadLine(), 50, 5, new Stats(10, 0));
                //Enemies
                Enemy shadowCreature = new Enemy("Shadow Creature", 30, 5, new Stats(5, 0), 10);
                Enemy shadowDog = new Enemy("Shadow Hound", 30, 5, new Stats(5, 0), 10);
            //Items
                //Sanity Potions
                SanityPotion lesserSanitypot = new SanityPotion("Lesser Sanity Potion", "A murky blue elixir that restores your sanity just a little bit.", 10, 8, "Common", 5);
                SanityPotion Sanitypot = new SanityPotion("Sanity Potion", "A blue elixir that restores your sanity just a decent amount.", 10, 8, "Common", 10);
                SanityPotion GreaterSanitypot = new SanityPotion("Greater Sanity Potion", "A vibrant blue elixir that restores your sanity by a lot.", 10, 8, "Common", 15);
                //Energy Potions
                EnergyPotion lesserEnergypot = new EnergyPotion("Lesser Energy Potion", "A murky yellow elixir that restores your energy just a little bit.", 10, 8, "Common", 5);
                EnergyPotion Energypot = new EnergyPotion("Energy Potion", "A yellow elixir that restores your energy just a decent amount.", 10, 8, "Common", 10);
                EnergyPotion EnergySanitypot = new EnergyPotion("Energy Sanity Potion", "A vibrant yellow elixir that restores your energy by a lot.", 10, 8, "Common", 15);
            //Locations
                Location cellar = new Location("Cellar", 0, "A dank cellar with nothing but a decaying bed.");
                Location placeholder = new Location("Placeholder", 1, "A placeholder area cuz idk what to make yet");
                Location midNowhere1 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere2 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere3 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere4 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midMidNowhere = new Location("The Middle of the Middle of Nowhere", 2, "The middle of a cave that seems infinitely big, yet also... blah blah blah you already know.");
                Location theHall = new Location("The Hall of Voices", 15, "A hallway filled with whispers that you can't quite make out.");

            //Actual Game Code
            cellar.SetNearbyLocations(east: placeholder);
            placeholder.SetNearbyLocations(north: midNowhere1, south: midNowhere2, east: midNowhere3);

            cellar.Resolve();
        }
    }
}
