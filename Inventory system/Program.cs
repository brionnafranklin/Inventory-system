using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Program
    {
       static void Main(String[]args)
        {
            //Inventory inventory = new Inventory();
            //inventory.Menu();

            Character player = new Character("Bri");
            player.Print();

            Character sarah = new Character("Sarah");
            Character josh = new Character("Josh");
            sarah.Print();
            josh.Print();

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
