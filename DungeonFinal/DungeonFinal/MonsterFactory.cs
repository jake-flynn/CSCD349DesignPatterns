using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DungeonFinal
{
    public class MonsterFactory
    {
        Random _randomNumber;
 
       public MonsterFactory()
       {
           _randomNumber = RandomGenerator.Instance;
       }
        
	public Monster createMonster(int level) {
		Monster newMonster = null;
        
		if (level == 1) //Level one monster
        {
            var randomGeneratedNumber1 = _randomNumber;
            int rnd1 = randomGeneratedNumber1.Next(6)+1;
       
            

            if(rnd1 == 1)
            {
                return new Shade();
            }

            else if(rnd1 == 2)
            {
                return new Skeleton();
            }

            else if (rnd1 == 3)
            {
                return new Insect();
            }

            else if (rnd1 == 4)
            {
                return new VampireBat();
            }

            else if (rnd1 == 5)
            {
                return new Slime();
            }

            else if (rnd1 == 6)
            {
                return new Imp();
            }
		}
        else if (level == 2) //Level two monster
        {
            var randomGeneratedNumber = _randomNumber;
            int rnd = randomGeneratedNumber.Next(6) + 1;
           
			if (rnd == 1)
            {
                return new StuBeast();
            }

            else if (rnd == 2)
            {
                return new Werewolf();
            }

            else if (rnd == 3)
            {
                return new Harpy();
            }

            else if (rnd == 4)
            {
                return new Hellhound();
            }

            else if (rnd == 5)
            {
                return new Cockatrice();
            }

            else if (rnd == 6)
            {
                return new Sphynx();
            }
		}
        else if (level == 3) //Level three monster
        {
            var randomGeneratedNumber = _randomNumber;
            int rnd = randomGeneratedNumber.Next(3) + 1;

            if (rnd == 1)
            {
                return new Centaur();
            }

            else if (rnd == 2)
            {
                return new DemonWarrior();
            }

            else if (rnd == 3)
            {
                return new Cyclops();
            }
		}
        else if (level == 4) //Level three monster
        {
            var randomGeneratedNumber = _randomNumber;
            int rnd = randomGeneratedNumber.Next(4) + 1;
            if (rnd == 1)
            {
                return new Minotaur();
            }

            else if (rnd == 2)
            {
                return new Hydra();
            }

            else if (rnd == 3)
            {
                return new Dragon();
            }
            else if (rnd == 4)
            {
                return new Chimera();
            }
        }
		return newMonster;
}

    }
}
