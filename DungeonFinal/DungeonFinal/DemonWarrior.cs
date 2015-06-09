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
    class DemonWarrior : Monster
    {
        //this is a Demon Warrior monster, it is a tier 3 level, there are 70 points assigned to main stats
        Random _randomNumber;
      //DVC - Level 3
        public DemonWarrior()
        {
            setName("Demon Warrior");
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(340);
            setCurHealth(340);
            setMaxHealth(340);
            setBaseMana(300);
            setCurMana(300);
            setMaxMana(300);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(45);
            setModMagic(45);
            setBaseDefense(6);
            setModDefense(6);
            setBaseResistance(18);
            setModResistance(18);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(false);
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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/DemonWarrior.jpg", UriKind.RelativeOrAbsolute));
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

        //Possession - Makes one hero use their special attack for the monster or against the heroes
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();
            int randomHeroPossession = _randomNumber.Next(party.Length);
            int randomHeroTarget;
            int damage;

            //Target must not be the same as the possessed hero
            do
            {
                randomHeroTarget = _randomNumber.Next(party.Length);
            } while (randomHeroTarget == randomHeroPossession);
            
            //Determine attack type/defense type of heroes
            if(party[randomHeroPossession].getIsPhysical() == true)
            {
                damage = party[randomHeroPossession].getModStrength() - party[randomHeroTarget].getModDefense();
            }

            else
            {
                damage = party[randomHeroPossession].getModMagic() - party[randomHeroTarget].getModResistance();
            }
            
            mon.setCurMana(mon.getCurMana() - 10);

            return (getName() + " possessed " + party[randomHeroPossession].getName() + " and in their thrall they attacked " + party[randomHeroTarget].getName() + " for " + damage + " damage!/r/n");
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
            Monster newMon = new DemonWarrior();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
