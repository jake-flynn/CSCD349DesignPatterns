using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class GreaterPowerBoost : StatusEffect
    {
        public GreaterPowerBoost()
        {
            setDuration(5);
        }

        public override String Modify()
        {
            if(getDuration() == 5)
            {
                getHero().setModStrength(getHero().getModStrength() + 10);             
            }

            else if(getDuration() == 1)
            {
                getHero().setModStrength(getHero().getModStrength() - 10);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " power has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
