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

        private int GetTotalExpDrop(Creature[] team)
        {
            int exp = 0;
            for (int i = 0; i < team.Length; i++)
            {
                exp += team[i].GetExpDrop();

            }
            return exp;
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
                    if (goodIsAlive)
                    {
                        foreach (Creature cr in _goodMonsters)
                        {

                            if (cr is Character)
                            {
                                Character ch = (Character)cr;
                                ch.Experience += GetTotalExpDrop(_badMonsters);
                            }
                        }
                    }
                    else if (badIsAlive)
                    {
                        foreach (Creature cr in _badMonsters)
                        {

                            if (cr is Character)
                            {
                                Character ch = (Character)cr;
                                ch.Experience += GetTotalExpDrop(_goodMonsters);
                            }
                        }
                    }
                }
                Print();
            }
        }

    }
}
