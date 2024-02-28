using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Battle
    {
        public List<Enemy> enemies;
        public bool isResolved;

        public Battle(List<Enemy> enemies)
        {
            this.enemies = enemies;
            this.isResolved = false;
        }

        public void Resolve(List<Player> players)
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
                    break;
                }
            }
        }
    }
}
