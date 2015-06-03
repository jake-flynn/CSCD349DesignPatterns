using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PowerBoost : StatusEffect
    {
        public PowerBoost()
        {
            setDuration(4);
        }

        public override String Modify()
        {
            if(getDuration() == 4)
            {
                getHero().setModStrength(getHero().getModStrength() + 6);            
            }

            else if(getDuration() == 1)
            {
                getHero().setModStrength(getHero().getModStrength() - 6);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " power has been boosted by 6 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
