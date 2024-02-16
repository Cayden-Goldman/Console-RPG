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
                Player player = new Player(Console.ReadLine(), "Literally you.", 50, 5, new Stats(10, 0));
                Console.Clear();
                //Enemies
                Creature lesserShadowCreature = new Creature("Lesser Shadow Creature", "A small shadowy blob filled with nothing but darkness.", 30, 5, new Stats(5, 0), 10);
                Creature greaterShadowCreature = new Creature("Greater Shadow Creature", "A lanky shadow blob filled with nothing but hatred and darkness.", 150, 5, new Stats(10, 10), 50);
                Dog lesserShadowDog = new Dog("Lesser Shadow Hound", "A shadowy pup shaped creature. I wouldn't reccomend petting it...", 30, 5, new Stats(5, 0), 10);
                Dog greaterShadowDog = new Dog("Greater Shadow Hound", "A shadowy wolf shaped creature. I definitely wouldn't reccomend petting it...", 80, 5, new Stats(15, 5), 50);
                Derek derek = new Derek("Ghost of Derek Herrera Sturm", "The fallen spirit of Derek Herrera Sturm. What an unfortunate way to go out...", 10, 0, new Stats(1, 0), 10);
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
                Location hall = new Location("A Hallway", 0, "Just a plain hallway with a few random boxes in it.");
                Location midNowhere1 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere2 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere3 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere4 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere5 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere6 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere7 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midNowhere8 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
                Location midMidNowhere = new Location("The Middle of the Middle of Nowhere", 2, "The middle of a cave that seems infinitely big, yet also... blah blah blah you already know.");
                Location theHall = new Location("The Hall of Voices", 15, "A hallway filled with whispers that you can't quite make out.");
                Location theGrave = new Location("The Grave", 100, "A gravestone that reads \"Derek Herrera Sturm ---- 1678 - 2024 ---- Gamed too hard\"");

            //Actual Game Code
            cellar.SetNearbyLocations(east: hall);
            hall.SetNearbyLocations(east: midNowhere1);
            midNowhere1.SetNearbyLocations(north: midNowhere2, east: midMidNowhere, south: midNowhere3);
            midNowhere4.SetNearbyLocations(west: midMidNowhere, north: midNowhere5, south: midNowhere6, east: theHall);
            midMidNowhere.SetNearbyLocations(north: midNowhere7, south: midNowhere8, west: midNowhere1, east: midNowhere4);
            midNowhere7.SetNearbyLocations(west: midNowhere2, east: midNowhere5, south: midMidNowhere);
            midNowhere8.SetNearbyLocations(west: midNowhere3, east: midNowhere6);
            theGrave.SetNearbyLocations(south: midNowhere7);

            cellar.Resolve();
        }
    }
}
