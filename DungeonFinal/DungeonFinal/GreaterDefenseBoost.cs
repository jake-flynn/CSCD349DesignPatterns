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
            setDuration(getDuration() - 1);
            getHero().setModDefense(getHero().getModDefense() + 10);

            if(getDuration() > 1)
            {
                return (getHero().getName() + " defense has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");            
            }

            else
            {
                getHero().setModDefense(getHero().getModDefense() - 10);
                return (getHero().getName() + " greater defense boost has ended!\r\n");
            }
        }
    }
}
