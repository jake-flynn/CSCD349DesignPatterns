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
            if(getDuration() == 3)
            {
                getHero().setModResistance(getHero().getModResistance() + 3);            
            }

            else if(getDuration() == 1)
            {
                getHero().setModResistance(getHero().getModResistance() - 3);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " resistance has been boosted by 3 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
