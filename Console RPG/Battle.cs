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
                    Console.WriteLine(item.name + "'s Turn:");
                    item.DoTurn(players, enemies);
                }
                //Loop through all enemies
                foreach (var item in enemies)
                {
                    Console.WriteLine(item.name + "'s Turn:");
                    item.DoTurn(players, enemies);
                }

                if (players.TrueForAll(player => player.currentSanity <= 0))
                {
                    Console.WriteLine("You died, womp womp :(");
                    break;
                }
                if (enemies.TrueForAll(enemy => enemy.currentSanity <= 0))
                {
                    Console.WriteLine("You won, YIPPEE :)");
                    break;
                }
            }
        }
    }
}
