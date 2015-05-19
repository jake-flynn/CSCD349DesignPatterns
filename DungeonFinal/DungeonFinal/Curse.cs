using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonFinal
{
    class Curse : SpecialAttackBehavior
    {
        public void PerformSpecialAttack(Party theParty, int whichHero)
        {
            Console.WriteLine("Performed a Curse!");
        }
    }
}
