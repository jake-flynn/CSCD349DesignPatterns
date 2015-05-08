using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonFinal
{
    abstract class GameCharacter
    {
        private int _Health;
        private int _Mana;
        private int _Strength;
        private int _Magic;
        private int _Defense;
        private int _Resistance;

        private SpecialAttackBehavior _SpecialAttack;

        private Boolean _isDefending;
        private int _DefendingDefense;
        private int _DefendingResistance;
        
        //private int[10] _Inventory;
        //private int _InventoryCount;

        //DVC
        public GameCharacter()
        {
            this._Health = 100;
            this._Strength = 10;
            this._Magic = 10;
            this._Defense = 10;
            this._Resistance = 10;
        }

        //EVC
        public GameCharacter(int h, int s, int m, int d, int r)
        {
            this._Health = h;
            this._Strength = s;
            this._Magic = m;
            this._Defense = d;
            this._Resistance = r;
        }

        public abstract string getName();

        //Get Set Methods
        public int getHealth()
        {
            return this._Health;
        }
        public void setHealth(int h)
        {
            this._Health = h;
        }
        public int getMana()
        {
            return this._Mana;
        }
        public void setMana(int m)
        {
            this._Mana = m;
        }
        public int getStrength()
        {
            return this._Strength;
        }
        public void setStrength(int s)
        {
            this._Strength = s;
        }
        public int getMagic()
        {
            return this._Magic;
        }
        public void setMagic(int m)
        {
            this._Magic = m;
        }
        public int getDefense()
        {
            return this._Defense;
        }
        public void setDefense(int d)
        {
            this._Defense = d;
        }
        public int getResistance()
        {
            return this._Resistance;
        }
        public void setResistance(int r)
        {
            this._Resistance = r;
        }

        //Battle Attack
        public abstract int BasicAttack();
        public abstract GameCharacter FindTarget(GameCharacter[] party);
        public void SpecialAttack()
        {
            this._SpecialAttack.PerformSpecialAttack();
        }
        public void setSpecialAttack(SpecialAttackBehavior sa)
        {
            this._SpecialAttack = sa;
        }

        //Battle Defend
        public Boolean getIsDefending()
        {
            return this._isDefending;
        }
        public void setIsDefending(Boolean iD)
        {
            this._isDefending = iD;
        }
        public abstract int getDefendingDefense();
        public void setDefendingDefense(int dd)
        {
            this._DefendingDefense = dd;
        }
        public abstract int getDefendingResistance();
        public void setDefendingResistance(int dr)
        {
            this._DefendingResistance = dr;
        }

        //Items
        /*public Boolean addItem(int num)
        {
            if(this._InventoryCount == 10)
         *  {
         *      return false;
         *  }
         *  
         *  else
         *  {
         *      this._Inventory[this._InventoryCount+1] = num;
         *      this._InventoryCount += 1;
         *      
         *      return true;
         *  }
        }
         * 
         * //Will receive the index of the item to remove.
        public int removeItem(int i)
        {
         *  int toRemove = -1;
         *  int tempNum = -1;
         * 
         *  this._Inventory[i] = toRemove;
         * 
            for(int j = i; j < _InventoryCount; j++)
         *  {
         *      this._Inventory[j] = 0;
         *  }
         *  
         *  this._Inventory[_InventoryCount] = -1;
         *  _InventoryCount -= 1;
         *  
         *  return toRemove;
        }*/
    }
}
