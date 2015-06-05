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
            setDuration(getDuration() - 1);
            getHero().setModStrength(getHero().getModStrength() + 10); 

            if(getDuration() > 0)
            {
                 return (getHero().getName() + " strength has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModStrength(getHero().getModStrength() - 10);
                return (getHero().getName() + " greater strength boost has ended has ended!\r\n");
            }
            

        }
    }
}
