using System;
using System.Threading;
using System.Collections.Generic;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintLineSlow("The voices...");
            //Thread.Sleep(50);
            //PrintLineFast("Enter to continue.");
            //Console.ReadLine();
            //Console.Clear();
            //PrintLineSlow("The voices are getting stronger...");
            //Thread.Sleep(50);
            //PrintLineFast("Enter to continue.");
            //Console.ReadLine();
            //Console.Clear();
            //PrintLineSlow("I can't get them out...");
            //Thread.Sleep(50);
            //PrintLineFast("Enter to continue.");
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Blue;
            //PrintLineSlow("One voice in particular stands out...");
            //Thread.Sleep(50);
            //PrintLineFast("Enter to continue.");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.ReadLine();
            //Console.Clear();
            //PrintLineSlow("Sophie...");
            //Thread.Sleep(750);
            //Console.Clear();
            //PrintLineSlow("You must wake up...");
            //Thread.Sleep(750);
            //Console.Clear();
            //PrintLineSlow("You must get out...");
            //Thread.Sleep(750);
            //Console.Clear();
            //PrintLineSlow("You are our only hope to escape...");
            //Thread.Sleep(750);
            //Console.Clear();
            Location.cellar.SetNearbyLocations(east: Location.hall);
            Location.hall.SetNearbyLocations(east: Location.midNowhere1);
            Location.midNowhere1.SetNearbyLocations(north: Location.midNowhere2, east: Location.midMidNowhere, south: Location.midNowhere3);
            Location.midNowhere4.SetNearbyLocations(west: Location.midMidNowhere, north: Location.midNowhere5, south: Location.midNowhere6, east: Location.theHall);
            Location.midMidNowhere.SetNearbyLocations(north: Location.midNowhere7, south: Location.midNowhere8, west: Location.midNowhere1, east: Location.midNowhere4);
            Location.midNowhere7.SetNearbyLocations(west: Location.midNowhere2, east: Location.midNowhere5, south: Location.midMidNowhere);
            Location.midNowhere8.SetNearbyLocations(west: Location.midNowhere3, east: Location.midNowhere6);
            Location.theGrave.SetNearbyLocations(south: Location.midNowhere7);
            Location.theHall.SetNearbyLocations(west: Location.midNowhere4);

            Location.cellar.Resolve(new List<Player>() {Player.player});
        }
        public static void PrintLineSlow(string output)
        {
            if (output is null)
            {
                return;
            }
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        } 
        public static void PrintLine(string output)
        {
            if (output is null)
            {
                return;
            }
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
                Thread.Sleep(25);
            }
            Console.WriteLine();
        }
        public static void PrintLineFast(string output)
        {
            if (output is null)
            {
                return;
            }
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }
    }
}
