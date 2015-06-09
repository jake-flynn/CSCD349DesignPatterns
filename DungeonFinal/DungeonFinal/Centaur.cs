using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    class Centaur : Monster
    {
        //this is a Centaur monster, it is a tier 3 level. there are 70 points assigned to main stats
        Random _randomNumber;

       //DVC - Level 3
        public Centaur()
        {
            setName("Centaur");

           //Stats
            setBaseHealth(325);
            setCurHealth(325);
            setMaxHealth(325);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            setBaseStrength(40);
            setModStrength(40);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(18);
            setModDefense(18);
            setBaseResistance(6);
            setModResistance(6);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(true);
            setIsDefeated(false);
            setFindTargetBahvior(new FindTarget_Tier3Behavior());

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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Centaur.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
            _randomNumber = RandomGenerator.Instance;
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = getModStrength();
            return m;
        }

        //Trample - Strong hit to two heroes
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();
            String message = "";
            int damage = 0;

          //Attack 1
            int randomHero = _randomNumber.Next(party.Length);

            damage = mon.getModStrength() - party[randomHero].getModDefense();
            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            message += mon.getName() + " trampled " + party[randomHero].getName() + " for " + damage + " damage!\r\n";

            
          //Attack 2
            randomHero = _randomNumber.Next(theParty.getAliveHeroes().Length );

            damage = mon.getModStrength() - party[randomHero].getModDefense();
            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            message += mon.getName() + " trampled " + party[randomHero].getName() + " for " + damage + " damage!\r\n";

            mon.setCurMana(mon.getCurMana() - 10);

            return message;
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

        public override Object Clone(int count)
        {
            Monster newMon = new Centaur();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
