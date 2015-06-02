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
    class Harpy : Monster
    {
        //this is a Harpy monster, it is a tier 2 level, there are 50 points assigned to main stats

       //DVC - Level 2
        public Harpy()
        {
            setName("Harpy");
            setBaseHealth(200);
            setCurHealth(200);
            setMaxHealth(200);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            //Main stats are out of 50 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(30);
            setModMagic(30);
            setBaseDefense(0);
            setModDefense(0);
            setBaseResistance(20);
            setModResistance(20);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(false);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());


            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Harpy.jpg", UriKind.RelativeOrAbsolute));
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

        //Screech - Attacks whole party for .75 damage and chance of paralyzation
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();
            String message = mon.getName() + " uttered an ear piercing screech!\r\n";
            int damage = 0;

            foreach (Hero h in party)
            {
                int chance = new Random().Next(3);
                damage = mon.getModMagic() - h.getModResistance();
                h.setCurHealth(h.getCurHealth() - damage);

                //Paralyze Successful
                if (chance == 1)
                {
                    message += "Screech affected " + h.getName() + " for " + damage + " damage and they were stunned!\r\n";
                    h.Subscribe(new Stun(h));
                }

                //Lockdown Successful
                else if(chance == 2)
                {
                    message += "Screech affected " + h.getName() + " for " + damage + " damage and they were silenced!\r\n";
                    h.Subscribe(new Silence(h));
                }

                //Paralyze/Lockdown Unuccessful
                else
                {
                    message += "Screech affected " + h.getName() + " for " + damage + " damage!\r\n";
                }
            }

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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-_lLgljBYD58/VV7rxuXdfTI/AAAAAAAAA4Q/YUClzq2q4b8/w506-h716/Harpy.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Harpy();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
