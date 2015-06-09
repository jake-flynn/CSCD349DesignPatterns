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
    class Warlock : Hero
    {
        //this is a Cleric Hero, considered a healer, there are 40 points assigned to main stats


        public Warlock()
        {
            setName("Warlock");

           //Stats
            setMaxHealth(160);
            setBaseHealth(160);
            setCurHealth(160);
            setMaxMana(220);
            setBaseMana(220);
            setCurMana(220);
            
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(15);
            setModMagic(15);
            setBaseDefense(4);
            setModDefense(4);
            setBaseResistance(6);
            setModResistance(6);

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
            setDescription("The Warlock is a demonic mage, who has tapped into the forbidden arts,\r\n"
                            + "awakending magics that might be better off left alone.\r\n"
                            + "His sepcialty is summoning great firestorms that bring devastation to his enemies,\r\n"
                            + "especially as they grow in number.");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Warlock.jpg", UriKind.RelativeOrAbsolute));
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

        /*PerformSpecialAttack - AoE attack to all monsters*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters)
        {
            Hero[] party = theParty.getAllHeroes();

            int damageWithCalculations = 0;

            foreach (Monster mon in monsters)
            {
                damageWithCalculations =((int)(getModMagic() * 1.75) - mon.getModResistance());
                mon.setCurHealth(mon.getCurHealth() - damageWithCalculations);
            }

            setCurMana(getCurMana() - 15);

            return (getName() + " performed Firestorm for " + damageWithCalculations + " damage across all monsters!");
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
