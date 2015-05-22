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
    abstract public class Hero : SpecialAttackBehavior
    {
        private string _Name;
        private int _BaseHealth = 100;
        private int _ModHealth = 100;
        private int _BaseMana = 100;
        private int _ModMana = 100;
        private int _BaseStrength = 1;
        private int _ModStrength = 1;
        private int _BaseMagic = 1;
        private int _ModMagic = 1;
        private int _BaseDefense = 1;
        private int _ModDefense = 1;
        private int _BaseResistance = 1;
        private int _ModResistance = 1;
        
        
        private Boolean _IsPhysical;
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
    /*                              Get/Set Methods                                          */
    /*---------------------------------------------------------------------------------------*/
        //------------------------------- Name -------------------------------
        public string getName()
        {
            return _Name;
        }

        public void setName(String n)
        {
            _Name = n;
        }

        //------------------------------- Health -------------------------------
        public int getBaseHealth()
        {
            return _BaseHealth;
        }

        public void setBaseHealth(int h)
        {
            _BaseHealth = h;
        }

        public int getModHealth()
        {
            return _ModHealth;
        }
        public void setModHealth(int h)
        {
            _ModHealth = h;
        }
        //------------------------------- Mana -------------------------------
        public int getBaseMana()
        {
            return _BaseMana;
        }
        public void setBaseMana(int m)
        {
            _BaseMana = m;
        }
        public int getModMana()
        {
            return _ModMana;
        }
        public void setModMana(int m)
        {
            _ModMana = m;
        }
        //------------------------------- Strength -------------------------------
        public int getBaseStrength()
        {
            return _BaseStrength;
        }
        public void setBaseStrength(int s)
        {
            _BaseStrength = s;
        }
        public int getModStrength()
        {
            return _ModStrength;
        }
        public void setModStrength(int s)
        {
            _ModStrength = s;
        }
        //------------------------------- Magic -------------------------------
        public int getBaseMagic()
        {
            return _BaseMagic;
        }
        public void setBaseMagic(int m)
        {
            _BaseMagic = m;
        }
        public int getModMagic()
        {
            return _ModMagic;
        }
        public void setModMagic(int m)
        {
            _ModMagic = m;
        }
        //------------------------------- Defense -------------------------------
        public int getBaseDefense()
        {
            return _BaseDefense;
        }
        public void setBaseDefense(int d)
        {
            _BaseDefense = d;
        }
        public int getModDefense()
        {
            return _ModDefense;
        }
        public void setModDefense(int d)
        {
            _ModDefense = d;
        }
        //------------------------------- Resistance -------------------------------
        public int getBaseResistance()
        {
            return _BaseResistance;
        }
        public void setBaseResistance(int r)
        {
            _BaseResistance = r;
        }
        public int getModResistance()
        {
            return _ModResistance;
        }
        public void setModResistance(int r)
        {
            _ModResistance = r;
        }

       //Special attack reference here
        public abstract void PerformSpecialAttack(Party theParty, int whichHero, Monster mon);

       //Battle Attack
        public abstract int BasicAttack();
        public Boolean getIsPhysical()
        {
            return _IsPhysical;
        }
        public void setIsPhysical(Boolean iP)
        {
            _IsPhysical = iP;
        }

        public Boolean getIsDefeated()
        {
            return _IsDefeated;
        }
        public void setIsDefeated(Boolean iD)
        {
            _IsDefeated = iD;
        }

       //Battle Defend
        public Boolean getIsDefending()
        {
            return _IsDefending;
        }
        public void setIsDefending(Boolean iD)
        {
            _IsDefending = iD;
        }
        public abstract int getDefendingDefense();
        public void setDefendingDefense(int dd)
        {
            _DefendingDefense = dd;
        }
        public abstract int getDefendingResistance();
        public void setDefendingResistance(int dr)
        {
            _DefendingResistance = dr;
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
            return _Name;
        }

        public abstract ImageBrush getBrush();


    }
}