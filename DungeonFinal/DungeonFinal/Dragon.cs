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
    class Dragon : Monster
    {

        //this is a Dragon monster, it is a boss(tier4) level, there are 90 points assigned to main stats
        Random _randomNumber;
      //DVC - Boss Level
        public Dragon()
        {
            setName("Dragon");

           //Stats
            setBaseHealth(500);
            setCurHealth(500);
            setMaxHealth(500);
            setBaseMana(400);
            setCurMana(400);
            setMaxMana(400);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(50);
            setModMagic(50);
            setBaseDefense(25);
            setModDefense(25);
            setBaseResistance(25);
            setModResistance(25);

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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Dragon.jpg", UriKind.RelativeOrAbsolute));
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

        //HellFire - Attacks whole party, chance of burn
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();
            String message = mon.getName() + " spit hellfire at the party!\r\n";
            int damage = 0;

            foreach (Hero h in party)
            {
                int chance = _randomNumber.Next(4);
                damage = mon.getModMagic() - h.getModResistance();
                h.setCurHealth(h.getCurHealth() - damage);

                //Burn Successful
                if(chance == 1)
                {
                    message += "Hellfire affected " + h.getName() + " for " + damage + " damage and they suffered a burn!\r\n";
                    h.Subscribe(new Burn(h));
                }

                //Silence Successful
                else if(chance == 2)
                {
                    message += "Dragon roars at " + h.getName() + " for " + damage + " damage and they were silenced!\r\n";
                    h.Subscribe(new Silence(h));
                }

                //Burn Unuccessful
                else
                {
                    message += "Hellfire affected " + h.getName() + " for " + damage + " damage!\r\n";
                }
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
            Monster newMon = new Dragon();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
