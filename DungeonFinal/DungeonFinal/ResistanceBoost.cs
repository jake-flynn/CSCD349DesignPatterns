using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class ResistanceBoost : StatusEffect
    {
         public ResistanceBoost()
        {
            setDuration(4);
        }

        public override String Modify()
        {
            if(getDuration() == 4)
            {
                getHero().setModResistance(getHero().getModResistance() + 6);            
            }

            else if(getDuration() == 1)
            {
                getHero().setModResistance(getHero().getModResistance() - 6);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " resistance has been boosted by 6 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
