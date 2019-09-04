using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Rogue : Character
    {
        public Rogue(string name) : base(name)
        {
            _health = 250;
            _maximumHealth =250;
            _mana = 50;
            _strength = 12;
            _dexterity = 20;
            _wisdom = 15;
            _expDrop = 1000;
        }
    }
}
