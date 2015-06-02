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
    class HealthRegeneration : StatusEffect
    {
        public HealthRegeneration(Hero h)
        {
            setHero(h);
            setDuration(5);
        }

        public override String Modify()
        {
            getHero().setCurHealth(getHero().getCurHealth() + 15);             
            setDuration(getDuration() - 1);

            return (getHero().getName() + " health is being regenerated for " + getDuration() + " more turn(s)!");
        }
    }
}
