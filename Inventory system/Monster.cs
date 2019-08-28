using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Monster
    {
        private string _name = "Monster";
        private int _health = 50;
        private int _damage = 5;
        private int _maximumHealth = 50;

        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _maximumHealth = health;
            _damage = damage;
        }

        public string GetName()
        {
            return _name;
        }
        
        public int GetDamage()
        {
            return _damage;
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health < 0)
                {
                    _health = 0;
                }
                else if (_health > _maximumHealth)
                {
                    _health = _maximumHealth;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("Monster Type: " + _name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }
    }

}
