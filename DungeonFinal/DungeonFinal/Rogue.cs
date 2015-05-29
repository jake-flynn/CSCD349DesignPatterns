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
    class Rogue : Hero
    {
        //this is a Rogue Hero, it is a damage dealer, there are 40 points assigned to main stats

        
        public Rogue()
        {
            setName("Rogue");
            setBaseHealth(140);
            setCurHealth(140);
            setMaxHealth(140);
            setBaseMana(120);
            setCurMana(120);
            setMaxMana(120);

            setBaseStrength(20);
            setModStrength(20);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(5);
            setModDefense(5);
            setBaseResistance(3);
            setModResistance(3);

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Rogue.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


        /*---------------------------------------------------------------------------------------*/

        /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int s = getModStrength();
            return s;
        }

        /*PerformSpecialAttack - attacks for 2.5 strength*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            int dmg = (int)(getModStrength() * 2.5);
            setCurMana(getCurMana() - 15);
            mon.setCurHealth(mon.getCurHealth() - dmg);
            return(getName() + " performed Throw Knives for " + dmg + " damage!");
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

        //public override ImageBrush getBrush()
        //{
        //    ImageBrush imgBrush = new ImageBrush();
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-GqQ6Ja-aahk/VV7qAx0PD8I/AAAAAAAAA0E/tguBh4geous/w506-h647/Rogue.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Brush getTextColor()
        {
            return Brushes.Gray;
        }
    }
}
