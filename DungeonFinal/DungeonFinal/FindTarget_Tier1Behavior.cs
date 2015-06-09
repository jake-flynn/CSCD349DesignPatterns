using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class FindTarget_Tier1Behavior : IFindTarget
    {
        Random _randomNumber;

        public Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();
            _randomNumber = RandomGenerator.Instance;

            int randomHero = _randomNumber.Next(party.Length);
            Hero target = party[randomHero];

            return target;
        }
    }
}
