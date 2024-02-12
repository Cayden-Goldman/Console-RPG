using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player derek = new Player("Derek", 1, 1, new Stats(1, 1, 1, 1));
            Enemy richDerek = new Enemy("Rich Derek", 1, 1, new Stats(1, 1, 1, 1), 10000);
            Console.WriteLine("Derek does " + derek.stats.attack + " damage.");
            Console.WriteLine("Rich Derek died and dropped " + richDerek.coinsDropped + " coins!");
        }
    }
}
