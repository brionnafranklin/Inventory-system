﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Inventory
    {
        private int _itemDamage = 10;
        private float _gold = 0.00f;
        private float _minGold = 0.00f;
        private int _weightWeapon = 0;
        private int _weightArmor = 0;
        private int _weightPotion = 0;
        private int _weightTotal = 0;
        private int _maxWeight = 50;
        private int _itemDefence = 0;
        private int _potion = 0;
        

        private AttackItem dagger = new AttackItem("Dagger", 15, 5);
        private AttackItem sword = new AttackItem("Sword", 20, 10);
        private AttackItem bow = new AttackItem("Bow", 25, 15);
        private AttackItem Warhammer = new AttackItem("Warhammer", 30, 20);
        private AttackItem bigThickBoi = new AttackItem("Big Thick Boi", 200, 100);
        private AttackItem[] weaponList = new AttackItem[10];
        
        public Inventory()
        {
            weaponList[0] = dagger;
            weaponList[1] = sword;
            weaponList[2] = bow;
            weaponList[3] = Warhammer;
            weaponList[4] = bigThickBoi;
        }

        public int GetItemDamage()
        {
            return _itemDamage;
        }

        public int GetItemDefence()
        {
            return _itemDefence;
        }
        public void test()
        {
            int playerHealth = 100;
            Console.WriteLine(playerHealth);
        }
        public void Menu()
        {
            string choice = "";


            while (choice != "0")
            {
                //Display
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Add Gold");
                Console.WriteLine("4: Subtract Gold");
                Console.WriteLine("5: Equip Armor");
                Console.WriteLine("6: Unequip Armor");
                Console.WriteLine("7: Buy potion");
                Console.WriteLine("8: Drink potion");

                //get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //check input
                if (choice == "1")
                {
                    EquipWeapon();
                }
                else if (choice == "2")
                {
                    UnequipWeapon();

                }
                else if (choice == "3")
                {
                    Console.Write("How much gold? ");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "4")
                {
                    Console.Write("How much gold? ");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    SubtractGold(subtractedGold);
                }
                else if (choice == "5")
                {
                    EquipArmor();
                }
                else if (choice == "6")
                {
                    UnequipArmor();
                }
                else if (choice == "7")
                {
                    Console.Write("How many? ");
                    int boughtPotion = Convert.ToInt32(Console.ReadLine());
                    buyPotion(boughtPotion);
                }
                else if (choice == "8")
                {
                    Console.Write("How many? ");
                    int drankPotion = Convert.ToInt32(Console.ReadLine());
                    drinkPotion(drankPotion);
                }
            }
        }
        public void EquipWeapon()
        {
            string choice = "";
            //choice weapon
            Console.WriteLine("Equip a weapon! (1: Dagger / 2: Sword / 3: Bow / 4: Warhammer /5: Big Thick Boi) press 0 to cancel.");
            choice = Console.ReadLine();
            Console.WriteLine("");

            //check input
            /*
            if (choice == "0")
            {
                Console.WriteLine("Action canceled");
            }
            else if (choice == "1")
            {
                if (_weightArmor + _weightPotion + 5 <= _maxWeight)
                {
                    _itemDamage = 15;
                    Console.WriteLine(" You've equided a dagger");
                    Console.WriteLine("Damage: " + _itemDamage);
                    _weightWeapon += 5;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "2")
            {
                if (_weightArmor + _weightPotion + 10 <= _maxWeight)
                {
                    _itemDamage = 20;
                    Console.WriteLine(" You've equided a sword");
                    Console.WriteLine("Damage: " + _itemDamage);
                    _weightWeapon += 10;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "3")
            {
                if (_weightArmor + _weightPotion + 15 <= _maxWeight)
                {
                    _itemDamage = 25;
                    Console.WriteLine(" You've equided a bow");
                    Console.WriteLine("Damage: " + _itemDamage);
                    _weightWeapon += 15;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "4")
            {
                if (_weightArmor + _weightPotion + 20 <= _maxWeight)
                {
                    _itemDamage = 30;
                    Console.WriteLine(" You've equided a warhammer");
                    Console.WriteLine("Damage: " + _itemDamage);
                    _weightWeapon += 20;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "5")
            {
                if (_weightArmor + _weightPotion + 100 <= _maxWeight)
                {
                    _itemDamage = 200;
                    Console.WriteLine(" You've equided a big thick Boi");
                    Console.WriteLine("Damage: " + _itemDamage);
                    _weightWeapon += 100;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else
            {
                EquipWeapon();
            }
        }
        */
        }
        public void UnequipWeapon()
        {
            if (_itemDamage == 10)
            {
                Console.WriteLine("No weapon to unequiped.");
                Console.WriteLine("Damage: " + _itemDamage);
            }
            else
            {
                Console.WriteLine("Unequiped a weapon!");
                _itemDamage = 10;
                Console.WriteLine("Damage: " + _itemDamage);
            }
        }

        //money
        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);
        }
        public void SubtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            _gold -= amount;
            if (_gold <= 0)
            {
                _gold = _minGold;
            }
            Console.WriteLine("Gold: " + _gold);

        }
        public void EquipArmor()
        {
            string choice = "";
            //choice armor
            Console.WriteLine("Equip armor! (1: Leather / 2: Elven / 3: Dragon Scale / 4: Dragon Bone /5: The Souls of the Innocent) press 0 to cancel.");
            choice = Console.ReadLine();
            Console.WriteLine("");

            //check input
            if (choice == "0")
            {
                Console.WriteLine("Action canceled");
            }
            else if (choice == "1")
            {
                if (_weightWeapon + _weightPotion + 5 <= _maxWeight)
                {
                    _itemDefence = 15;
                    Console.WriteLine(" You've equided leather armor");
                    Console.WriteLine("Defence: " + _itemDefence);
                    _weightArmor += 5;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "2")
            {
                if (_weightWeapon + _weightPotion + 10 <= _maxWeight)
                {
                    _itemDefence = 20;
                    Console.WriteLine(" You've equided elven armor");
                    Console.WriteLine("Defence: " + _itemDefence);
                    _weightArmor += 10;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "3")
            {
                if (_weightWeapon + _weightPotion + 15 <= _maxWeight)
                {
                    _itemDefence = 25;
                    Console.WriteLine(" You've equided dragon scale armor");
                    Console.WriteLine("Defence: " + _itemDefence);
                    _weightArmor += 15;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "4")
            {
                if (_weightWeapon + _weightPotion + 20 <= _maxWeight)
                {
                    _itemDefence = 30;
                    Console.WriteLine(" You've equided dragon bone armor");
                    Console.WriteLine("defence: " + _itemDefence);
                    _weightArmor += 20;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "5")
            {
                if (_weightWeapon + _weightPotion + 100 <= _maxWeight)
                {
                    _itemDefence = 200;
                    Console.WriteLine(" You've equided the souls of the innocent");
                    Console.WriteLine("defence: " + _itemDefence);
                    _weightArmor += 100;
                    _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                    Console.WriteLine("Weight: " + _weightTotal);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else
            {
                EquipWeapon();
            }
        }
        public void UnequipArmor()
        {
            if (_itemDefence == 0)
            {
                Console.WriteLine("No armor to unequiped.");
                Console.WriteLine("Defence: " + _itemDefence);
            }
            else
            {
                Console.WriteLine("Unequiped armor!");
                _itemDefence = 0;
                Console.WriteLine("Defence: " + _itemDefence);
            }
        }
        public void buyPotion(int boughtPotion)
        {
            if (_gold >= boughtPotion * 100)
            {
                Console.WriteLine("You bought " + boughtPotion + " potion(s)!");
                _potion += boughtPotion;
                _weightPotion += boughtPotion;
                Console.WriteLine("Potions: " + _potion);
                _gold -= boughtPotion * 100;
                Console.WriteLine("Gold: " + _gold);
                _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                Console.WriteLine("Weight: " + _weightTotal);
            }
            else
            {
                Console.WriteLine("Not enough gold!");
                _itemDefence = 0;
                Console.WriteLine("Potions: " + _potion);
                Console.WriteLine("Gold: " + _gold);
            }
        }
        public void drinkPotion(int drankPotion)
        {
            if (_potion >= drankPotion)
            {
                Console.WriteLine("You drank " + drankPotion + " potion(s)!");
                _potion -= drankPotion;
                _weightPotion -= drankPotion;
                _maxWeight += drankPotion * 5;
                Console.WriteLine("Potions: " + _potion);
                _weightTotal = _weightWeapon + _weightArmor + _weightPotion;
                Console.WriteLine("Weight: " + _weightTotal);
                Console.WriteLine("Max weight: " + _maxWeight);
            }
            else
            {
                Console.WriteLine("Not enough potions!");
            }
        }
    }
}
