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

           //Stats
            setBaseHealth(300);
            setCurHealth(300);
            setMaxHealth(300);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(45);
            setModMagic(45);
            setBaseDefense(10);
            setModDefense(10);
            setBaseResistance(15);
            setModResistance(15);

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
            setTierNumber(3);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/DemonWarrior.jpg", UriKind.RelativeOrAbsolute));
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

        //Possession - Makes one hero use their special attack for the monster or against the heroes
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = new Random().Next(party.Length);
            party[randomHero].setModStrength(getModStrength() - 1);
            party[randomHero].setModMagic(getModStrength() - 1);

            mon.setCurMana(mon.getCurMana() - 10);

            return (getName() + " cast a curse on " + party[randomHero].getName() + " for -1 Strength and Magic!/r/n");
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();
            Hero target = party[0];

            if (party.Length == 1)
            {
                return target;
            }

            for (int i = 0; i < (party.Length - 2); i++)
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

        //public override ImageBrush getBrush()
        //{
        //    ImageBrush imgBrush = new ImageBrush();
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-FTexFDrdCJA/VV7tsSE9HTI/AAAAAAAAA70/1Yj6DCXT3fM/w506-h620/DemonWarrior.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new DemonWarrior();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
