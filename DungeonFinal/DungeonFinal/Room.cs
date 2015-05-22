using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Room
    {

        private Door _NorthDoor, _EastDoor, _SouthDoor, _WestDoor;
        private bool _IsExit;
        private Monster M;
        private bool hasAMonster;
        private bool monsterDefeated;

        public bool hasMonster()
        {
            return this.hasAMonster;
        }

        public void setMonster(Monster newMon)
        {
            this.M = newMon;
            this.hasAMonster = true;
            this.monsterDefeated = false;
          
        }

        public Monster getMonster()
        {
            return this.M;
        }

        public void defeatedMonster()
        {
            monsterDefeated = true;
            hasAMonster = false;
        }

        public Door GetNorthDoor()
        {
            return _NorthDoor;
        }

        public void SetNorthDoor(Door north)
        {
            _NorthDoor = north;
        }

        public Door GetEastDoor()
        {
            return _EastDoor;
        }

        public void SetEastDoor(Door east)
        {
            _EastDoor = east;
        }

        public Door GetSouthDoor()
        {
            return _SouthDoor;
        }

        public void SetSouthDoor(Door south)
        {
            _SouthDoor = south;
        }

        public Door GetWestDoor()
        {
            return _WestDoor;
        }

        public void SetWestDoor(Door west)
        {
            _WestDoor = west;
        }

        public bool IsExit()
        {
            return _IsExit;
        }

        public void SetExit()
        {
            _IsExit = true;
        }

        public void shutNorthDoor()
        {
            _NorthDoor.Shut();
        }

        public void shutEastDoor()
        {
            _EastDoor.Shut();
        }

        public void shutSouthDoor()
        {
            _SouthDoor.Shut();
        }

        public void shutWestDoor()
        {
            _WestDoor.Shut();
        }

        public void openNorthDoor()
        {
            _NorthDoor.Open();
        }

        public void openEastDoor()
        {
            _EastDoor.Open();
        }

        public void openSouthDoor()
        {
            _SouthDoor.Open();
        }

        public void openWestDoor()
        {
            _WestDoor.Open();
        }

        public void openAllDoors()
        {
            openNorthDoor();
            openEastDoor();
            openSouthDoor();
            openWestDoor();
        }

    }
}
