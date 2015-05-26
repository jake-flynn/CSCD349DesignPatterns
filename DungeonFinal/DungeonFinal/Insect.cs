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

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setIsSwarm(true);
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

        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getHeros();

            int rnd = new Random().Next(theParty.getCurrentPartyMembers() + 1);
            party[rnd].setModStrength(getModStrength() - 1);
            party[rnd].setModMagic(getModStrength() - 1);

            return (getName() + "cast a curse on " + party[rnd].getName() + " for -1 Strength and Magic!");
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


        public override ImageBrush getBrush()
        {
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-w_yBMwFv0so/VV7typ5i0xI/AAAAAAAAA88/5b7Z6EE0eSk/w506-h438/Insect.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }

        public override Object Clone(int count)
        {
            Monster newMon = new Insect();
            newMon.setName(newMon.getName() + " " + count);
            return newMon;
        }
    }
}
