using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Character
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 };

        private Inventory inventory = new Inventory();

        protected int _health = 100;
        protected int _mana = 100;
        protected int _strength = 10;
        protected int _dexterity = 10;
        protected int _wisdom = 10;

        public Character(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }
        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("Experience: " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("strength: " + _strength);
            Console.WriteLine("Dexerity: " + _dexterity);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine("Combat Damage: " + (_strength + inventory.GetItemDamage()));
            Console.WriteLine("");

        }
        public void OpenInventory()
        {
            inventory.Menu();
        }

        public int Experience
        {
            get
            {
                return _xp;
            }
            set
            {
                _xp = value;
                Console.WriteLine(_name + " gained experience and now has " + _xp);
                if (_level <= _requiredXP.Length)
                {
                    if (_xp >= _requiredXP[_level - 1])
                    {
                        _level++;
                        Console.WriteLine(_name + "'s level increased to " + _level + "!");
                    }
                }
            }
        }
    }
}
