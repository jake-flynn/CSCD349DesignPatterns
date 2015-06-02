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
        }

        public override String Modify()
        {
            if(getDuration() == 5)
            {
                getHero().setModStrength(getHero().getModStrength() - 7);
                getHero().setModMagic(getHero().getModMagic() - 7);                
            }

            else if(getDuration() == 1)
            {
                getHero().setModStrength(getHero().getModStrength() + 7);
                getHero().setModMagic(getHero().getModMagic() + 7);
            }

            setDuration(getDuration() - 1);

            return (getHero().getName() + " is under a curse, it is sapping their strength " + getDuration() + " more turn(s)!");
        }

    }
}
