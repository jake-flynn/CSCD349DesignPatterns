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
    class Chimera : Monster
    {
        
        //this is a chimera monster, it is a boss(tier4) level, there are 90 points assigned to main stats

      //DVC - Boss Level
        public Chimera()
        {
            setName("Chimera");
            setBaseHealth(400);
            setCurHealth(400);
            setMaxHealth(400);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            //Main stats are out of 90 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(50);
            setModMagic(50);
            setBaseDefense(15);
            setModDefense(15);
            setBaseResistance(25);
            setModResistance(25);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(false);
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
            int m = getModMagic();
            return m;
        }

        //TriStrike - Chance of poison, chance of bleed, and chance of multiple hits
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();

            int rnd = new Random().Next(theParty.getCurrentPartyMembers() + 1);
            int chance = new Random().Next(4);
            String message = "";
            int damage = mon.getModMagic() - party[rnd].getModResistance();

            //Poison
            if(chance == 1)
            {
                message += mon.getName() + "poisoned " + party[rnd].getName() + " and caused " + damage + " damage!\r\n";
            }

            //Bleed
            else if(chance == 2)
            {
                message += mon.getName() + "inflicting bleeding on " + party[rnd].getName() + " and caused " + damage + " damage!\r\n";
            }

            //Muli-hit
            else
            {
                damage = damage * 3;
                message += mon.getName() + "used its three heads to hit " + party[rnd].getName() + " for " + damage + " damage each!\r\n";
            }

            party[rnd].setCurHealth(party[rnd].getCurHealth() - damage);
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
                    if (party[i + 1].getModResistance() < party[i].getModResistance())
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
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-XRLJnocoYoo/VV7phpd8YyI/AAAAAAAAAwM/shtg5O-nCZU/w506-h378/Chimera.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }

        public override Object Clone(int count)
        {
            Monster newMon = new Chimera();
            newMon.setName(newMon.getName() + " " + count);
            return newMon;
        }
    }
}
