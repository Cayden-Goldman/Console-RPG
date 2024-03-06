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
            //Loop the turn system
            while (true)
            {
                //Loop through all players(only one here but still)
                foreach (var item in players)
                {
                    if (item.currentSanity > 0)
                    {
                    Console.WriteLine(item.name + "'s Turn:");
                    item.DoTurn(players, enemies);
                    }
                }
                if (enemies.TrueForAll(enemy => enemy.currentSanity <= 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won, YIPPEE :)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"You got");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    foreach (var item in enemies)
                    {
                        goldObtained += item.coinsDropped;
                    }
                    if (Player.weapon == Weapon.gamblingSword)
                    {
                        goldObtained *= 2;
                    }
                    Player.CoinCount += goldObtained;
                    Console.Write($" {goldObtained} Gold!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                //Loop through all enemies
                foreach (var item in enemies)
                {
                    if (item.currentSanity > 0)
                    {
                    Console.WriteLine(item.name + "'s Turn:");
                    item.DoTurn(players, enemies);
                    }
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
