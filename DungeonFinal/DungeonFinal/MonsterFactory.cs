﻿using System;
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
       public MonsterFactory()
       {

       }
        
	public Monster createMonster(int level) {
		Monster newMonster = null;
        //var randomGeneratedNumber = 
		if (level == 1) //Level one monster
        {
            int rnd = new Random().Next(5);
            if(rnd == 1)
            {
                newMonster = new Shade();
            }

            else if(rnd == 2)
            {
                newMonster = new Skeleton();
            }

            else if (rnd == 3)
            {
                newMonster = new Insect();
            }

            else if (rnd == 4)
            {
                newMonster = new VampireBat();
            }

            else if (rnd == 5)
            {
                newMonster = new Slime();
            }

            else if (rnd == 6)
            {
                newMonster = new Imp();
            }
		}
        else if (level == 2) //Level two monster
        {
            int rnd = new Random().Next(5);
			if (rnd == 1)
            {
                newMonster = new StuBeast();
            }

            else if (rnd == 2)
            {
                newMonster = new Werewolf();
            }

            else if (rnd == 3)
            {
                newMonster = new Harpy();
            }

            else if (rnd == 4)
            {
                newMonster = new Hellhound();
            }

            else if (rnd == 5)
            {
                newMonster = new Cockatrice();
            }

            else if (rnd == 6)
            {
                newMonster = new Sphynx();
            }
		}
        else if (level == 3) //Level three monster
        {
            int rnd = new Random().Next(5);
            if (rnd == 1)
            {
                newMonster = new Centaur();
            }

            else if (rnd == 2)
            {
                newMonster = new DemonWarrior();
            }

            else if (rnd == 3)
            {
                newMonster = new Cyclops();
            }
		}
		return newMonster;
}

    }
}
