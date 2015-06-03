using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class GreaterDefenseBoost : StatusEffect
    {
         public GreaterDefenseBoost()
        {
            setDuration(5);
        }

        public override String Modify()
        {
            if(getDuration() == 5)
            {
                getHero().setModDefense(getHero().getModDefense() + 10);            
            }

            else if(getDuration() == 1)
            {
                getHero().setModDefense(getHero().getModDefense() - 10);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " defense has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
