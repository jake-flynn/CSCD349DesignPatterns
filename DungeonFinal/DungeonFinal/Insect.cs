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
    class Insect : Monster
    {
        //this is a Insect monster, it is a tier 1 level, there are 30 points assigned to main stats

       //DVC - Level 1
        public Insect()
        {
            setName("Insect");
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            //Main stats are out of 30 points
            setBaseStrength(17);
            setModStrength(17);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(7);
            setModDefense(7);
            setBaseResistance(6);
            setModResistance(6);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Insect.jpg", UriKind.RelativeOrAbsolute));
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

        //Poison Spray - attacks two heroes, chance of poison
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();
            String message = "";
            int damage = 0;

          //Attack 1
            int rnd1 = new Random().Next(theParty.getCurrentPartyMembers());
            int chance1 = new Random().Next(3);

            damage = mon.getModStrength() - party[rnd1].getModDefense();
            party[rnd1].setCurHealth(party[rnd1].getCurHealth() - damage);
            
            //Poison Successful
            if(chance1 == 1)
            {
                message += mon.getName() + " sprayed venom at " + party[rnd1].getName() + " for " + damage + " damage and caused poison!\r\n";
                party[rnd1].Subscribe(new Poison(party[rnd1]));
            }

            //Poison Unsuccessful
            else
            {
                message += mon.getName() + " sprayed venom at " + party[rnd1].getName() + " for " + damage + " damage!\r\n";
            }


          //Attack 2
            int rnd2 = new Random().Next(theParty.getCurrentPartyMembers());
            int chance2 = new Random().Next(3);

            damage = mon.getModStrength() - party[rnd2].getModDefense();
            party[rnd2].setCurHealth(party[rnd2].getCurHealth() - damage);

            //Poison Successful
            if (chance2 == 1)
            {
                message += mon.getName() + " sprayed venom at " + party[rnd2].getName() + " for " + damage + " damage and caused poison!\r\n";
                party[rnd2].Subscribe(new Poison(party[rnd2]));
            }

            //Poison Unsuccessful
            else
            {
                message += mon.getName() + " sprayed venom at " + party[rnd2].getName() + " for " + damage + " damage!\r\n";
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-w_yBMwFv0so/VV7typ5i0xI/AAAAAAAAA88/5b7Z6EE0eSk/w506-h438/Insect.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Insect();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
