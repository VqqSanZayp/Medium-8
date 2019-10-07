using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._4
{
    class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private Movement _movement;
        private Weapon _weapon;

        public Player(string name, int age, Movement movement, Weapon weapon)
        {
            Name = name;
            Age = age;

            _movement = movement;
            _weapon = weapon;
        }

        public void Move() => _movement.Run();
        public void Attack()
        {
            if (_weapon.IsReloading())
            {
                _weapon.Attack();
            }
        }
    }

    class Weapon
    {
        public int Damage { get; private set; }
        public float Cooldown { get; private set; }

        public void Attack()
        {
            //attack
        }

        public bool IsReloading()
        {
            throw new NotImplementedException();
        }
    }

    class Movement
    {
        public float DirectionX { get; private set; }
        public float DirectionY { get; private set; }
        public float Speed { get; private set; }

        public void Run()
        {
            //Do move
        }
    }
}