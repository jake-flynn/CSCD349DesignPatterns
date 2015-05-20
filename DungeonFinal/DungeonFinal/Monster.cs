using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public abstract class Monster
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
        private Boolean _IsDefeated;
        private Boolean _IsDefending;
        private int _DefendingDefense;
        private int _DefendingResistance;
        
        public Monster(){}

        /*
         * Tier 1 Monster: Shade, Skeleton, Insect, VampireBat, Slime, Imp              20 points stats; Random attack target
         * Tier 2 Monster: Beast, Werewolf, Harpy, Hellhound, Cockatrice, Sphynx        40 points stats; Attack lowest health target
         * Tier 3 Monster: Centaur, DemonWarrior, Cyclops                               60 points stats; Target has highest weakness to monster
         * Boss Monster: Dragon, Minotaur, Chimera, Hydra                               80 points stats; Any of the three target methods
         */



        /*---------------------------------------------------------------------------------------*/
       //Get Set Methods
        public string getName()
        {
            return _Name;
        }

        public void setName(String n)
        {
            _Name = n;
        }

        public int getBaseHealth()
        {
            return _BaseHealth;
        }

       //Get Set Methods
        public int getModHealth()
        {
            return _ModHealth;
        }
        public void setModHealth(int h)
        {
            _ModHealth = h;
        }
        public int getMana()
        {
            return _Mana;
        }
        public void setMana(int m)
        {
            _Mana = m;
        }
        public int getBasicAttack()
        {
            return _Strength;
        }
        public void setStrength(int s)
        {
            _Strength = s;
        }
        public int getMagic()
        {
            return _Magic;
        }
        public void setMagic(int m)
        {
            _Magic = m;
        }
        public int getDefense()
        {
            return _Defense;
        }
        public void setDefense(int d)
        {
            _Defense = d;
        }
        public int getResistance()
        {
            return _Resistance;
        }
        public void setResistance(int r)
        {
            _Resistance = r;
        }

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

        public abstract Hero FindTarget(Party p);

        public void setSpecialAttack(SpecialAttackBehavior sa)
        {
            
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
    }
}
