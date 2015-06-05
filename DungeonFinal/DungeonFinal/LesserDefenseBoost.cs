using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserDefenseBoost : StatusEffect
    {
         public LesserDefenseBoost()
        {
            setDuration(3);
        }

        public override String Modify()
        {
            setDuration(getDuration() - 1);

            if (getDuration() > 0)
            {
                return (getHero().getName() + " defense has been boosted by 3 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModDefense(getHero().getModDefense() - 3);
                return (getHero().getName() + " lesser defense boost has ended!\r\n");
            }
        }
    }
}
