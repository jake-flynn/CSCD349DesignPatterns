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
    class ManaRegeneration : StatusEffect
    {
        public ManaRegeneration()
        {
            setDuration(4);
        }

        public override String Modify()
        {
            getHero().setCurMana(getHero().getCurMana() + 15);             
            setDuration(getDuration() - 1);

            return (getHero().getName() + " mana is being regenerated by 15 for " + getDuration() + " more turn(s)!");
        }
    }
}
