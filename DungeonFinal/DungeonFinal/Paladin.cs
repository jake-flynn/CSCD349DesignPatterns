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

           //Stats
            setMaxHealth(250);
            setBaseHealth(250);
            setCurHealth(250);
            setMaxMana(90);
            setBaseMana(90);
            setCurMana(90);
            
            setBaseStrength(12);
            setModStrength(12);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(9);
            setModDefense(9);
            setBaseResistance(10);
            setModResistance(10);

           //Special Attack
            setCanSpecialAttack(true);

           //Attack
            setIsPhysical(true);
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
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Paladin.jpg", UriKind.RelativeOrAbsolute));
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

        /*PerformSpecialAttack - buffs defense and resistance for 5 accross whole party*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters)
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

        public override Brush getTextColor()
        {
            return Brushes.Green;
        }
    }
}
