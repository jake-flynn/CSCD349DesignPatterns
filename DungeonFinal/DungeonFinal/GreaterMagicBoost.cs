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
            if(getDuration() == 5)
            {
                getHero().setModMagic(getHero().getModMagic() + 10);                
            }

            else if(getDuration() == 1)
            {
                getHero().setModMagic(getHero().getModMagic() - 10);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " magic has been boosted by 10 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
