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
            setDuration(getDuration() - 1);
              

            if(getDuration() == 4)
            {
                getHero().setModResistance(getHero().getModResistance() + 10);
            }

            if(getDuration() > 0)
            {
                 return (getHero().getName() + " resistance has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");    
            }

            else
            {
                getHero().setModResistance(getHero().getModResistance() - 10);
                return (getHero().getName() + " greater resistance defense boost has ended!\r\n");
            }      
        }
    }
}
