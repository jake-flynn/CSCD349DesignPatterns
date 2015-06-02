using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Silence : StatusEffect
    {
        public Silence(Hero h)
        {
            setHero(h);
            setDuration(3);
        }

        public override String Modify()
        {            
            if (getDuration() == 2)
            {
                getHero().setCanSpecialAttack(false);
            }

            else if(getDuration() == 1)
            {
                getHero().setCanSpecialAttack(true);
            }
            setDuration(getDuration() - 1);

            return (getHero().getName() + " has been silenced, they cannot use thier special attack for " + getDuration() + " more turn(s)!\r\n");
        }

    }
}
