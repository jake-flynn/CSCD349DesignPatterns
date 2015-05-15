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
            int rnd = 1;

          //Tier 1 Monster
            if (i == 1)
            {
                rnd = new Random().Next(1, 6);
                _Name = "Level 1 Monster";
                if(rnd == 1)
                {
                    new Shade();
                }

                else if(rnd == 2)
                {
                    new Skeleton();
                }

                else if (rnd == 3)
                {
                    new Insect();
                }

                else if (rnd == 4)
                {
                    new VampireBat();
                }

                else if (rnd == 5)
                {
                    new Slime();
                }

                else if (rnd == 6)
                {
                    new Imp();
                }
            }
          //Tier 2 Monster
            else if (i == 2)
            {
                rnd = new Random().Next(1, 6);
                _Name = "Level 2 Monster";
                if (rnd == 1)
                {
                    new Beast();
                }

                else if (rnd == 2)
                {
                    new Werewolf();
                }

                else if (rnd == 3)
                {
                    new Harpy();
                }

                else if (rnd == 4)
                {
                    new Hellhound();
                }

                else if (rnd == 5)
                {
                    new Cockatrice();
                }

                else if (rnd == 6)
                {
                    new Sphynx();
                }
            }
          //Tier 3 Monster
            else if (i == 3)
            {
                rnd = new Random().Next(1, 3);
                _Name = "Level 3 Monster";
                if (rnd == 1)
                {
                    new Centaur();
                }

                else if (rnd == 2)
                {
                    new DemonWarrior();
                }

                else if (rnd == 3)
                {
                    new Cyclops();
                }
            }
          //Boss Monster
            else if(i == 4)
            {
                rnd = new Random().Next(1, 4);
                _Name = "Boss Monster";
                if (rnd == 1)
                {
                    new Dragon();
                }

                else if (rnd == 2)
                {
                    new Minotaur();
                }

                else if (rnd == 3)
                {
                    new Chimera();
                }

                else if (rnd == 4)
                {
                    new Hydra();
                }
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
