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
            if(getDuration() == 5)
            {
                getHero().setModStrength(getHero().getModStrength() - 5);
                getHero().setModMagic(getHero().getModMagic() - 5);                
            }
            else if(getDuration() < 5 && getDuration() > 1)
            {}

            else
            {
                getHero().setModStrength(getHero().getModStrength() + 5);
                getHero().setModMagic(getHero().getModMagic() + 5);
            }
            setDuration(getDuration() - 1);            
        }

    }
}
