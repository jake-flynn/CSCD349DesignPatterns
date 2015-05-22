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
    class Hydra : Monster
    {
        //this is a Hydra monster, it is a boss(tier4) level, there are 80 points assigned to main stats

       //DVC - Boss Level
        public Hydra()
        {
            setName("Hydra");
            setBaseHealth(400);
            setCurHealth(400);
            setMaxHealth(400);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            //Main stats are out of 80 points
            setBaseStrength(35);
            setModStrength(35);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(35);
            setModDefense(35);
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
            int rnd1 = new Random().Next(1, 3);
            Hero target = party[0];

            if (rnd1 == 1)
            {
                int rnd2 = new Random().Next(1, party.Length);
                target = party[rnd2];
            }

            else if (rnd1 == 2)
            {
                if (p.getCurrentPartyMembers() == 1)
                {
                    return target;
                }

                for (int i = 0; i < (p.getCurrentPartyMembers() - 2); i++)
                {
                    if (party[i + 1].getModHealth() < party[i].getModHealth())
                    {
                        target = party[i + 1];
                    }
                }
            }

            else if (rnd1 == 3)
            {
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
            BitmapImage image = new BitmapImage(new Uri(@""));
            imgBrush.ImageSource = image;
            return imgBrush;
        }
    }
}
