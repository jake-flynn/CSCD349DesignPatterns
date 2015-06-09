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
    class Hellhound : Monster
    {
        //this is a Hellhound monster, it is a tier 2 level, there are 50 points assigned to main stats
        Random _randomNumber;

       //DVC - Level 2
        public Hellhound()
        {
            setName("Hellhound");
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(220);
            setCurHealth(220);
            setMaxHealth(200);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            setBaseStrength(42);
            setModStrength(42);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(12);
            setModDefense(12);
            setBaseResistance(12);
            setModResistance(12);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(true);
            setIsDefeated(false);
            setFindTargetBahvior(new FindTarget_Tier2Behavior());

           //Defend
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

           //Swarm
            setIsSwarm(true);

           //Identity
            setTierNumber(2);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Hellhound.jpg", UriKind.RelativeOrAbsolute));
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

        //Firemaw - Chance of burn
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = _randomNumber.Next(party.Length);
            int chance = _randomNumber.Next(3);
            String message = "";
            int damage = mon.getModStrength() - party[randomHero].getModDefense();

            //Burn Successful
            if (chance == 1)
            {
                message += mon.getName() + " bit " + party[randomHero].getName() + " for " + damage + " damage and caused a burn!\r\n";
                party[randomHero].Subscribe(new Burn(party[randomHero]));
            }

            //Burn Unsuccessful
            else
            {
                message += mon.getName() + " bit " + party[randomHero].getName() + " and caused " + damage + " damage!\r\n";
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
            Monster newMon = new Hellhound();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
