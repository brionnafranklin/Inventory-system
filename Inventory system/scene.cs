using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private string _hidden;

        public Scene(string name, int northID, int southID, int easttID, int westID, string description)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = easttID;
            _west = westID;
            _hidden = "Nothing was found";
        }

        public Scene(string name, int northID, int southID, int easttID, int westID, string description, string hidden)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = easttID;
            _west = westID;
            _hidden = hidden;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public int chooseExit()
        {
            Console.WriteLine("choose direction (N,S,W,E)");
            string choice = "";
            while (choice != "N" && choice != "S" && choice != "E" && choice != "W")
            {


                choice = choice.ToUpper();
                choice = Console.ReadLine();
            }
            if (choice == "N")
            {
                return _north;
            }
            if (choice == "S")
            {
                return _south;
            }
            if (choice == "E")
            {
                return _east;
            }
            if (choice == "W")
            {
                return _west;
            }
            else
            {
                return -1;
            }
        }


        public string GetHidden()
        {
            return _hidden;
        }
    }
}
