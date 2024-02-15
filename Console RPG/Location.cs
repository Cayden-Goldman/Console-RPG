using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public string name;
        public int insanityStrength;
        public string description;

        public Location north, east, south, west;
        public Location(string name, int insanityStrength, string description)
        {
            this.name = name;
            this.insanityStrength = insanityStrength;
            this.description = description;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;

            if (!(north is null))
                north.south = this;

            if (!(east is null))
                east.west = this;

            if (!(south is null))
                south.north = this;

            if (!(west is null))
                west.east = this;
        }

        public void Resolve()
        {
            Console.WriteLine("You have entered " + this.name);
            Console.WriteLine(this.description);

            if (!(this.north is null))
                Console.WriteLine("NORTH: " + this.north.name);

            if (!(this.east is null))
                Console.WriteLine("EAST: " + this.east.name);

            if (!(this.south is null))
                Console.WriteLine("SOUTH: " + this.south.name);

            if (!(this.west is null))
                Console.WriteLine("WEST: " + this.west.name);
            string direction = Console.ReadLine();
            Location nextLocation = null;

            if (direction == "north")
                nextLocation = this.north;
            if (direction == "east")
                nextLocation = this.east;
            if (direction == "south")
                nextLocation = this.south;
            if (direction == "west")
                nextLocation = this.west;

            nextLocation.Resolve();
        }
    }
}
