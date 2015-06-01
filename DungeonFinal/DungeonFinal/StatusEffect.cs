using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonFinal
{
    public abstract class StatusEffect
    {
        int _Duration;
        Hero _Hero;

        public StatusEffect()
        {
            _Duration = 1;
            _Hero = null;
        }

        public int getDuration()
        {
            return _Duration;
        }

        public void setDuration(int d)
        {
            _Duration = d;
        }

        public Hero getHero()
        {
            return _Hero;
        }

        public void setHero(Hero h)
        {
            _Hero = h;
        }

        public abstract void Modify();

    }
}
