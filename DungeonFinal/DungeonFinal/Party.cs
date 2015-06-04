using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DungeonFinal
{
    public class Party
    {
        private Hero[] _dungeonParty;
        private int _currentPartyMembers;
        public Inventory _inventory;


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

        public Hero[] getAllHeroes()
        {
            return _dungeonParty;
        }

        public void setHeroes(Hero[] newParty)
        {
            _dungeonParty = newParty;
            _currentPartyMembers = 4;
        }

        public Hero[] getAliveHeroes()
        {
            Hero[] _AliveHeroes;
            int _numberOfHerosAlive = 0;
            foreach(Hero h in _dungeonParty)
            {
                if(!h.getIsDefeated())
                {
                    _numberOfHerosAlive++;
                }
            }

            _AliveHeroes = new Hero[_numberOfHerosAlive];
            int _nextAvailableIndex = 0;

            for(int x = 0; x < _numberOfHerosAlive; x++)
            {
                if(!_dungeonParty[x].getIsDefeated())
                {
                    _AliveHeroes[_nextAvailableIndex] = _dungeonParty[x];
                    _nextAvailableIndex++;
                }
            }

            


            return _AliveHeroes;

        }

        public int getCurrentPartyMembers()
        {
            return _currentPartyMembers;
        }

        public Inventory getInventory()
        {
            return _inventory;
        }

    }
}
