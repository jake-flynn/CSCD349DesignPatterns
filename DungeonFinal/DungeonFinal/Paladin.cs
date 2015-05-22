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
    class Paladin : Hero
    {
        //this is a Paladin Hero, it is a strength based hero with high magic resistance, there are 40 points assigned to main stats

        //DVC
        public Paladin()
        {
            setName("Paladin");
            setBaseHealth(100);
            setModHealth(100);
            setBaseMana(100);
            setModMana(100);

            //Main stats are out of 40 points
            setBaseStrength(10);
            setModStrength(10);
            setBaseMagic(10);
            setModMagic(10);
            setBaseDefense(10);
            setModDefense(10);
            setBaseResistance(10);
            setModResistance(10);

            setIsPhysical(true);
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
            int s = getModStrength();
            return s;
        }

        public override void PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            int def = 0;
            MessageBox.Show("Performed Full Guard for " + def + " defense!");
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


        public override ImageBrush getBrush()
        {
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@""));
            imgBrush.ImageSource = image;
            return imgBrush;
        }
    }
}
