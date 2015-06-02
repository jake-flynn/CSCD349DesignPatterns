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
    class Werewolf : Monster
    {

       //DVC - Level 2
        public Werewolf()
        {
            setName("Werewolf");

           //Stats
            setBaseHealth(200);
            setCurHealth(200);
            setMaxHealth(200);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            setBaseStrength(40);
            setModStrength(40);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(10);
            setModDefense(10);
            setBaseResistance(0);
            setModResistance(0);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(true);
            setIsDefeated(false);

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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Werewolf.jpg", UriKind.RelativeOrAbsolute));
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

        //Howl - Increases strength by 50% (can stack)
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            int strInc = mon.getModStrength() * 2;
            mon.setModStrength(strInc);

            mon.setCurMana(mon.getCurMana() - 10);

            return (mon.getName() + " howled at the moon and increased its strength to " + strInc + "!\r\n");
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
                if (party[i + 1].getCurHealth() < party[i].getCurHealth())
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-usr8K7gENyQ/VV7uGiaF6XI/AAAAAAAAA-I/tgOIuaxFa-w/w506-h475/werewolf.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Werewolf();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
