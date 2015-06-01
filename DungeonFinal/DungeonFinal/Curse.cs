using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonFinal
{
    class Curse : StatusEffect
    {
        public Curse(Hero h)
        {
            setHero(h);
            setDuration(5);

            //_Hero.addObserver(this);
        }

        public override void Modify()
        {
            if(getDuration() ===)

            setDuration(getDuration() - 1);            
        }

    }
}
