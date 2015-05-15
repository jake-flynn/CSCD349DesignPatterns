using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Cleric : Hero
    {
        private SpecialAttackBehavior _SpecialAttack = null;

        //DVC
        public Cleric()
        {
            base.setName("Cleric");
            base.setModHealth(100);
            base.setMana(100);

            //Main stats are out of 40 points
            base.setStrength(0);
            base.setMagic(20);
            base.setDefense(0);
            base.setResistance(20);

            base.setIsPhysical(false);
            this._SpecialAttack = new HealingLight();
            base.setSpecialAttack(this._SpecialAttack);

            base.setIsDefending(false);
            base.setDefendingDefense(this.getDefendingDefense());
            base.setDefendingResistance(this.getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
        /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int s = base.getStrength();
            return s;
        }

        /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = base.getDefense() * 2;
            base.setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = base.getResistance() * 2;
            base.setDefendingDefense(dr);

            return dr;
        }
    }
}
