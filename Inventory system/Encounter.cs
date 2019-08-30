using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_system
{
    class Encounter
    {
        private Creature[] _goodMonsters;
        private Creature[] _badMonsters;

        public Encounter(Creature[] team1, Creature[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }
        public void Print()
        {
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }
        public void BeginRound()
        {
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);
            }
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
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
                    Creature currentMonster = _goodMonsters[i];
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
                    Creature currentMonster = _badMonsters[i];
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
