using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Monster
    {

        private string _name;
        private int health;

        public Monster(int i)
        {
            if (i == 1)
            {
                _name = "Level 1 Monster";
            }
            else if (i == 2)
            {
                _name = "Level 2 Monster";
            }
            else if (i == 3)
            {
                _name = "Level 3 Monster";
            }
            else if(i == 4)
            {
                _name = "Boss Monster";
            }

            health = 100;
        }

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
