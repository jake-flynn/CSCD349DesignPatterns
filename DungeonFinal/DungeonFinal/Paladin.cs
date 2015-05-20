using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Paladin : Hero
    {
        //this is a Paladin Hero, it is a strength based hero with high magic resistance, there are 40 points assigned to main stats

        //DVC
        public Paladin()
        {
            setName("Paladin");
            setModHealth(100);
            setMana(100);

            //Main stats are out of 40 points
            setStrength(10);
            setMagic(10);
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

        public override void PerformSpecialAttack(Party theParty, int whichHero)
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
