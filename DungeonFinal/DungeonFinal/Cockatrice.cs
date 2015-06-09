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
    class Cockatrice : Monster
    {
        Random _randomNumber;
        //this is a Cockatrice monster, it is a tier 2 level, there are 50 points assigned to main stats

      //DVC - Level 2
        public Cockatrice()
        {
            setName("Cockatrice");
            _randomNumber = RandomGenerator.Instance;

           //Stats
            setBaseHealth(205);
            setCurHealth(205);
            setMaxHealth(205);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(32);
            setModMagic(32);
            setBaseDefense(3);
            setModDefense(3);
            setBaseResistance(7);
            setModResistance(7);

           //Special Attack
            setSpecialAttackFrequency(1);

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
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Cockatrice.jpg", UriKind.RelativeOrAbsolute));
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

        //Death Stare - instantly kills a hero
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAllHeroes();

            int rnd = _randomNumber.Next(theParty.getAliveHeroes().Length);

            party[rnd].setCurHealth(0);

            mon.setCurMana(mon.getCurMana() - 10);

            return (mon.getName() + " caught " + party[rnd].getName() + "'s gaze. " + party[rnd].getName() + " was instantly killed!\r\n");
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
            Monster newMon = new Cockatrice();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
