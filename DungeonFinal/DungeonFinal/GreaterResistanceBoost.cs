using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class GreaterResistanceBoost : StatusEffect
    {
         public GreaterResistanceBoost()
        {
            setDuration(5);
        }

        public override String Modify()
        {
            if(getDuration() == 5)
            {
                getHero().setModResistance(getHero().getModResistance() + 10);            
            }

            else if(getDuration() == 1)
            {
                getHero().setModResistance(getHero().getModResistance() - 10);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " resistance has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
