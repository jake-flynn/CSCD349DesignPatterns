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
    class Cleric : Hero
    {
        //this is a Cleric Hero, considered a healer, there are 40 points assigned to main stats

        
        public Cleric()
        {
            setName("Cleric");

           //Stats
            setMaxHealth(150);
            setBaseHealth(150);
            setCurHealth(150);
            setMaxMana(200);
            setBaseMana(200);
            setCurMana(200);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(14);
            setModMagic(14);
            setBaseDefense(2);
            setModDefense(2);
            setBaseResistance(8);
            setModResistance(8);

           //Special Attack
            setCanSpecialAttack(true);

           //Attack
            setIsPhysical(false);
            setIsDefeated(false);
            setCanAttack(true);

           //Defend
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

           //Equipment
            setHelmet(new NullItemEquipment());
            setTorso(new NullItemEquipment());
            setGloves(new NullItemEquipment());
            setBoots(new NullItemEquipment());
            setWeapon(new NullItemEquipment());

           //Identity
            setDescription("The Cleric is a gentle scholar, trained extensively in the healing arts,\r\n"
                            + "not known for ferocity in battle, but capable of healing the gravest of injuries.\r\n"
                            + "His specialty is healing large groups of allies simultaniously");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Cleric.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


        /*---------------------------------------------------------------------------------------*/

        /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/
        public override int BasicAttack()
        {
            int s = getModMagic();
            return s;
        }

        /*PerformSpecialAttack - heals whole party for magic stat and removes debuffs/buffs*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters)
        {
            Hero[] party = theParty.getAllHeroes();

            foreach (Hero h in party)
            {
                h.setCurHealth(h.getCurHealth() + getModMagic());
            }

            setCurMana(getCurMana() - 15);
            return(getName() + " performed Healing Light for " + getModMagic() + " healing across whole party and reset all stats!");
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
