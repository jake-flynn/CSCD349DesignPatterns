using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Party
    {
        private Hero[] _dungeonParty;
        private int _currentPartyMembers;
        private Inventory _inventory;

        public Party()
        {
            _dungeonParty = new Hero[4];
            _currentPartyMembers = 0;
            _inventory = new Inventory();
        }

        public void addHero(Hero toAdd)
        {
            if(_currentPartyMembers < 4)
            {
                _dungeonParty[_currentPartyMembers] = toAdd;
                _currentPartyMembers++;
            }
        }

        public Hero[] getHeros()
        {
            return _dungeonParty;
        }

        public void setHeros(Hero[] newParty)
        {
            _dungeonParty = newParty;
            _currentPartyMembers = 4;
        }

        public int getCurrentPartyMembers()
        {
            return _currentPartyMembers;
        }
    }
}
