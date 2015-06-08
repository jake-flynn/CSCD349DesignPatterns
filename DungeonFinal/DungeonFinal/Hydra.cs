using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        Random _randomNumber;
       //DVC - Boss Level
        public Hydra()
        {
            setName("Hydra");

           //Stats
            setBaseHealth(400);
            setCurHealth(400);
            setMaxHealth(400);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            setBaseStrength(45);
            setModStrength(45);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(35);
            setModDefense(35);
            setBaseResistance(10);
            setModResistance(10);

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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Hydra.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
            _randomNumber = RandomGenerator.Instance;
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
            Hero[] party = theParty.getAliveHeroes();
            String message = "";
            int damage = 0;
            int hit = (int)(mon.getModStrength() * .75);
            int numStrikes = 0;
            int randomHero = 0;

            //3 Attacks
            if(mon.getCurHealth() > (mon.getMaxHealth() * .75))
            {
                numStrikes = 3;
            }

            //6 Attacks
            else if (mon.getCurHealth() <= (mon.getMaxHealth() / 2) && mon.getCurHealth() > (mon.getMaxHealth() *.4))
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
                randomHero = _randomNumber.Next(party.Length);
                damage = hit - party[randomHero].getModDefense();
                party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);

                message += mon.getName() + " bit " + party[randomHero].getName() + " for " + damage + " damage!\r\n";

                //Add Delay for random number generation
                Thread.Sleep(500);
            }

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();
            int attackType = _randomNumber.Next(1, 3);
            Hero target = party[0];

           //Tier 1 FindTarget
            if (attackType == 1)
            {
                int randomHero = _randomNumber.Next(1, party.Length);
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-T74w4DDP3o8/VV7p3uiRWmI/AAAAAAAAAyc/fPgfCd9bFuI/w506-h372/Hydra.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Hydra();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
