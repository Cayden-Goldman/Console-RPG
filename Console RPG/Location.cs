using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        
       public static Location cellar = new Location("A Cellar", 0, "A dank cellar with nothing but a decaying bed.");
       public static Location hall = new Location("A Hallway", 0, "Just a plain hallway with a few random boxes in it.", new Battle(new List<Enemy>() { Dog.lesserShadowDog }));
       public static Location midNowhere1 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
       public static Location midNowhere2 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
       public static Location midNowhere3 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
       public static Location midNowhere4 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
       public static Location midNowhere5 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
       public static Location midNowhere6 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
       public static Location midNowhere7 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.");
       public static Location midNowhere8 = new Location("The Middle of Nowhere", 1, "A cave that seems infinitely big, yet also like you are being suffocated by the walls.", new Battle(new List<Enemy>() { Dog.lesserShadowDog, Creature.lesserShadowCreature}));
       public static Location midMidNowhere = new Location("The Middle of the Middle of Nowhere", 2, "The middle of a cave that seems infinitely big, yet also... blah blah blah you already know.", new Shop("The #/#/#/#/#", new List<Item>() { SanityPotion.lesserSanityPot, EnergyPotion.lesserEnergyPot }));
       public static Location theHall = new Location("The Hall of Voices", 15, "A hallway filled with whispers that you can't quite make out.", new Battle(new List<Enemy>() { Thing.thing }));
       public static Location theGrave = new Location("The Grave", 100, "A gravestone that reads \"Derek Herrera Sturm ---- 1678 - 2024 ---- Gamed too hard\"", new Battle(new List<Enemy>() { Derek.derek }));

        public string name;
        public int insanityStrength;
        public string description;
        public Event locEvent;

        public Location north, east, south, west;
        public Location(string name, int insanityStrength, string description, Event locEvent = null)
        {
            this.name = name;
            this.insanityStrength = insanityStrength;
            this.description = description;
            this.locEvent = locEvent;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {

            if (!(north is null))
            {
                this.north = north;
                north.south = this;
            }

            if (!(east is null))
            {
                this.east = east;
                east.west = this;
            }

            if (!(south is null))
            {
                this.south = south;
                south.north = this;
            }

            if (!(west is null))
            {
                this.west = west;
                west.east = this;
            }
        }

        public void Resolve(List<Player> players)
        {
            if(this.name == "A Cellar")
            {
                Console.WriteLine("You wake up in " + this.name);
                Console.WriteLine($"-- {this.description} --");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You have entered " + this.name);
                Console.WriteLine($"-- {this.description} --");
                Console.WriteLine();
            }

            //Null checking
            locEvent?.Resolve(players);

            if (!(this.north is null))
                Console.WriteLine("NORTH: " + this.north.name);

            if (!(this.east is null))
                Console.WriteLine("EAST: " + this.east.name);

            if (!(this.south is null))
                Console.WriteLine("SOUTH: " + this.south.name);

            if (!(this.west is null))
                Console.WriteLine("WEST: " + this.west.name);
            string direction = Console.ReadLine().ToLower();
            Console.Clear();
            Location nextLocation = null;

            if (direction.Contains("no"))
                nextLocation = this.north;
            else if (direction.Contains("ea"))
                nextLocation = this.east;
            else if (direction.Contains("so"))
                nextLocation = this.south;
            else if (direction.Contains("we"))
                nextLocation = this.west;
            if (nextLocation is null)
            {
                Console.WriteLine("Please enter a valid direction");
                Resolve(players);
            }

            nextLocation.Resolve(players);
        }
    }
}











































































































































//please subsrcib eto my rediddt