using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    abstract public class Monster
    {

        private string _Name;
        private int _BaseHealth;
        private int _ModHealth;
        private int _Mana;
        private int _Strength;
        private int _Magic;
        private int _Defense;
        private int _Resistance;

        private Boolean _IsPhysical;
        private SpecialAttackBehavior _SpecialAttack;

        private Boolean _IsDefending;
        private int _DefendingDefense;
        private int _DefendingResistance;


        public Monster(){}

        public Monster(int i)
        {
            if (i == 1)
            {
                _Name = "Level 1 Monster";
                new Shade();
            }
            else if (i == 2)
            {
                _Name = "Level 2 Monster";
                new Shade();
            }
            else if (i == 3)
            {
                _Name = "Level 3 Monster";
                new Shade();
            }
            else if(i == 4)
            {
                _Name = "Boss Monster";
                new Shade();
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
        public abstract Hero FindTarget(Hero[] party);
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
    }
}
