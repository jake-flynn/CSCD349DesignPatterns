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
    public abstract class Monster : ICloneable
    {
        private string _Name;

        private int _BaseHealth;
        private int _CurHealth;
        private int _MaxHealth;

        private int _BaseMana;
        private int _CurMana;
        private int _MaxMana;

        private int _BaseStrength;
        private int _ModStrength;

        private int _BaseMagic;
        private int _ModMagic;

        private int _BaseDefense;
        private int _ModDefense;

        private int _BaseResistance;
        private int _ModResistance;

        private Boolean _IsPhysical;
        private Boolean _IsDefeated;
        private Boolean _IsDefending;
        private Boolean _IsSwarm;


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

        public int getCurHealth()
        {
            return _CurHealth;
        }
        public void setCurHealth(int h)
        {
            //if (h < 0)
            //{
            //    _CurHealth = 0;
            //}
            
            //else if (h > getMaxHealth())
            //{
            //    _CurHealth = getMaxHealth();
            //}

            //else
            //{
            _CurHealth = h;
            //}
        }
        public int getMaxHealth()
        {
            return _MaxHealth;
        }
        public void setMaxHealth(int h)
        {
            _MaxHealth = h;
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
        public int getCurMana()
        {
            return _CurMana;
        }
        public void setCurMana(int m)
        {
            if (m < 0)
            {
                _CurMana = 0;
            }

            else if (m > getMaxMana())
            {
                _CurMana = getMaxMana();
            }

            else
            {
                _CurMana = m;
            }
        }
        public int getMaxMana()
        {
            return _MaxMana;
        }
        public void setMaxMana(int m)
        {
            _MaxMana = m;
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
        
        public void setDefendingDefense(int dd)
        {
            _DefendingDefense = dd;
        }
       
        public void setDefendingResistance(int dr)
        {
            _DefendingResistance = dr;
        }

        public Boolean getIsSwarm()
        {
            return _IsSwarm;
        }

        public void setIsSwarm(Boolean iS)
        {
            _IsSwarm = iS;
        }


        //-------------------------------Abstract Methods -------------------------------
        public abstract int BasicAttack();
        public abstract void PerformSpecialAttack(Party theParty, int whichHero, Monster mon);
        public abstract Hero FindTarget(Party p);
        public abstract int getDefendingDefense();
        public abstract int getDefendingResistance();
        public abstract ImageBrush getBrush();
        public abstract Object Clone();
    }
}
