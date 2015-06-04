﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserPowerBoost : StatusEffect
    {
         public LesserPowerBoost()
        {
            setDuration(3);
        }

        public override String Modify()
        {
            setDuration(getDuration() - 1);
            getHero().setModStrength(getHero().getModStrength() + 3);

            if (getDuration() > 1)
            {
                return (getHero().getName() + " strength has been boosted by 3 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModDefense(getHero().getModDefense() - 3);
                return (getHero().getName() + " lesser strength boost has ended!\r\n");
            }
        }
    }
}
