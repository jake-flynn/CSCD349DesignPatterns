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
            setDuration(getDuration() - 1);

            if (getDuration() > 0)
            {
                return (getHero().getName() + " magic has been boosted by 6 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                getHero().setModMagic(getHero().getModMagic() - 6);
                return (getHero().getName() + " magic boost has ended!\r\n");
            }
        }
    }
}
