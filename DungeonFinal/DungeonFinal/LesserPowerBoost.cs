using System;
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
            if(getDuration() == 3)
            {
                getHero().setModStrength(getHero().getModStrength() + 3);             
            }

            else if(getDuration() == 1)
            {
                getHero().setModStrength(getHero().getModStrength() - 3);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " power has been boosted by 3 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
