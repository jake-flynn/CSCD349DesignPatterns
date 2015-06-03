using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class MagicBoost : StatusEffect
    {
         public MagicBoost()
        {
            setDuration(4);
        }

        public override String Modify()
        {
            if(getDuration() == 4)
            {
                getHero().setModMagic(getHero().getModMagic() + 6);                
            }

            else if(getDuration() == 1)
            {
                getHero().setModMagic(getHero().getModMagic() - 6);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " magic has been boosted by 6 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
