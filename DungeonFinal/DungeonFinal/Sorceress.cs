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

           //Stats
            setMaxHealth(140);
            setBaseHealth(140);
            setCurHealth(140);
            setMaxMana(120);
            setBaseMana(120);
            setCurMana(120);
            
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(20);
            setModMagic(20);
            setBaseDefense(3);
            setModDefense(3);
            setBaseResistance(5);
            setModResistance(5);

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
            setDescription("Description: ");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Sorceress.jpg", UriKind.RelativeOrAbsolute));
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

        /*PerformSpecialAttack - Strong magic attack to one enemy*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters)
        {
            int damage = getModMagic() * 2;
            var cWindow = new ChoiceWindow(monsters);

            cWindow.ShowDialog();
            int monsterToAttack = cWindow.getChoiceFromSelect();

            monsters[monsterToAttack].setCurHealth(monsters[monsterToAttack].getCurHealth() - (monsters[monsterToAttack].getModResistance() - damage));
            setCurMana(getCurMana() - 15);

            return (getName() + " performed Blizzard for " + (monsters[monsterToAttack].getModResistance() - damage) + " to monster!");
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
