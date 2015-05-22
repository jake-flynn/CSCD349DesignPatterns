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
    class Cyclops : Monster
    {
        //this is a Cyclops monster, it is a tier 3 level, there are 60 points assigned to main stats

      //DVC - Level 3
        public Cyclops()
        {
            setName("Cyclops");
            setBaseHealth(300);
            setCurHealth(300);
            setMaxHealth(300);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            //Main stats are out of 60 points
            setBaseStrength(25);
            setModStrength(25);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(25);
            setModDefense(25);
            setBaseResistance(10);
            setModResistance(10);

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = getModStrength();
            return m;
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getHeros();
            Hero target = party[0];

            if (p.getCurrentPartyMembers() == 1)
            {
                return target;
            }

            for (int i = 0; i < (p.getCurrentPartyMembers() - 2); i++)
            {
                if (party[i + 1].getModDefense() < party[i].getModDefense())
                {
                    target = party[i + 1];
                }
            }

            return target;
        }

       /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = getModDefense() * 1;
            setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = getModResistance() * 1;
            setDefendingDefense(dr);

            return dr;
        }


        public override ImageBrush getBrush()
        {
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-uGzhj6YzaeE/VV7pxURiutI/AAAAAAAAAx4/20ls6ETfz-Y/w506-h657/Cyclops.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }
    }
}
