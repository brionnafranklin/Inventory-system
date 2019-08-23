using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Inventory
    {
        int damage = 10;
        float gold = 0.00f;
        float minGold = 0.00f;
        int weight = 0;
        int maxWeight = 25;
        int defence = 0;
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
            if (choice == "0")
            {
                Console.WriteLine("Action canceled");
            }
            else if (choice == "1")
            {
                if (weight + 5 <= maxWeight)
                {
                    damage = 15;
                    Console.WriteLine(" You've equided a dagger");
                    Console.WriteLine("Damage: " + damage);
                    weight += 5;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "2")
            {
                if (weight + 10 <= maxWeight)
                {
                    damage = 20;
                    Console.WriteLine(" You've equided a sword");
                    Console.WriteLine("Damage: " + damage);
                    weight += 10;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "3")
            {
                if (weight + 15 <= maxWeight)
                {
                    damage = 25;
                    Console.WriteLine(" You've equided a bow");
                    Console.WriteLine("Damage: " + damage);
                    weight += 15;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "4")
            {
                if (weight + 20 <= maxWeight)
                {
                    damage = 30;
                    Console.WriteLine(" You've equided a warhammer");
                    Console.WriteLine("Damage: " + damage);
                    weight += 20;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "5")
            {
                if (weight + 100 <= maxWeight)
                {
                    damage = 200;
                    Console.WriteLine(" You've equided a big thick Boi");
                    Console.WriteLine("Damage: " + damage);
                    weight += 100;
                    Console.WriteLine("Weight: " + weight);
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
        public void UnequipWeapon()
        {
            if (damage == 10)
            {
                Console.WriteLine("No weapon to unequiped.");
                Console.WriteLine("Damage: " + damage);
            }
            else
            {
                Console.WriteLine("Unequiped a weapon!");
                damage = 10;
                Console.WriteLine("Damage: " + damage);
            }
        }

        //money
        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            Console.WriteLine("Gold: " + gold);
        }
        public void SubtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            gold -= amount;
            if (gold <= 0)
            {
                gold = minGold;
            }
            Console.WriteLine("Gold: " + gold);

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
                if (weight + 5 <= maxWeight)
                {
                    defence = 15;
                    Console.WriteLine(" You've equided leather armor");
                    Console.WriteLine("Defence: " + defence);
                    weight += 5;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "2")
            {
                if (weight + 10 <= maxWeight)
                {
                    defence = 20;
                    Console.WriteLine(" You've equided elven armor");
                    Console.WriteLine("Defence: " + defence);
                    weight += 10;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "3")
            {
                if (weight + 15 <= maxWeight)
                {
                    defence = 25;
                    Console.WriteLine(" You've equided dragon scale armor");
                    Console.WriteLine("Defence: " + defence);
                    weight += 15;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "4")
            {
                if (weight + 20 <= maxWeight)
                {
                    defence = 30;
                    Console.WriteLine(" You've equided dragon bone armor");
                    Console.WriteLine("defence: " + defence);
                    weight += 20;
                    Console.WriteLine("Weight: " + weight);
                }
                else
                {
                    Console.WriteLine("Item is too heavy. Cannot equip.");
                }
            }
            else if (choice == "5")
            {
                if (weight + 100 <= maxWeight)
                {
                    defence = 200;
                    Console.WriteLine(" You've equided the souls of the innocent");
                    Console.WriteLine("defence: " + defence);
                    weight += 100;
                    Console.WriteLine("Weight: " + weight);
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
    }
}
