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
    class Dragon : Monster
    {

        //this is a Dragon monster, it is a boss(tier4) level, there are 90 points assigned to main stats

      //DVC - Boss Level
        public Dragon()
        {
            setName("Dragon");
            setBaseHealth(400);
            setCurHealth(400);
            setMaxHealth(400);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            //Main stats are out of 90 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(40);
            setModMagic(40);
            setBaseDefense(25);
            setModDefense(25);
            setBaseResistance(25);
            setModResistance(25);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(false);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Dragon.jpg", UriKind.RelativeOrAbsolute));
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

        //HellFire - Attacks whole party, chance of burn
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();
            String message = mon.getName() + " spit hellfire at the party!\r\n";
            int damage = 0;

            foreach (Hero h in party)
            {
                int chance = new Random().Next(3);
                damage = mon.getModMagic() - h.getModResistance();
                h.setCurHealth(h.getCurHealth() - damage);

                //Burn Successful
                if(chance == 1)
                {
                    message += "Hellfire affected " + h.getName() + " for " + damage + " damage and they suffered a burn!\r\n";
                    h.Subscribe(new Burn(h));
                }

                //Burn Unuccessful
                else
                {
                    message += "Hellfire affected " + h.getName() + " for " + damage + " damage!\r\n";
                }
            }

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getHeros();
            int rnd1 = new Random().Next(1, 3);
            Hero target = party[0];

            if(rnd1 == 1)
            {
                int rnd2 = new Random().Next(1, party.Length);
                target = party[rnd2];
            }

            else if(rnd1 == 2)
            {
                if (p.getCurrentPartyMembers() == 1)
                {
                    return target;
                }

                for (int i = 0; i < (p.getCurrentPartyMembers() - 2); i++)
                {
                    if (party[i + 1].getCurHealth() < party[i].getCurHealth())
                    {
                        target = party[i + 1];
                    }
                }
            }

            else if(rnd1 == 3)
            {
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-RCnZIMSg8h0/VV7uJz-dFnI/AAAAAAAAA-o/1krgXnhtSVA/w506-h295/Dragon.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Dragon();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
