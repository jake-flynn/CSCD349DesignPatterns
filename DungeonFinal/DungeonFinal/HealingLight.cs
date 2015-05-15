using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonFinal
{
    class HealingLight : SpecialAttackBehavior
    {
        public void PerformSpecialAttack()
        {
            Console.WriteLine("Performed Healing Light!");
        }
    }
}
