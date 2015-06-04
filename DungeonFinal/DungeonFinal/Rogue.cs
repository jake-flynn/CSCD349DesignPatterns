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

           //Stats
            setMaxHealth(140);
            setBaseHealth(140);
            setCurHealth(140);
            setMaxMana(120);
            setBaseMana(120);
            setCurMana(120);

            setBaseStrength(20);
            setModStrength(20);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(5);
            setModDefense(5);
            setBaseResistance(3);
            setModResistance(3);

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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Rogue.jpg", UriKind.RelativeOrAbsolute));
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
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters)
        {
            int damage = (int)(getModStrength() * 2.5);
            var cWindow = new ChoiceWindow(monsters);

            cWindow.ShowDialog();
            int monsterToAttack = cWindow.getChoiceFromSelect();

            setCurMana(getCurMana() - 15);
            monsters[monsterToAttack].setCurHealth(monsters[monsterToAttack].getCurHealth() - (monsters[monsterToAttack].getModDefense() - damage));

            return (getName() + " performed Throw Knives for " + (monsters[monsterToAttack].getModDefense() - damage) + " damage!");
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
            return Brushes.Gray;
        }
    }
}
