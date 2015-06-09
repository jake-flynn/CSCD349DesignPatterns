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
    class Minotaur : Monster
    {
        //this is a Minotaur monster, it is a boss(tier4) level, there are 90 points assigned to main stats
        Random _randomNumber;

      //DVC - Boss Level
        public Minotaur()
        {
            setName("Minotaur");
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(440);
            setCurHealth(440);
            setMaxHealth(440);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            setBaseStrength(72);
            setModStrength(72);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(23);
            setModDefense(23);
            setBaseResistance(14);
            setModResistance(14);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(true);
            setIsDefeated(false);
            setFindTargetBahvior(new FindTarget_Tier4Behavior());

           //Defend
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

           //Swarm
            setIsSwarm(false);

           //Identity
            setTierNumber(4);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Minotaur.jpg", UriKind.RelativeOrAbsolute));
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

        //Skull Bash - Chance of paralyze, strong hit to one hero
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = _randomNumber.Next(party.Length);
            int chance = _randomNumber.Next(3);
            String message = "";
            int damage = (int)(mon.getModStrength() * 1.5) - party[randomHero].getModDefense();

            //Stun Successful
            if (chance == 1)
            {
                message += mon.getName() + " hit " + party[randomHero].getName() + " with its axe for " + damage + " damage and caused paralyzation!\r\n";
                party[randomHero].Subscribe(new Stun(party[randomHero]));
            }

            //Stun Unsuccessful
            else
            {
                message += mon.getName() + " hit " + party[randomHero].getName() + " with its axe and caused " + damage + " damage!\r\n";
            }

            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            mon.setCurMana(mon.getCurMana() - 10);

            return message;
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
            Monster newMon = new Minotaur();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
