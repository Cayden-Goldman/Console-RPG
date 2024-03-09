using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Battle : Event
    {
        public List<Enemy> enemies;
        public int goldObtained = 0;

        public Battle(List<Enemy> enemies) : base(false)
        {
            this.enemies = enemies;
        }

        public override void Resolve(List<Player> players)
        {

            Console.WriteLine($"You have entered a battle!");
            Console.WriteLine();
            while (true)
            {
                foreach (var item in players)
                {
                    Console.WriteLine($"{item.name}");
                    Console.WriteLine($"Sanity: {item.currentSanity} / {item.maxSanity}");
                    Console.WriteLine();
                    foreach (var enem in enemies)
                    {
                        Console.WriteLine($"{enem.name}");
                        Console.WriteLine($"Sanity: {enem.currentSanity} / {enem.maxSanity}");
                        Console.WriteLine();
                    }
                    if (item.currentSanity > 0)
                    {
                    Console.WriteLine(item.name + "'s Turn:");
                    item.DoTurn(players, enemies);
                    }
                }
                if (enemies.TrueForAll(enemy => enemy.currentSanity <= 0))
                {
                    goldObtained = 0;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won, YIPPEE :)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"You got");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    foreach (var item in enemies)
                    {
                        goldObtained += item.coinsDropped;
                        item.currentSanity = item.maxSanity;
                    }
                    Player.CoinCount += goldObtained;
                    Console.Write($" {goldObtained} Gold!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                EZ:
                foreach (var item in enemies)
                {
                    foreach (var pla in players)
                    {
                        Console.WriteLine($"{pla.name}");
                        Console.WriteLine($"Sanity: {pla.currentSanity} / {pla.maxSanity}");
                        Console.WriteLine();
                    }
                    Console.WriteLine($"{item.name}");
                    Console.WriteLine($"Sanity: {item.currentSanity} / {item.maxSanity}");
                    Console.WriteLine();
                    if (item.currentSanity > 0)
                    {
                    Console.WriteLine(item.name + "'s Turn:");
                    item.DoTurn(players, enemies);
                    }
                    else
                    {
                        enemies.RemoveAt(enemies.IndexOf(item));
                        goto EZ;
                    }
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (players.TrueForAll(player => player.currentSanity <= 0))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You died, womp womp :(");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
