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
    class StuBeast : Monster
    {
        //this is a StuBeast monster

       //DVC - Level 2
        public StuBeast()
        {
            setName("Stu, the OS Abomination");

           //Stats
            setBaseHealth(200);
            setCurHealth(200);
            setMaxHealth(200);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            setBaseStrength(20);
            setModStrength(20);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(15);
            setModDefense(15);
            setBaseResistance(15);
            setModResistance(15);
         
           //Special Attack
            setSpecialAttackFrequency(4);

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
            setTierNumber(2);
            setLore("StuBeast is an unholy abomination created from the deepest depths of students' nightmares.\r\n" + 
                    "It is said in whispers that it has a heart of gold, though none have survived to confirm this. \r\n" +
                    "Tough and unforgiving, winning a battle against the StuBeast will ultimately make you stronger.");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Stu.jpg", UriKind.RelativeOrAbsolute));
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

        //Assign homework - does 15 set damage across whole party
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();
            int damage = 15;

            foreach (Hero h in party)
            {
                h.setCurHealth(h.getCurHealth() - damage);
            }

            mon.setCurMana(mon.getCurMana() - 10);

            return ("Stubeast gave the whole party homework, it's due tomorrow! Did " + damage + " across whole party!\r\n");
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


        public override Object Clone(int count)
        {
            Monster newMon = new StuBeast();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
