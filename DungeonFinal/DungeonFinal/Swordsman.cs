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
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);

            //Main stats are out of 40 points
            setBaseStrength(15);
            setModStrength(15);
            setBaseMagic(5);
            setModMagic(5);
            setBaseDefense(15);
            setModDefense(15);
            setBaseResistance(5);
            setModResistance(5);

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(this.getDefendingDefense());
            setDefendingResistance(this.getDefendingResistance());
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

        public override ImageBrush getBrush()
        {
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-jwP2jq5N8vk/VV7qG6mhNWI/AAAAAAAAA1Q/MCdr_HdAZnw/w506-h731/Swordsman.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }
    }
}
