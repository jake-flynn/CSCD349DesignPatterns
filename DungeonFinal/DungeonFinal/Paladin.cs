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
            setBaseHealth(250);
            setCurHealth(250);
            setMaxHealth(250);
            setBaseMana(90);
            setCurMana(90);
            setMaxMana(90);

            //Main stats are out of 40 points
            setBaseStrength(12);
            setModStrength(12);
            setBaseMagic(12);
            setModMagic(12);
            setBaseDefense(9);
            setModDefense(9);
            setBaseResistance(10);
            setModResistance(10);

            setHelmet(new NullItemEquipment());
            setTorso(new NullItemEquipment());
            setGloves(new NullItemEquipment());
            setBoots(new NullItemEquipment());
            setWeapon(new NullItemEquipment());

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Paladin.jpg", UriKind.RelativeOrAbsolute));
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
            int s = getModStrength();
            return s;
        }

        /*PerformSpecialAttack - buffs defense and resistance for 5 accross whole party*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAllHeroes();

            foreach(Hero h in party)
            {
                h.Subscribe(new FullGuard(h));
            }
            setCurMana(getCurMana() - 15);
            return (getName() + " performed Full Guard for 5 defense and resistance accross whole party!\r\n");
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-9PZ0hjpgspI/VV7p99bG62I/AAAAAAAAAzg/Ejq9YL1hAtM/w506-h764/Paladin.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Brush getTextColor()
        {
            return Brushes.Green;
        }
    }
}
