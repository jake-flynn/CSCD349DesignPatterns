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
    class Sorceress : Hero
    {
        //this is a Cleric Hero, considered a healer, there are 40 points assigned to main stats


        public Sorceress()
        {
            setName("Sorceress");
            setMaxHealth(140);
            setBaseHealth(140);
            setCurHealth(140);
            setMaxMana(120);
            setBaseMana(120);
            setCurMana(120);
            

            //Main stats are out of 40 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(20);
            setModMagic(20);
            setBaseDefense(3);
            setModDefense(3);
            setBaseResistance(5);
            setModResistance(5);

            setHelmet(new NullItemEquipment());
            setTorso(new NullItemEquipment());
            setGloves(new NullItemEquipment());
            setBoots(new NullItemEquipment());
            setWeapon(new NullItemEquipment());

            setIsPhysical(false);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Sorceress.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);

            setCanAttack(true);
            setCanSpecialAttack(true);
        }


        /*---------------------------------------------------------------------------------------*/

        /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/
        public override int BasicAttack()
        {
            int s = getModMagic();
            return s;
        }

        /*PerformSpecialAttack - Strong magic attack to one enemy*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAllHeroes();
            int damage = party[whichHero].getModMagic() * 2;

            mon.setCurHealth(mon.getCurHealth() - damage);
            setCurMana(getCurMana() - 15);

            return (getName() + " performed Bizzard for " + damage + " to monster!");
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-J6UohVY0-2Y/VV7poKYTrEI/AAAAAAAAAws/Xmdq1-qREdI/w506-h900/Cleric.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Brush getTextColor()
        {
            return Brushes.Purple;
        }
    }
}
