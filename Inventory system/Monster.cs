﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Monster
    {
        private string _name = "";
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
            Console.WriteLine("Health: " + _health + "/" + _maximumHealth);
            Console.WriteLine("Damage: " + _damage);
            //Console.ReadKey();
        }

        public void Fight(Monster target)
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

        public void Fight(Monster[]targets)
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
                    Monster current = targets[i];
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
