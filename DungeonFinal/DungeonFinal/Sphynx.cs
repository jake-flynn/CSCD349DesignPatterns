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
    class Sphynx : Monster
    {

       //DVC - Level 2
        public Sphynx()
        {
            setName("Sphynx");
            setBaseHealth(200);
            setCurHealth(200);
            setMaxHealth(200);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            //Main stats are out of 50 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(20);
            setModMagic(20);
            setBaseDefense(15);
            setModDefense(15);
            setBaseResistance(15);
            setModResistance(15);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(false);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(this.getDefendingDefense());
            setDefendingResistance(this.getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Sphynx.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = base.getModMagic();
            return m;
        }

        //Riddle - Asks a riddle, if incorrect the hero's health is halved, if correct the sphynx does no damage
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();

            int randomHero = new Random().Next(theParty.getCurrentPartyMembers() + 1);
            int chance = new Random().Next(5);
            String message = mon.getName() + " asked " + party[randomHero].getName() + " a riddle!\r\n";

            //Riddle Solved (low chance)
            if (chance == 1)
            {
                message += party[randomHero].getName() + " successfully solved the riddle!\r\n";
            }

            //Riddle Unsolved
            else
            {
                message += party[randomHero].getName() + " did not solve the riddle correctly so " + mon.getName() + " attacked " + party[randomHero].getName() + " and halved their health!\r\n";
            }

            party[randomHero].setCurHealth((int)(party[randomHero].getCurHealth() / 2));
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
                if(party[i + 1].getCurHealth() < party[i].getCurHealth())
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-VhVoLwooRXk/VV7qD-Xj7vI/AAAAAAAAA0o/x6HtA5ZPXto/s506/Sphinx.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Sphynx();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
