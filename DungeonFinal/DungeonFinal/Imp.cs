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
    class Imp : Monster
    {
        //this is a Imp monster, it is a tier 1 level, there are 30 points assigned to main stats

      //DVC - Level 1
        public Imp()
        {
            setName("Imp");
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            //Main stats are out of 30 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(20);
            setModMagic(20);
            setBaseDefense(10);
            setModDefense(10);
            setBaseResistance(0);
            setModResistance(0);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(false);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Imp.jpg", UriKind.RelativeOrAbsolute));
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

        //Spear - hits 3 random targets at .75 magic
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();
            String message = "";
            int damage = 0;
            int hit = (int)(mon.getModMagic() * .75);
            int randomHero = 0;

            for (int numStrikes = 3; numStrikes > 0; numStrikes--)
            {
                randomHero = new Random().Next(theParty.getCurrentPartyMembers() + 1);
                damage = party[randomHero].getModResistance() - hit;
                party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);

                message += mon.getName() + " stabbed " + party[randomHero].getName() + " for " + damage + " damage!\r\n";
                
                //Add Delay for random number generation
                Thread.Sleep(500);
            }

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getHeros();
            Hero target = null;
            do
            {
                int rnd = new Random().Next(1, party.Length);
                target = party[rnd];
            } while (target.getIsDefeated());
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-7jcsUJBVQYg/VV7tvx6tHeI/AAAAAAAAA8Y/4T5z5QnuLfM/w506-h501/Imp.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Imp();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
