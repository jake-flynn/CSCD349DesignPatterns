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
    class Monk : Hero
    {
        //this is a Cleric Hero, considered a healer, there are 40 points assigned to main stats


        public Monk()
        {
            setName("Monk");

           //Stats
            setBaseHealth(200);
            setCurHealth(200);
            setMaxHealth(200);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(14);
            setModMagic(14);
            setBaseDefense(7);
            setModDefense(7);
            setBaseResistance(7);
            setModResistance(7);

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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Monk.jpg", UriKind.RelativeOrAbsolute));
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

        /*PerformSpecialAttack - purifies status effects*/
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster[] monsters)
        {
            Hero[] party = theParty.getAllHeroes();

            foreach (Hero h in party)
            {
                h.ClearAllEffects();
            }

            setCurMana(getCurMana() - 15);
            return (getName() + " performed Purify and cleansed all effects from the party!");
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
