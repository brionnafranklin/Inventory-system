using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventory_system
{
    class Map
    {
        private int _currentLocation = 0;
        private Scene[] _sceneList;

        public Map(int startingSceneID, Scene[] scenes)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
        }
        public void PrintCurrentScene()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
            }
            else
            {
                Console.WriteLine("\nInvalid scene ID");
            }
        }
        public int CurrentSceneID
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                if (value >= 0 && value < _sceneList.Length)
                {
                    _currentLocation = value;
                }
                else
                {
                    Console.WriteLine("\nInvalid scene ID");
                }
            }

        }
        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                PrintCurrentScene();
                Console.WriteLine("\nMenu:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Travel");
                Console.WriteLine("2: Save");
                Console.WriteLine("3: Load");
                Console.WriteLine("4: Search");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Travel();
                }
                else if (choice == "2")
                {
                    save("save.txt");
                }
                else if (choice == "3")
                {
                    load("save.txt");
                }
                else if (choice == "4")
                {
                    Search();
                }
            }
        }
        public void Travel()
        {
            int destination = 1;

            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                destination = _sceneList[_currentLocation].chooseExit();
            }
            if (_currentLocation >= 0 && destination < _sceneList.Length)
            {
                CurrentSceneID = destination;
            }
            else
            {
                Console.WriteLine("There is nothing in that direction.");
            }
        }

        public void Search()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }
        }
        public void save(string path)
        {
            StreamWriter writer = File.CreateText(path);
            writer.WriteLine(CurrentSceneID);
            writer.Close();
        }
        public void load(string path)
        {
            if (File.Exists(path))
            {
                StreamReader reader = File.OpenText(path);
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                reader.Close();
            }
            else
            {
                Console.WriteLine("Save file not found.");
            }
        }


    }
}

