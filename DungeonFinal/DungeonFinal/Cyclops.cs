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
    class Cyclops : Monster
    {
        //this is a Cyclops monster, it is a tier 3 level, there are 70 points assigned to main stats

      //DVC - Level 3
        public Cyclops()
        {
            setName("Cyclops");

           //Stats
            setBaseHealth(300);
            setCurHealth(300);
            setMaxHealth(300);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            setBaseStrength(35);
            setModStrength(35);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(25);
            setModDefense(25);
            setBaseResistance(10);
            setModResistance(10);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(true);
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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Cyclops.jpg", UriKind.RelativeOrAbsolute));
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

        //Thunderbolt - chance of paralyze
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = new Random().Next(party.Length);
            int chance = new Random().Next(3);
            String message = "";
            int damage = mon.getModStrength() - party[randomHero].getModDefense();

            //Paralyze successful
            if(chance == 1)
            {
                message += mon.getName() + " threw Zeus' thunderbolt at " + party[randomHero].getName() + " for " + damage + " damage caused paralyzation!\r\n";
                party[randomHero].Subscribe(new Stun(party[randomHero]));
            }

            //Paralyze unsuccessful
            else
            {
                message += mon.getName() + " threw Zeus' thunderbolt at " + party[randomHero].getName() + " for " + damage + " damage!\r\n";
            }

            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            mon.setCurMana(mon.getCurMana() - 10);

            return message;
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-uGzhj6YzaeE/VV7pxURiutI/AAAAAAAAAx4/20ls6ETfz-Y/w506-h657/Cyclops.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Cyclops();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
