using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Hero
    {
        private string _name;
        private int health;

        public Hero(int i)
        {
            if (i == 1)
            {
                _name = "Swordsman";
            }
            else if (i == 2)
            {
                _name = "Paladin";
            }
            else if (i == 3)
            {
                _name = "Priest";
            }
            else if(i == 4)
            {
                _name = "Rogue";
            }

            health = 100;
        }

    /*---------------------------------------------------------------------------------------*/
        public string getName()
        {
            return this._name;
        }

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int newHealth)
        {
            health = newHealth;
        }

        public string toString()
        {
            return this._name;
        }


    }
}
