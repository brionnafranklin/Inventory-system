using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Creature
    {
        protected int _health = 10;
        protected int _maximumHealth = 10;
        protected int _damage = 5;
        public virtual int Health
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
        public virtual void Fight(Creature target)
        {

        }
        public virtual void Fight(Creature[] targets)
        {

        }
        public virtual int GetDamage()
        {
            return 0;
        }
        public virtual string GetName()
        {
            return "";
        }
        public virtual void Print()
        {
          
        }
    }
}
