﻿using System;
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
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(415);
            setCurHealth(415);
            setMaxHealth(415);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            setBaseStrength(52);
            setModStrength(52);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(18);
            setModDefense(18);
            setBaseResistance(14);
            setModResistance(14);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(true);
            setIsDefeated(false);
            setFindTargetBahvior(new FindTarget_Tier4Behavior());

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

                if (damage < 0)
                {
                    damage = 0;
                }

                party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);

                message += mon.getName() + " bit " + party[randomHero].getName() + " for " + damage + " damage!\r\n";

                //Add Delay for random number generation
                Thread.Sleep(500);
            }

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
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

        public override Object Clone(int count)
        {
            Monster newMon = new Hydra();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
