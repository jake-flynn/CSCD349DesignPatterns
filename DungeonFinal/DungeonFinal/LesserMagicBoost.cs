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
            if(getDuration() == 3)
            {
                getHero().setModMagic(getHero().getModMagic() + 3);                
            }

            else if(getDuration() == 1)
            {
                getHero().setModMagic(getHero().getModMagic() - 3);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " magic has been boosted by 3 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
