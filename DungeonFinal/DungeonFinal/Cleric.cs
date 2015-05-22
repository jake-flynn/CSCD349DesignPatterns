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
    class Cleric : Hero, SpecialAttackBehavior
    {
        //this is a Cleric Hero, considered a healer, there are 40 points assigned to main stats

        
        public Cleric()
        {
            setName("Cleric");
            setBaseHealth(100);
            setModHealth(100);
            setBaseMana(100);
            setModMana(100);

            //Main stats are out of 40 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(20);
            setModMagic(20);
            setBaseDefense(0);
            setModDefense(0);
            setBaseResistance(20);
            setModResistance(20);

            setIsPhysical(false);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
        /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int s = getModMagic();
            return s;
        }

        public override void PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            int dmg = 0;
            MessageBox.Show("Performed Healing Light for " + dmg + " healing!");
        }

        /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = getModDefense() * 2;
            setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = getModResistance() * 2;
            setDefendingDefense(dr);

            return dr;
        }
    }
}
