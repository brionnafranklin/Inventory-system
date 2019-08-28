using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Encounter
    {
        private Monster[] _goodMonsters;
        private Monster[] _badMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }
        public void Print()
        {
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }
        public void BeginRound()
        {
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);
            }
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Fight(_goodMonsters);
            }
        }
        public void Start()
        {
            Console.WriteLine("\nEncounter Start!");
            bool stillFighting = true;
            while (stillFighting)
            {
                bool goodIsAlive = true;

                for (int i = 0; i < _goodMonsters.Length; i++)
                {
                    Monster currentMonster = _goodMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        goodIsAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        goodIsAlive = false;
                    }
                }
                bool badIsAlive = true;

                for (int i = 0; i < _badMonsters.Length; i++)
                {
                    Monster currentMonster = _badMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        badIsAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        badIsAlive = false;
                    }
                }

                if (goodIsAlive && badIsAlive)
                {
                    stillFighting = true;
                    BeginRound();
                }
                else
                {
                    stillFighting = false;
                }
                Print();
            }
        }

    }
}
