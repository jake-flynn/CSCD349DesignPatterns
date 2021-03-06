﻿using System;
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
    public abstract class Monster
    {
        private string _Name;

       //Stats
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

       //Special Attack
        private int _SpecialAttackFrequency; //This is an int between 1-10 that signifies how often a monster will use a special attack. E.G.: StuBeast always assigns homework.

       //Attack
        private Boolean _IsPhysical;
        private Boolean _IsDefeated;
        private IFindTarget _FindTargetBehavior;

       //Defend
        private Boolean _IsDefending;
        private int _DefendingDefense;
        private int _DefendingResistance;

       //Swarm
        private Boolean _IsSwarm;

       //Identity
        private int _TierNumber;
        private String _Stats;
        private String _Lore;
        private ImageBrush _ImageBrush;
        
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

        //------------------------------- Stats -------------------------------
        //Health
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
            if (h < 0)
            {
                _CurHealth = 0;                
            }
            
            //else if (h > getMaxHealth())
            //{
                //_CurHealth = getMaxHealth();
            //}

            else
            {
                _CurHealth = h;
            }
        }
        public int getMaxHealth()
        {
            return _MaxHealth;
        }
        public void setMaxHealth(int h)
        {
            _MaxHealth = h;
        }

        //Mana
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

        //Strength
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

        //Magic
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

        //Defense
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

        //Resistance
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


        //------------------------------- Special Attack Methods -------------------------------
        public int getSpecialAttackFrequency()
        {
            return _SpecialAttackFrequency;
        }

        public void setSpecialAttackFrequency(int newFreq)
        {
            _SpecialAttackFrequency = newFreq;
        }


        //------------------------------- Attack Methods -------------------------------
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

        public IFindTarget getFindTargetBahvior()
        {
            return _FindTargetBehavior;
        }
        public void setFindTargetBahvior(IFindTarget fTB)
        {
            _FindTargetBehavior = fTB;
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public Hero FindTarget(Party p)
        {
            return _FindTargetBehavior.FindTarget(p);
        }


        //------------------------------- Defend Methods -------------------------------
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


        //------------------------------- Swarm Methods -------------------------------
        public Boolean getIsSwarm()
        {
            return _IsSwarm;
        }

        public void setIsSwarm(Boolean iS)
        {
            _IsSwarm = iS;
        }

        //Modify stats for Clones
        public void modifyStats()
        {
            setBaseHealth((getBaseHealth() * 3) / 4);
            setCurHealth((getCurHealth() * 3) / 4);
            setMaxHealth((getMaxHealth() * 3) / 4);
            setBaseMana((getBaseMana() * 3) / 4);
            setCurMana((getCurMana() * 3) / 4);
            setMaxMana((getMaxMana() * 3) / 4);

            setBaseStrength((getBaseStrength() * 3) / 4);
            setModStrength((getModStrength() * 3) / 4);
            setBaseMagic((getBaseMagic() * 3) / 4);
            setModMagic((getModMagic() * 3) / 4);
            setBaseDefense((getBaseDefense() * 3) / 4);
            setModDefense((getModDefense() * 3) / 4);
            setBaseResistance((getBaseResistance() * 3) / 4);
            setModResistance((getModResistance() * 3) / 4);        
        }


        //------------------------------- Identity Methods -------------------------------
        public int getTierNumber()
        {
            return _TierNumber;
        }

        public void setTierNumber(int tN)
        {
            _TierNumber = tN;
        }

        public String getStats()
        {
            String s = "Strength: " + getModStrength() + "\nMagic: " + getModMagic() + "\nDefense: " + getModDefense() + "\nResistance: " + getModResistance();
            return _Stats;
        }

        public void setStats(String s)
        {
            _Stats = s;
        }

        public String getLore()
        {
            return _Lore;
        }

        public void setLore(String l)
        {
            _Lore = l;
        }

        public void setImageBrush(ImageBrush i)
        {
            _ImageBrush = i;
        }

        public ImageBrush getImageBrush()
        {
            return _ImageBrush;
        }


        //------------------------------- Abstract Methods -------------------------------
        public abstract int BasicAttack();
        public abstract String PerformSpecialAttack(Party theParty, int whichHero, Monster mon);
        //public abstract Hero FindTarget(Party p);
        public abstract int getDefendingDefense();
        public abstract int getDefendingResistance();
        public abstract Object Clone(int count);
    }
}
