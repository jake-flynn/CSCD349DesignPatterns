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
    class Minotaur : Monster
    {
        //this is a Minotaur monster, it is a boss(tier4) level, there are 90 points assigned to main stats

      //DVC - Boss Level
        public Minotaur()
        {
            setName("Minotaur");

           //Stats
            setBaseHealth(400);
            setCurHealth(400);
            setMaxHealth(400);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            setBaseStrength(65);
            setModStrength(65);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(20);
            setModDefense(20);
            setBaseResistance(5);
            setModResistance(5);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(true);
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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Minotaur.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = getModStrength();
            return m;
        }

        //Skull Bash - Chance of paralyze, strong hit to one hero
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = new Random().Next(party.Length);
            int chance = new Random().Next(3);
            String message = "";
            int damage = (int)(mon.getModStrength() * 1.5) - party[randomHero].getModDefense();

            //Burn Successful
            if (chance == 1)
            {
                message += mon.getName() + " hit " + party[randomHero].getName() + " with its axe for " + damage + " damage and caused paralyzation!\r\n";
                party[randomHero].Subscribe(new Stun(party[randomHero]));
            }

            //Burn Unsuccessful
            else
            {
                message += mon.getName() + " hit " + party[randomHero].getName() + " with its axe and caused " + damage + " damage!\r\n";
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-xdHsXsukV-g/VV7p65aPyoI/AAAAAAAAAy8/0J8MmC77890/w506-h606/Minotar.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Minotaur();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
