using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class GreaterRejuvenation : StatusEffect
    {
        public GreaterRejuvenation()
        {
            setDuration(5);
        }

        public override String Modify()
        {
            getHero().setCurHealth(getHero().getCurHealth() + 20);
            getHero().setCurMana(getHero().getCurMana() + 20);                
            setDuration(getDuration() - 1);

            if (getDuration() > 0)
            {
                return (getHero().getName() + " health and mana are being rejuvenated by 20 for " + getDuration() + " more turn(s)!\r\n");
            }

            else
            {
                return (getHero().getName() + " greater rejuvenation potion has ended!\r\n");
            }
        }
    }
}
