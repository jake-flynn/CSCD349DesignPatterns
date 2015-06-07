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
    class ArmorKnight : Hero
    {
        //this is a Cleric Hero, considered a healer, there are 40 points assigned to main stats


        public ArmorKnight()
        {
            setName("Armor Knight");

           //Stats
            setBaseHealth(275);
            setCurHealth(275);
            setMaxHealth(275);
            setBaseMana(70);
            setCurMana(70);
            setMaxMana(70);

            setBaseStrength(10);
            setModStrength(10);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(13);
            setModDefense(13);
            setBaseResistance(12);
            setModResistance(12);

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
            setDescription("Description: ");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/ArmorKnight.jpg", UriKind.RelativeOrAbsolute));
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

        /*PerformSpecialAttack - Taunt monsters to attack THIS ArmorKnight */
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters)
        {
            setIsTaunting(true);

            Subscribe(new Taunt(this));

            setCurMana(getCurMana() - 15);
            return (getName() + " has taunted the enemy!");
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
            return Brushes.Purple;
        }
    }
}
