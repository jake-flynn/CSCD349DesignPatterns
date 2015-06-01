using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Poison : StatusEffect
    {
        public Poison(Hero h)
        {
            setHero(h);
            setDuration(10);

            //_Hero.addObserver(this);
        }

        public override void Modify()
        {
            Hero h = getHero();

            setDuration(getDuration() - 1);
            h.setCurHealth(h.getCurHealth() - 15);
        }

    }
}
