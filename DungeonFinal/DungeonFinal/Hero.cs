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
    abstract public class Hero
    {
        private string _Name;

       //Stats
        private int _BaseHealth = 100;
        private int _CurHealth = 100;
        private int _MaxHealth = 100;

        private int _BaseMana = 100;
        private int _CurMana = 100;
        private int _MaxMana = 100;

        private int _BaseStrength = 1;
        private int _ModStrength = 1;

        private int _BaseMagic = 1;
        private int _ModMagic = 1;

        private int _BaseDefense = 1;
        private int _ModDefense = 1;

        private int _BaseResistance = 1;
        private int _ModResistance = 1;

       //Special Attack
        private Boolean _CanSpecialAttack;

       //Attack
        private Boolean _IsPhysical;
        private Boolean _IsDefeated;
        private Boolean _CanAttack;

       //Defend
        private Boolean _IsDefending;
        private int _DefendingDefense;
        private int _DefendingResistance;

       //Status Effects
        private LinkedList<StatusEffect> _EffectList = new LinkedList<StatusEffect>();

       //Equipment
        private Equipment _Helmet;
        private Equipment _Torso;
        private Equipment _Boots;
        private Equipment _Gloves;
        private Equipment _Weapon;

       //Identity
        private String _Stats;
        private ImageBrush _ImageBrush;

        public Hero(){}

        /*
         * Heroes: ArmorKnight, Cleric, Monk, Paladin, Rogue, Sorceress, Swordsman, Warlock
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
            if(h < 0)
            {
                _CurHealth = 0;
                setIsDefeated(true);
                _EffectList.Clear();
            }



            else if (h > getMaxHealth())
            {
                _CurHealth = getMaxHealth();
            }

            else
            {
                _CurHealth = h;
            }
            
        }

        public void setMaxHealth(int h)
        {
            _MaxHealth = h;
        }
        public int getMaxHealth()
        {
            return _MaxHealth;
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

            else if(m > getMaxMana())
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
            if(s < 0)
            {
                _ModStrength = 0;
            }

            else 
            {
                _ModStrength = s;
            }
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
        public void setCanSpecialAttack(Boolean cSA)
        {
            _CanSpecialAttack = cSA;
        }

        public Boolean getCanSpecialAttack()
        {
            return _CanSpecialAttack;
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

        public void setCanAttack(Boolean cA)
        {
            _CanAttack = cA;
        }

        public Boolean getCanAttack()
        {
            return _CanAttack;
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

        //------------------------------- Status Effect Methods -------------------------------
        //Notify - handles each effect on the hero and removes an effect if the duration == 0
        public string Notify()
        {
            string retString = "";

            int ctr = 0;

            foreach (StatusEffect e in _EffectList)
            {
                MessageBox.Show("Number off effects: " + ctr);
                retString += e.Modify();
                ctr++;
                if (e.getDuration() <= 0)
                {
                    Unsubscribe(e);
                }
            }

            return retString;
        }

        //Subscribe - adds the specified effect to the _EffectList of the hero
        public void Subscribe(StatusEffect e)
        {
            _EffectList.AddLast(e);
        }

        //Unsubscribe - removes the first effect of that type from the lists (however, because the effects are added last, 
        //              the oldest effect will be the first one found through Remove()
        public void Unsubscribe(StatusEffect e)
        {
            _EffectList.Remove(e);
        }

        public void ClearAllEffects()
        {
            _EffectList.Clear();
        }

        //------------------------------- Equipment Methods -------------------------------

        public Equipment getHelmet()
        {
            return _Helmet;
        }

        public void setHelmet(Equipment newHelmet)
        {
            _Helmet = newHelmet;
        }

        public Equipment getTorso()
        {
            return _Torso;
        }

        public void setTorso(Equipment newTorso)
        {
            _Torso = newTorso;
        }

        public Equipment getBoots()
        {
            return _Boots;
        }

        public void setBoots(Equipment newBoots)
        {
            _Boots = newBoots;
        }

        public Equipment getGloves()
        {
            return _Gloves;
        }

        public void setGloves(Equipment newGloves)
        {
            _Gloves = newGloves;
        }

        public Equipment getWeapon()
        {
            return _Weapon;
        }

        public void setWeapon(Equipment newWeapon)
        {
            _Weapon = newWeapon;
        }

        //------------------------------- Identity Methods -------------------------------
        public String getStats()
        {
            String s = "Strength: " + getModStrength() + "\nMagic: " + getModMagic() + "\nDefense: " + getModDefense() + "\nResistance: " + getModResistance();
            return s;
        }

        public void setStats(String s)
        {
            _Stats = s;
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
        public abstract String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters);
        public abstract int BasicAttack();
        public abstract int getDefendingDefense();
        public abstract int getDefendingResistance();
        public abstract Brush getTextColor();
    }
}