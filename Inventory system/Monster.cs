using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Monster : Creature
    {
        private string _name = "";

        

        public Monster(string name, int health, int damage, int expDrop)
        {
            _name = name;
            _health = health;
            _maximumHealth = health;
            _damage = damage;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            return _damage;
        }

        public override int Health
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
        public override void Print()
        {
            Console.WriteLine("Monster Type: " + _name);
            Console.WriteLine("Health: " + _health + "/" + _maximumHealth);
            Console.WriteLine("Damage: " + _damage);
            //Console.ReadKey();
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
            target.Health -= damage - target.GetDefence();
            Console.WriteLine(GetName() + "attack! " + target.GetName() + " takes " + damage);

        }

        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                
                return;
            }


            int choice = Program.random.Next(0, targets.Length);
            Fight(targets[choice]);
            /*
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
                */
        }
    }

}   


