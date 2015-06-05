using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class GreaterMagicBoost : StatusEffect
    {
         public GreaterMagicBoost()
        {
            setDuration(5);
        }

        public override String Modify()
        {
            setDuration(getDuration() - 1);
            getHero().setModMagic(getHero().getModMagic() + 10); 

            if(getDuration() > 0)
            {
                   return (getHero().getName() + " magic has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");            
            }

            else
            {
                getHero().setModMagic(getHero().getModMagic() - 10);
                return (getHero().getName() + " greater magic boost has ended!\r\n");
            }
        }
    }
}
