using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserResistanceBoost : StatusEffect
    {
         public LesserResistanceBoost()
        {
            setDuration(3);
        }

        public override String Modify()
        {
            setDuration(getDuration() - 1);

            if(getDuration() == 2)
            {
                getHero().setModResistance(getHero().getModResistance() + 3);
            }
            
            if (getDuration() > 0)
            {
                return (getHero().getName() + " resistance has been boosted by 3 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModResistance(getHero().getModResistance() - 3);
                return (getHero().getName() + " lesser resistance boost has ended!\r\n");
            }
        }
    }
}
