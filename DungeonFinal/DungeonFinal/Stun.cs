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
            setDuration(10);

            //_Hero.addObserver(this);
        }

        public override void Modify()
        {            
            if (getDuration() == 5)
            {
                getHero().setCanAttack(false);
            }
            else if (getDuration() < 5 && getDuration() > 1)
            { }

            else
            {
                getHero().setCanAttack(true);
            }
            setDuration(getDuration() - 1);            
        }

    }
}
