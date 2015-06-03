using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Rejuvenation : StatusEffect
    {
        public Rejuvenation()
        {
            setDuration(4);
        }

        public override String Modify()
        {
            getHero().setCurHealth(getHero().getCurHealth() + 15);
            getHero().setCurMana(getHero().getCurMana() + 15);                
            setDuration(getDuration() - 1);

            return (getHero().getName() + " health and mana are being rejuvenated by 15 for " + getDuration() + " more turn(s)!\r\n");

        }
    }
}
