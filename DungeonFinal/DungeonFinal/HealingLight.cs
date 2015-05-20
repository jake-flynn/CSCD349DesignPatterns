using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonFinal
{
    class HealingLight : SpecialAttackBehavior
    {
        public void PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Console.WriteLine("Performed Healing Light!");
        }
    }
}
