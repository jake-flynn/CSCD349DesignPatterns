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
    class Centaur : Monster
    {
        //this is a Centaur monster, it is a tier 3 level. there are 70 points assigned to main stats

       //DVC - Level 3
        public Centaur()
        {
            setName("Centaur");
            setBaseHealth(300);
            setCurHealth(300);
            setMaxHealth(300);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            //Main stats are out of 70 points
            setBaseStrength(40);
            setModStrength(40);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(15);
            setModDefense(15);
            setBaseResistance(15);
            setModResistance(15);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Centaur.jpg", UriKind.RelativeOrAbsolute));
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

        //Trample - Strong hit to two heroes
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();
            String message = "";
            int damage = 0;

          //Attack 1
            int randomHero = new Random().Next(theParty.getCurrentPartyMembers() + 1);

            damage = mon.getModStrength() - party[randomHero].getModDefense();
            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            message += mon.getName() + " trampled " + party[randomHero].getName() + " for " + damage + " damage!\r\n";

            //Add Delay for random number generation
            Thread.Sleep(500);

          //Attack 2
            randomHero = new Random().Next(theParty.getCurrentPartyMembers() + 1);

            damage = mon.getModStrength() - party[randomHero].getModDefense();
            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            message += mon.getName() + " trampled " + party[randomHero].getName() + " for " + damage + " damage!\r\n";

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
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
            int dd = base.getModDefense() * 1;
            base.setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = base.getModResistance() * 1;
            base.setDefendingDefense(dr);

            return dr;
        }


        //public override ImageBrush getBrush()
        //{
        //    ImageBrush imgBrush = new ImageBrush();
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-XVplx0kyrLU/VV7slSv3AGI/AAAAAAAAA6M/PEHwBRJdp48/w506-h610/Centaure.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Centaur();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
