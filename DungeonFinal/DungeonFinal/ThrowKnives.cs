﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class ThrowKnives : SpecialAttackBehavior
    {
        public void PerformSpecialAttack(Party theParty, int whichHero)
        {
            Console.WriteLine("Performed a Throw Knives attack!");
        }
    }
}
