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
using System.Windows.Shapes;

namespace DungeonFinal
{
    class Taunt : StatusEffect
    {
        public Taunt(Hero h)
        {
            setHero(h);
            setDuration(3);
        }

        public override String Modify()
        {
            if(getDuration() > 1)
            {
                setDuration(getDuration() - 1);
                return (getHero().getName() + " is currently taunting the enemy monsters. This will last " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                setDuration(getDuration() - 1);             
                getHero().setIsTaunting(false);
                return (getHero().getName() + " taunt has ended!\r\n");
            }
        }
    }
}
