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
    class VampireBat : Monster
    {

       //DVC - Level 1
        public VampireBat()
        {
            setName("Vampire Bat");

           //Stats
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            setBaseStrength(25);
            setModStrength(25);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(3);
            setModDefense(3);
            setBaseResistance(2);
            setModResistance(2);

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
            setIsSwarm(true);

           //Identity
            setTierNumber(1);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/VampBat.jpg", UriKind.RelativeOrAbsolute));
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

        //Leech - attacks one hero with strength value, takes that damage and heals by that amount
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = new Random().Next(party.Length);
            int damage = mon.getModStrength() - party[randomHero].getModDefense();

            //Set Damage
            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);

            //Set Health
            mon.setCurHealth(mon.getCurHealth() + damage);

            mon.setCurMana(mon.getCurMana() - 10);

            return (getName() + " sucked " + party[randomHero].getName() + "'s blood for " + damage + " and healed itself!\r\n");
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();

            int randomHero = new Random().Next(1, party.Length);
            Hero target = party[randomHero];

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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-BeewHlzndVE/VV7tPlDwlOI/AAAAAAAAA7I/NoEQR8Yt7P4/w506-h431/vamp%2Bbat.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new VampireBat();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
