using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Stun : StatusEffect
    {
        public Stun(Hero h)
        {
            setHero(h);
            setDuration(2);
        }

        public override String Modify()
        {            
            if (getDuration() == 2)
            {
                getHero().setCanAttack(false);
                getHero().setCanSpecialAttack(false);
            }

            else if(getDuration() == 1)
            {
                getHero().setCanAttack(true);
                getHero().setCanSpecialAttack(true);
            }
            setDuration(getDuration() - 1);

            return (getHero().getName() + " is stunned, and completely unable to attack for " + getDuration() + " more turn(s)!");
        }

    }
}
