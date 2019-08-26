using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Knight : Character
    {
        public Knight(string name) : base(name)
        {
            _health = 300;
            _mana = 50;
            _strength = 18;
            _dexterity = 8;
            _wisdom = 10;
        }
    }
}
