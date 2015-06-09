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
        Random _randomNumber;

       //DVC - Level 2
        public Sphynx()
        {
            setName("Sphynx");
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(230);
            setCurHealth(230);
            setMaxHealth(230);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(36);
            setModMagic(36);
            setBaseDefense(4);
            setModDefense(4);
            setBaseResistance(12);
            setModResistance(12);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(false);
            setIsDefeated(false);
            setFindTargetBahvior(new FindTarget_Tier2Behavior());

           //Defend
            setIsDefending(false);
            setDefendingDefense(this.getDefendingDefense());
            setDefendingResistance(this.getDefendingResistance());

           //Swarm
            setIsSwarm(false);

           //Identity
            setTierNumber(2);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Sphynx.jpg", UriKind.RelativeOrAbsolute));
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
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = _randomNumber.Next(party.Length);
            int chance = _randomNumber.Next(5);
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
