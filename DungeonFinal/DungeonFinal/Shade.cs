using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Shade : Monster
    {
        //this is a Shade monster, it is a tier 1 level, there are 20 points assigned to main stats

       //DVC
        public Shade()
        {
            setName("Shade");
            base.setModHealth(100);
            base.setMana(100);

            //Main stats are out of 20 points
            base.setStrength(0);
            base.setMagic(10);
            base.setDefense(0);
            base.setResistance(10);

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

            int rnd = new Random().Next(1, party.Length);
            Hero target = party[rnd];

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
