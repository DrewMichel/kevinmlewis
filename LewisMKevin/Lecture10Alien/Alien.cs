using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Alien
{
    class Alien
    {
        public const int MAX_HEALTH = 100;
        public int damage;
        public int health; //0 = dead, 100 = full

        public Alien(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }

        public virtual int GetDamage()
        {
            return damage;
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
    }
}
