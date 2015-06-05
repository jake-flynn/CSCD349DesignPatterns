using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserMagicBoost : StatusEffect
    {
        public LesserMagicBoost()
        {
            setDuration(3);
        }

        public override String Modify()
        {
            setDuration(getDuration() - 1);
           
            if(getDuration() == 2)
            {
                getHero().setModMagic(getHero().getModMagic() + 3);
            }

            if (getDuration() > 0)
            {
                return (getHero().getName() + " magic has been boosted by 3 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModMagic(getHero().getModMagic() - 3);
                return (getHero().getName() + " lesser magic boost has ended!\r\n");
            }
        }
    }
}
