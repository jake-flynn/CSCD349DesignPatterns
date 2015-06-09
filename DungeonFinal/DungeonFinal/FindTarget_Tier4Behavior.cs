using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class FindTarget_Tier4Behavior : IFindTarget
    {
        Random _randomNumber;

        public Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();
            _randomNumber = RandomGenerator.Instance;
            int attackType = _randomNumber.Next(1, 3);
            Hero target = party[0];

            //Tier 1 FindTarget
            if (attackType == 1)
            {
                int randomHero = _randomNumber.Next(1, party.Length);
                target = party[randomHero];
            }

           //Tier 2 FindTarget
            else if (attackType == 2)
            {
                if (party.Length == 1)
                {
                    return target;
                }

                for (int i = 0; i < (party.Length - 2); i++)
                {
                    if (party[i + 1].getCurHealth() < party[i].getCurHealth())
                    {
                        target = party[i + 1];
                    }
                }
            }

           //Tier 3 FindTarget
            else if (attackType == 3)
            {
                if (party.Length == 1)
                {
                    return target;
                }

                for (int i = 0; i < (party.Length - 2); i++)
                {
                    if (party[i + 1].getModDefense() < party[i].getModDefense())
                    {
                        target = party[i + 1];
                    }
                }
            }

            return target;
        }
    }
}
