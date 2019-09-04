using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Character : Creature
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 };

        private Inventory inventory = new Inventory();

        
        protected int _mana = 100;
        protected int _strength = 10;
        protected int _dexterity = 10;
        protected int _wisdom = 10;
        protected int _damge = 10;

        public Character(string name)
        {
            _name = name;
            _health = 100;
            _maximumHealth = 100;
        }

        public string Name()
        {
            return _name;
        }
        public override void Print()
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
        public override int GetDamage()
        {
            return (_strength + inventory.GetItemDamage());
        }
        public override int GetDefence()
        {
            return (inventory.GetItemDefence());
        }
        public override string GetName()
        {
            return _name;
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
        public override void Fight(Creature target)
        {
            if (Health <= 0)
            {
                return;
            }
            //get this mon's damage
            int damage = GetDamage();
            //subtract damage
            target.Health -= damage;
            Console.WriteLine(GetName() + "attack! " + target.GetName() + " takes " + damage);

        }
        public override void Fight(Creature[]targets)
        {
            if (Health <= 0)
            {
                return;
            }
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("\nWho will" + GetName() + " fight? ");
                //Print menu
                
                
                //Iterate through targets
                for (int i = 0; i < targets.Length; i++)
                {
                    Creature current = targets[i];
                    Console.WriteLine((i + 1) + "i " + targets[i].GetName());
                    //Print each option with a number
                    
                }

                string input = Console.ReadLine();

                int choice = Convert.ToInt32(input);
                if (choice >= 0 && choice < targets.Length + 1)
                {
                    validInput = true;
                    Fight(targets[choice - 1]);
                    
                }
            }
        }
    }
}
