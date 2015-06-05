﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserHealthRegeneration : StatusEffect
    {
        public LesserHealthRegeneration()
        {
            setDuration(3);
        }

        public override String Modify()
        {
            getHero().setCurHealth(getHero().getCurHealth() + 10);             
            setDuration(getDuration() - 1);

            if (getDuration() > 0)
            {
                return (getHero().getName() + " health is being regenerated by 10 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                return (getHero().getName() + " lesser health regeneration potion has ended!\r\n");
            }
        }
    }
}
