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
            setDuration(getDuration() - 1);
            
            if(getDuration() == 3)
            {
                getHero().setModStrength(getHero().getModStrength() + 6);
            }

            if (getDuration() > 0)
            {
                return (getHero().getName() + " strength has been boosted by 6 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModStrength(getHero().getModStrength() - 6);
                return (getHero().getName() + " strength boost has ended!\r\n");
            }
        }
    }
}
