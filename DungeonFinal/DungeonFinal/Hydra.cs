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
        //this is a Hydra monster, it is a boss(tier4) level, there are 90 points assigned to main stats

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

            //Main stats are out of 90 points
            setBaseStrength(45);
            setModStrength(45);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(35);
            setModDefense(35);
            setBaseResistance(10);
            setModResistance(10);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
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

        //Feast - At 100% health 3 random attacks at .75 damage, 50% health 6 random attacks at .75 damage, 10% health 9 random attacks at .75 damage
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();
            String message = "";
            int damage = 0;
            int hit = (int)(mon.getModStrength() * .75);
            int numStrikes = 0;

            //3 Attacks
            if(mon.getCurHealth() > (mon.getMaxHealth() / 2))
            {
                numStrikes = 3;
            }

            //6 Attacks
            else if (mon.getCurHealth() <= (mon.getMaxHealth() / 2) && mon.getCurHealth() < (mon.getMaxHealth() / 10))
            {
                numStrikes = 6;
            }

            //9 attacks
            else
            {
                numStrikes = 9;
            }

            for(; numStrikes > 0; numStrikes--)
            {
                int rnd = new Random().Next(theParty.getCurrentPartyMembers() + 1);
                damage = party[rnd].getModDefense() - hit;
                party[rnd].setCurHealth(party[rnd].getCurHealth() - damage);

                message += mon.getName() + "bit " + party[rnd].getName() + " for " + damage + " damage!\r\n";
            }

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
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
                    if (party[i + 1].getCurHealth() < party[i].getCurHealth())
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
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-T74w4DDP3o8/VV7p3uiRWmI/AAAAAAAAAyc/fPgfCd9bFuI/w506-h372/Hydra.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }

        public override Object Clone(int count)
        {
            Monster newMon = new Hydra();
            newMon.setName(newMon.getName() + " " + count);
            return newMon;
        }
    }
}
