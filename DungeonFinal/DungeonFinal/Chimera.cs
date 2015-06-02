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

           //Stats
            setBaseHealth(400);
            setCurHealth(400);
            setMaxHealth(400);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(50);
            setModMagic(50);
            setBaseDefense(15);
            setModDefense(15);
            setBaseResistance(25);
            setModResistance(25);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(false);
            setIsDefeated(false);

           //Defend
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

           //Swarm
            setIsSwarm(false);

           //Identity
            setTierNumber(4);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Chimera.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
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
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = new Random().Next(party.Length);
            int chance = new Random().Next(4);
            String message = "";
            int damage = mon.getModMagic() - party[randomHero].getModResistance();

            //Poison
            if(chance == 1)
            {
                message += mon.getName() + " poisoned " + party[randomHero].getName() + " and caused " + damage + " damage!\r\n";
                party[randomHero].Subscribe(new Poison(party[randomHero]));
            }

            //Bleed
            else if(chance == 2)
            {
                message += mon.getName() + " inflicting bleeding on " + party[randomHero].getName() + " and caused " + damage + " damage!\r\n";
                party[randomHero].Subscribe(new Bleed(party[randomHero]));
            }

            //Muli-hit
            else
            {
                damage = damage * 3;
                message += mon.getName() + " used its three heads to hit " + party[randomHero].getName() + " for " + damage + " damage each!\r\n";
            }

            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            mon.setCurMana(mon.getCurMana() - 10);

            return message;
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();
            int attackType = new Random().Next(1, 3);
            Hero target = party[0];

            //Tier 1 FindTarget
            if (attackType == 1)
            {
                int randomHero = new Random().Next(1, party.Length);
                target = party[randomHero];
            }

           //Tier 2 FindTarget
            else if (attackType == 2)
            {
                if (party.Length == 1)
                {
                    return target;
                }

                for (int i = 0; i < (party.Length - 2); i++)
                {
                    if (party[i + 1].getCurHealth() < party[i].getCurHealth())
                    {
                        target = party[i + 1];
                    }
                }
            }

           //Tier 3 FindTarget
            else if (attackType == 3)
            {
                if (party.Length == 1)
                {
                    return target;
                }

                for (int i = 0; i < (party.Length - 2); i++)
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

        //public override ImageBrush getBrush()
        //{
        //    ImageBrush imgBrush = new ImageBrush();
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-XRLJnocoYoo/VV7phpd8YyI/AAAAAAAAAwM/shtg5O-nCZU/w506-h378/Chimera.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Chimera();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
