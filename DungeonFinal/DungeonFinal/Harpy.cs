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
    class Harpy : Monster
    {
        //this is a Harpy monster, it is a tier 2 level, there are 50 points assigned to main stats
        Random _randomNumber;

       //DVC - Level 2
        public Harpy()
        {
            setName("Harpy");
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(240);
            setCurHealth(240);
            setMaxHealth(240);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(35);
            setModMagic(35);
            setBaseDefense(9);
            setModDefense(9);
            setBaseResistance(16);
            setModResistance(16);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(false);
            setIsDefeated(false);
            setFindTargetBahvior(new FindTarget_Tier2Behavior());

           //Defend
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());

           //Swarm
            setIsSwarm(false);

           //Identity
            setTierNumber(2);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Harpy.jpg", UriKind.RelativeOrAbsolute));
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

        //Screech - Attacks whole party for .75 damage and chance of paralyzation
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();
            String message = mon.getName() + " uttered an ear piercing screech!\r\n";
            int damage = 0;

            foreach (Hero h in party)
            {
                int chance = _randomNumber.Next(3);
                damage = mon.getModMagic() - h.getModResistance();
                h.setCurHealth(h.getCurHealth() - damage);

                //Paralyze Successful
                if (chance == 1)
                {
                    message += "Screech affected " + h.getName() + " for " + damage + " damage and they were stunned!\r\n";
                    h.Subscribe(new Stun(h));
                }

                //Lockdown Successful
                else if(chance == 2)
                {
                    message += "Screech affected " + h.getName() + " for " + damage + " damage and they were silenced!\r\n";
                    h.Subscribe(new Silence(h));
                }

                //Paralyze/Lockdown Unuccessful
                else
                {
                    message += "Screech affected " + h.getName() + " for " + damage + " damage!\r\n";
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
            Monster newMon = new Harpy();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
