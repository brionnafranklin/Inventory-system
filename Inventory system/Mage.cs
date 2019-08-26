using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Mage : Character
    {
        public Mage(string name) : base(name)
        {
            _health = 100;
            _mana = 300;
            _strength = 10;
            _dexterity = 10;
            _wisdom = 20;
        }
    }
}
