using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class DefenceItem : Item
    {
        private int _defence;
        public int defense
        {
            get
            {
                return _defence;
            }
        }


        public DefenceItem(string newName, int newDefence, int newWeight)
        {
            Name = newName;
            _defence = newDefence;
            weight = newWeight;
        }
    }
}
