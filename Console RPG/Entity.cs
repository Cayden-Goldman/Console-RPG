using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Entity
    {
        public string name;

        public int currentSanity, maxSanity;
        public int currentEnergy, maxEnergy;

        //Composition
        public Stats stats;


        public Entity(string name, int sanity, int energy, Stats stats)
        {
            this.name = name;
            this.currentSanity = sanity;
            this.maxSanity = sanity;
            this.currentEnergy = energy;
            this.maxEnergy = energy;
            this.stats = stats;
        }

        public abstract void Attack(Entity target);
    }
}
