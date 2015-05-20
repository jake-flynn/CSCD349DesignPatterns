using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Rogue : Hero, SpecialAttackBehavior
    {
        //this is a Rogue Hero, it is a damage dealer, there are 40 points assigned to main stats

        
        public Rogue()
        {
            setName("Rogue");
            setModHealth(100);
            setMana(100);

            //Main stats are out of 40 points
            setStrength(20);
            setMagic(0);
            setDefense(10);
            setResistance(10);

            setIsPhysical(true);
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
        /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int s = getStrength();
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
