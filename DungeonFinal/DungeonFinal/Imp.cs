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
    class Imp : Monster
    {
        //this is a Imp monster, it is a tier 1 level, there are 30 points assigned to main stats
        Random _randomNumber;

      //DVC - Level 1
        public Imp()
        {
            setName("Imp");
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(150);
            setCurHealth(150);
            setMaxHealth(150);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(30);
            setModMagic(30);
            setBaseDefense(7);
            setModDefense(7);
            setBaseResistance(9);
            setModResistance(9);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(false);
            setIsDefeated(false);
            setFindTargetBahvior(new FindTarget_Tier1Behavior());

           //Defend
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

           //Swarm
            setIsSwarm(false);

           //Identity
            setTierNumber(1);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Imp.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = getModMagic();
            return m;
        }

        //Spear - hits 3 random targets at .75 magic
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();
            String message = "";
            int damage = 0;
            int hit = (int)(mon.getModMagic() * .75);
            int randomHero = 0;

            for (int numStrikes = 3; numStrikes > 0; numStrikes--)
            {
                randomHero = _randomNumber.Next(party.Length);
                damage = hit - party[randomHero].getModResistance();

                if (damage < 0)
                {
                    damage = 0;
                }

                party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);

                message += mon.getName() + " stabbed " + party[randomHero].getName() + " for " + damage + " damage!\r\n";                                
            }

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
            Monster newMon = new Imp();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
