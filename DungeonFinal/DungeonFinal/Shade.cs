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
    class Shade : Monster
    {
        //this is a Shade monster, it is a tier 1 level, there are 30 points assigned to main stats
        Random _randomNumber;
       //DVC - Level 1
        public Shade()
        {
            setName("Shade");

           //Stats
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(20);
            setModMagic(20);
            setBaseDefense(0);
            setModDefense(0);
            setBaseResistance(10);
            setModResistance(10);

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
            setTierNumber(1);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Shade.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
            _randomNumber = RandomGenerator.Instance;
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {

            int m = base.getModMagic();

            return m;
        }

        //Curse - Debuffs one hero with -1 magic and -1 strength
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = _randomNumber.Next(party.Length);

            party[randomHero].Subscribe(new Curse(party[randomHero]));

            mon.setCurMana(mon.getCurMana() - 10);

            return (getName() + " cast a curse on " + party[randomHero].getName() + " reducing their strength and magic stats!");
        }

        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getAliveHeroes();

            int randomHero = _randomNumber.Next(1, party.Length);
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-EKQKgVnW8YE/VV7rA5Vn4pI/AAAAAAAAA2k/kosHQJsMjYs/w506-h571/shade.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Shade();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
