using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonFinal
{
    class Curse : SpecialAttackBehavior
    {
        public void PerformSpecialAttack()
        {
            Console.WriteLine("Performed a Curse!");
        }
    }
}
