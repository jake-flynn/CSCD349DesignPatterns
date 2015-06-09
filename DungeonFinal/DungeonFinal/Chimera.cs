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
    class Chimera : Monster
    {
        Random _randomNumber;
        //this is a chimera monster, it is a boss(tier4) level, there are 90 points assigned to main stats

      //DVC - Boss Level
        public Chimera()
        {
            setName("Chimera");

           //Stats
            setBaseHealth(435);
            setCurHealth(435);
            setMaxHealth(435);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(58);
            setModMagic(58);
            setBaseDefense(14);
            setModDefense(14);
            setBaseResistance(23);
            setModResistance(23);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(false);
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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Chimera.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
            _randomNumber = RandomGenerator.Instance;
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = getModMagic();
            return m;
        }

        //TriStrike - Chance of poison, chance of bleed, and chance of multiple hits
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = _randomNumber.Next(party.Length);
            int chance = _randomNumber.Next(4);
            String message = "";
            int damage = mon.getModMagic() - party[randomHero].getModResistance();

            //Poison
            if(chance == 1)
            {
                message += mon.getName() + " poisoned " + party[randomHero].getName() + " and caused " + damage + " damage!\r\n";
                party[randomHero].Subscribe(new Poison(party[randomHero]));
            }

            //Bleed
            else if(chance == 2)
            {
                message += mon.getName() + " inflicting bleeding on " + party[randomHero].getName() + " and caused " + damage + " damage!\r\n";
                party[randomHero].Subscribe(new Bleed(party[randomHero]));
            }

            //Critical-hit
            else
            {
                damage = damage * 3;
                message += mon.getName() + " used its three heads to hit " + party[randomHero].getName() + " for " + damage + " damage each!\r\n";
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
            Monster newMon = new Chimera();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
