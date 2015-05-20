using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    abstract public class Hero : SpecialAttackBehavior
    {
        private string _Name;
        private int _BaseHealth = 100;
        private int _ModHealth = 100;
        private int _Mana = 100;
        private int _Strength = 1;
        private int _Magic = 1;
        private int _Defense = 1;
        private int _Resistance = 1;
        
        
        private Boolean _IsPhysical;
        //private SpecialAttackBehavior _SpecialAttack;

        private Boolean _IsDefeated;
        private Boolean _IsDefending;
        private int _DefendingDefense;
        private int _DefendingResistance;

        //private int[10] _Inventory;
        //private int _InventoryCount;

        public Hero(){}


        /*
         * Heroes: Swordsman, Paladin, Cleric, Rogue                    40 points stats
         */
        public Hero(int i)
        {
            if (i == 1)
            {
                new Swordsman();
            }
            else if (i == 2)
            {
                //_Name = "Paladin";
                new Paladin();
            }
            else if (i == 3)
            {
                //_Name = "Cleric";
                new Cleric();
            }
            else if(i == 4)
            {
                //_Name = "Rogue";
                new Rogue();
            }

            _BaseHealth = 100;
        }

    /*---------------------------------------------------------------------------------------*/
       //Get Set Methods
        public string getName()
        {
            return this._Name;
        }

        public void setName(String n)
        {
            this._Name = n;
        }

        public int getBaseHealth()
        {
            return _BaseHealth;
        }

       //Get Set Methods
        public int getModHealth()
        {
            return this._ModHealth;
        }
        public void setModHealth(int h)
        {
            this._ModHealth = h;
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

       //Special attack reference here
        public abstract void PerformSpecialAttack(Party theParty, int whichHero, Monster mon);

       //Battle Attack
        public abstract int BasicAttack();
        public Boolean getIsPhysical()
        {
            return this._IsPhysical;
        }
        public void setIsPhysical(Boolean iP)
        {
            this._IsPhysical = iP;
        }

        public Boolean getIsDefeated()
        {
            return this._IsDefeated;
        }
        public void setIsDefeated(Boolean iD)
        {
            this._IsDefeated = iD;
        }

        //public void SpecialAttack()
        //{
        //    this._SpecialAttack.PerformSpecialAttack();
        //}
        //public void setSpecialAttack(SpecialAttackBehavior sa)
        //{
        //    this._SpecialAttack = sa;
        //}

       //Battle Defend
        public Boolean getIsDefending()
        {
            return this._IsDefending;
        }
        public void setIsDefending(Boolean iD)
        {
            this._IsDefending = iD;
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

        public string toString()
        {
            return this._Name;
        }


    }
}