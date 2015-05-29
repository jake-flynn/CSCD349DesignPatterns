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
    class Skeleton : Monster
    {

       //DVC - Level 1
        public Skeleton()
        {
            setName("Skeleton");
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            //Main stats are out of 20 points
            setBaseStrength(8);
            setModStrength(8);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(10);
            setModDefense(10);
            setBaseResistance(2);
            setModResistance(2);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(this.getDefendingDefense());
            setDefendingResistance(this.getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Skeleton.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = base.getModStrength();
            return m;
        }

        //Bone Toss/Bonerang - Decreasing chance of hitting all heroes, guarenteed one hit (.75 strength)
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();

            int chance = new Random().Next(4);
            String message = mon.getName() + " threw its bonerang!\r\n";
            int damage = 0;
            int hit = (int)(mon.getModStrength() * .75);
            int numStrikes = 0;

            //Attack 1 member
            if(chance == 0)
            {
                numStrikes = 0;
            }

            //Attack 2 members
            else if(chance == 1)
            {
                numStrikes = 1;
            }

            //Attack 3 members
            else if(chance == 2)
            {
                numStrikes = 2;
            }

            //Attack all 4 members
            else
            {
                numStrikes = 3;
            }

            for (; numStrikes >= 0; numStrikes--)
            {
                damage = hit - party[numStrikes].getModDefense();
                party[numStrikes].setCurHealth(party[numStrikes].getCurHealth() - damage);

                message += "The bonerang hit " + party[numStrikes].getName() + " for " + damage + " damage!\r\n";
            }

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getHeros();

            int rnd = new Random().Next(1, party.Length);
            Hero target = party[rnd];

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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-rk3imOftLac/VV7r1o8jAXI/AAAAAAAAA40/hmgZOFZTBTg/w506-h600/Skeleton.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Skeleton();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
