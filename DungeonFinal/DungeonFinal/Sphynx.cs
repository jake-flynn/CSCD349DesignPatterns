﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Sphynx : Monster
    {
        private SpecialAttackBehavior _SpecialAttack = null;

       //DVC
        public Sphynx()
        {
            base.setName("Sphynx");
            base.setModHealth(100);
            base.setMana(100);

            //Main stats are out of 40 points
            base.setStrength(0);
            base.setMagic(10);
            base.setDefense(15);
            base.setResistance(15);

            base.setIsPhysical(false);
            this._SpecialAttack = new Curse();
            base.setSpecialAttack(this._SpecialAttack);
            
            base.setIsDefending(false);
            base.setDefendingDefense(this.getDefendingDefense());
            base.setDefendingResistance(this.getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = base.getMagic();
            return m;
        }
        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getHeros();
            Hero target = party[0];

            if (p.getCurrentPartyMembers() == 1)
            {
                return target;
            }

            for (int i = 0; i < (p.getCurrentPartyMembers() - 2); i++)
            {
                if(party[i + 1].getModHealth() < party[i].getModHealth())
                {
                    target = party[i + 1];
                }
            }

            return target;
        }

       /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = base.getDefense() * 1;
            base.setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = base.getResistance() * 1;
            base.setDefendingDefense(dr);

            return dr;
        }
    }
}
