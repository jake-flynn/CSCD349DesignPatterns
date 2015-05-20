using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Cleric : Hero, SpecialAttackBehavior
    {
        //this is a Cleric Hero, considered a healer, there are 40 points assigned to main stats

        
        public Cleric()
        {
            setName("Cleric");
            setModHealth(100);
            setMana(100);

            //Main stats are out of 40 points
            setStrength(0);
            setMagic(20);
            setDefense(0);
            setResistance(20);

            setIsPhysical(false);
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
        /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int s = getMagic();
            return s;
        }

        public override void PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {

        }

        /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = getDefense() * 2;
            setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = getResistance() * 2;
            setDefendingDefense(dr);

            return dr;
        }
    }
}
