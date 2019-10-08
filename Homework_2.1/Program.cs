using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._1
{
    class Unit
    {
        public int Health { get; private set; }

        public void TakeDamage(int damage)
        {
            Health -= TypeOfDamage(damage);
            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }

        public virtual int TypeOfDamage(int damage) => damage;
    }

    class Wombat : Unit
    {
        public int Armor { get; private set; }

        public override int TypeOfDamage(int damage) => damage - Armor;
    }

    class Human : Unit
    {
        public int Agility { get; private set; }

        public override int TypeOfDamage(int damage) => damage / Agility;
    }
}
