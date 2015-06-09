using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class FindTarget_Tier3Behavior : IFindTarget
    {
        public Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();
            Hero target = party[0];

            if (party.Length == 1)
            {
                return target;
            }

            for (int i = 0; i < (party.Length - 2); i++)
            {
                if (party[i + 1].getModResistance() < party[i].getModResistance())
                {
                    target = party[i + 1];
                }
            }

            return target;
        }
    }
}
