using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class FullGuard : SpecialAttackBehavior
    {
        public void PerformSpecialAttack()
        {
            Console.WriteLine("Performed Full Guard!");
        }
    }
}
