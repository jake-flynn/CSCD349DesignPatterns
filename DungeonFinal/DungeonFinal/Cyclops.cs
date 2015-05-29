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
            setBaseHealth(300);
            setCurHealth(300);
            setMaxHealth(300);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            //Main stats are out of 70 points
            setBaseStrength(35);
            setModStrength(35);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(25);
            setModDefense(25);
            setBaseResistance(10);
            setModResistance(10);

            setSpecialAttackFrequency(3);

            setLore("");

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());
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
            Hero[] party = theParty.getHeros();

            int rnd = new Random().Next(theParty.getCurrentPartyMembers() + 1);
            int chance = new Random().Next(3);
            String message = "";
            int damage = mon.getModStrength() - party[rnd].getModDefense();

            //Paralyze successful
            if(chance == 1)
            {
                message += mon.getName() + "threw Zeus' thunderbolt at " + party[rnd].getName() + " for " + damage + " damage caused paralyzation!\r\n";
            }

            //Paralyze unsuccessful
            else
            {
                message += mon.getName() + "threw Zeus' thunderbolt at " + party[rnd].getName() + " for " + damage + " damage!\r\n";
            }

            party[rnd].setCurHealth(party[rnd].getCurHealth() - damage);
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


        public override ImageBrush getBrush()
        {
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-uGzhj6YzaeE/VV7pxURiutI/AAAAAAAAAx4/20ls6ETfz-Y/w506-h657/Cyclops.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }

        public override Object Clone(int count)
        {
            Monster newMon = new Cyclops();
            newMon.setName(newMon.getName() + " " + count);
            return newMon;
        }
    }
}
