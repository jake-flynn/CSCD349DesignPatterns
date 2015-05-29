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
    class Swordsman : Hero
    {
        //private SpecialAttackBehavior _SpecialAttack = null;

       //DVC
        public Swordsman()
        {
            setName("Swordsman");
            setBaseHealth(225);
            setCurHealth(225);
            setMaxHealth(225);
            setBaseMana(110);
            setCurMana(110);
            setMaxMana(110);

            setBaseStrength(15);
            setModStrength(15);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(8);
            setModDefense(8);
            setBaseResistance(5);
            setModResistance(5);

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(this.getDefendingDefense());
            setDefendingResistance(this.getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Swordsman.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


        /*---------------------------------------------------------------------------------------*/

       /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int s = base.getModStrength();
            return s;
        }

        /*PerformSpecialAttack - attacks for 1.5 strength and buffs strength and defense for 5*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            //Buff Strength and Defense
            setModDefense(getModDefense() + 5);
            setModStrength(getModStrength() + 5);

            //Damage Monster
            int dmg = (int)(getModStrength() * 1.5);
            mon.setCurHealth(mon.getCurHealth() - dmg);
            setCurMana(getCurMana() - 15);
            return(getName() + " buffed own defense and strength by 5! Performed a Blade Slash for " + dmg + " damage!");
        }

       /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = base.getModDefense() * 2;
            base.setDefendingDefense(dd);

            return dd;
        }

        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = base.getModResistance() * 2;
            base.setDefendingDefense(dr);

            return dr;
        }

        //public override ImageBrush getBrush()
        //{
        //    ImageBrush imgBrush = new ImageBrush();
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-jwP2jq5N8vk/VV7qG6mhNWI/AAAAAAAAA1Q/MCdr_HdAZnw/w506-h731/Swordsman.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Brush getTextColor()
        {
            return Brushes.Blue;
        }
    }
}
