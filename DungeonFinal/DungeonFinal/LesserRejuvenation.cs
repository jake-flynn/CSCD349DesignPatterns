using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserRejuvenation : StatusEffect
    {
        public LesserRejuvenation()
        {
            setDuration(3);
        }

        public override String Modify()
        {
            getHero().setCurHealth(getHero().getCurHealth() + 10);
            getHero().setCurMana(getHero().getCurMana() + 10);                
            setDuration(getDuration() - 1);

            return (getHero().getName() + " health and mana are being rejuvenated by 10 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
