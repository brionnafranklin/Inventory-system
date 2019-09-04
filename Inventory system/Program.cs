using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Program
    {
        public static Random random = new Random();
        static void Main(String[]args)
       {
            /*
            //0:cort
            //1: gate
            //2:grave
            //3: village
                                                       //N, S,  E, W

            Scene courtyard = new Scene("Courtyard",     1, 3, -1, 2, "The courtyard is wide and open to the sky. There is a small garden nearby. There are exits to the north, south, east, and west");
            Scene castleGate = new Scene("Castle Gate", -1, 0, -1, -1, "There is a massive gate at the entrance to the castle. It appears to be locked. There is an exit to the south.");
            Scene graveyard = new Scene("Graveyard",    -1, -1, 0, -1, "The graveyard is pretty spooky. Nontheless, you pay respects. There is an exit to the east");
            Scene village = new Scene("Village",         0, -1, -1, -1, "The village is a bunch of buildings. The exit is to North");

            Scene[] scenes = { courtyard, castleGate, graveyard, village };
            Map map = new Map(0, scenes);

            
            map.PrintCurrentScene();
            map.CurrentSceneID = 1;
            map.PrintCurrentScene();
            map.CurrentSceneID = 2;
            map.PrintCurrentScene();
            map.CurrentSceneID = 3;
            map.PrintCurrentScene();
            map.CurrentSceneID = 4;
            
            map.Menu();

            Console.ReadKey();
            */



               
            
            Monster Doge = new Monster("Doge", 75, 10, 500);
            Monster Ditto = new Monster("Ditto", 50, 5, 500);
            Monster AntiDoge = new Monster("Anti Doge", 40, 5, 250);
            Monster NotDitto = new Monster("Not Ditto", 25, 2, 250);
            Character Me = new Knight("Me");


            //Random random = new Random();

            Creature[] goodTeam = { Doge, Ditto, Me };
            Creature[] badTeam = { AntiDoge, NotDitto };

            Me.OpenInventory();

            Encounter encounter = new Encounter(goodTeam, badTeam);
            encounter.Print();
            encounter.Start();

            
            

            //if (random.Next(1, 2) == 1)
            //{
            //    Ditto.Print();
            //}
            //else if (random.Next(1, 2) == 2)
            //{
            //    Doge.Print();
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //    Console.ReadKey();
            //}

            //Doge.Fight(Ditto);
            //Ditto.Print();
            //Ditto.Fight(Doge);
            //Doge.Print();

            Console.ReadKey();
            return;
            

            //Inventory inventory = new Inventory();
            //inventory.Menu();
            string name = "";
            string choice = "";

            Console.WriteLine("Enter name of party member 1: ");
            name = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3")
            {
               
                //display menu
                Console.WriteLine("\nChoose a class:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Rogue");
                Console.WriteLine("3: Mage");
                choice = Console.ReadLine();
                
            }
            Character player;
            if (choice == "1")
            {
                player = new Knight(name);
            }
            else if (choice == "2")
            {
                player = new Rogue(name);
            }
            else if (choice == "3")
            {
                player = new Mage(name);
            }
            else
            {
                player = new Character(name);
            }
            player.Print();

            
            Character sarah = new Rogue("Sarah");
            Character josh = new Mage("Josh");
            sarah.Print();
            josh.Print();

            choice = "";
            while (choice != "0")
            {
               
                //display menu
                Console.WriteLine("\nWhose inventory?");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + sarah.Name());
                Console.WriteLine("3: " + josh.Name());
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine(player.Name());
                    player.OpenInventory();
                }
                else if (choice == "2")
                {
                    Console.WriteLine(sarah.Name());
                    player.OpenInventory();
                }
                else if (choice == "3")
                {
                    Console.WriteLine(josh.Name());
                    player.OpenInventory();
                }
            Console.WriteLine(player.GetDamage());

            Console.ReadKey();
            return;
            }
            player.Experience = 100;
            player.Experience = player.Experience + 200;
            player.Experience++;
            player.Experience += 600;
            player.Experience += 600;
            player.Experience += 600;
            player.Experience += 600;
            player.Experience += 600;
            player.Experience += 600;
            player.Experience += 600;
            player.Experience += 600;
            player.Experience += 600;


            int[] testArray = new int[4];

            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };
            string[] stringArray = new string[3];

            Character[] party = { player, sarah, josh, new Character("Jax") };
            Console.ReadKey();

       }
    }
}
