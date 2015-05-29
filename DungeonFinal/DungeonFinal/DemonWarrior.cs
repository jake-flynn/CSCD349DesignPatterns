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
    class DemonWarrior : Monster
    {
        //this is a Demon Warrior monster, it is a tier 3 level, there are 70 points assigned to main stats

      //DVC - Level 3
        public DemonWarrior()
        {
            setName("Demon Warrior");
            setBaseHealth(300);
            setCurHealth(300);
            setMaxHealth(300);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            //Main stats are out of 70 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(45);
            setModMagic(45);
            setBaseDefense(10);
            setModDefense(10);
            setBaseResistance(15);
            setModResistance(15);

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

        //Possession - Makes one hero use their special attack for the monster or against the heroes
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();

            int rnd = new Random().Next(theParty.getCurrentPartyMembers() + 1);
            party[rnd].setModStrength(getModStrength() - 1);
            party[rnd].setModMagic(getModStrength() - 1);

            mon.setCurMana(mon.getCurMana() - 10);

            return (getName() + "cast a curse on " + party[rnd].getName() + " for -1 Strength and Magic!\r\n");
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
                if (party[i + 1].getModResistance() < party[i].getModResistance())
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
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-FTexFDrdCJA/VV7tsSE9HTI/AAAAAAAAA70/1Yj6DCXT3fM/w506-h620/DemonWarrior.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }

        public override Object Clone(int count)
        {
            Monster newMon = new DemonWarrior();
            newMon.setName(newMon.getName() + " " + count);
            return newMon;
        }
    }
}
