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
            setDuration(getDuration() - 1);
            getHero().setModResistance(getHero().getModResistance() + 6);

            if (getDuration() > 1)
            {
                return (getHero().getName() + " resistance has been boosted by 6 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModResistance(getHero().getModResistance() - 6);
                return (getHero().getName() + " resistance boost has ended!\r\n");
            }
        }
    }
}
