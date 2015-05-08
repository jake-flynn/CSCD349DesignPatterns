using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Party
    {
        private Hero[] dungeonParty;
        private int currentPartyMembers;

        public Party()
        {
            dungeonParty = new Hero[4];
            currentPartyMembers = 0;
        }

        public void addHero(Hero toAdd)
        {
            if(currentPartyMembers < 4)
            {
                dungeonParty[currentPartyMembers] = toAdd;
                currentPartyMembers++;
            }
        }

        public Hero[] getHeros()
        {
            return dungeonParty;
        }

        public void setHeros(Hero[] newParty)
        {
            dungeonParty = newParty;
            currentPartyMembers = 4;
        }
    }
}
