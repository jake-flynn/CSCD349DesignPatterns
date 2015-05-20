using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public interface SpecialAttackBehavior
    {
        void PerformSpecialAttack(Party theParty, int whichHero, Monster mon);
    }
}
