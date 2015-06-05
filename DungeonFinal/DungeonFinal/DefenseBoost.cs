using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class DefenseBoost : StatusEffect
    {
         public DefenseBoost()
        {
            setDuration(4);
        }

        public override String Modify()
        {
            setDuration(getDuration() - 1);
            
            if (getDuration() == 3)
            {
                getHero().setModDefense(getHero().getModDefense() + 6);
            }

            if(getDuration() > 0)
            {
                  return (getHero().getName() + " defense has been boosted by 6 for " + getDuration() + " more turn(s)!\r\n");          
            }

            else
            {
                getHero().setModDefense(getHero().getModDefense() - 6);
                return(getHero().getName() + " defense boost has ended!\r\n");
            }
        }
    }
}
