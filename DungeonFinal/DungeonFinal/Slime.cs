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
    class Slime : Monster
    {
        Random _randomNumber;

       //DVC - Level 1
        public Slime()
        {
            setName("Slime");

           //Stats
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(14);
            setModMagic(14);
            setBaseDefense(8);
            setModDefense(8);
            setBaseResistance(8);
            setModResistance(8);

           //Special Attack
            setSpecialAttackFrequency(3);

           //Attack
            setIsPhysical(false);
            setIsDefeated(false);

           //Defend
            setIsDefending(false);
            setDefendingDefense(this.getDefendingDefense());
            setDefendingResistance(this.getDefendingResistance());

           //Swarm
            setIsSwarm(true);

           //Identity
            setTierNumber(1);
            setLore("");
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Slime.jpg", UriKind.RelativeOrAbsolute));
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

        //Toxic Ooze - Chance of either poison, paralyze, or burn
        public override String PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        {
            Hero[] party = theParty.getAliveHeroes();

            int randomHero = _randomNumber.Next(party.Length);
            int chance = _randomNumber.Next(4);
            String message = mon.getName() + " slung toxic ooze at the party!\r\n";
            int damage = mon.getModMagic() - party[randomHero].getModResistance();

            //Poison
            if (chance == 1)
            {
                message += "It poisoned " + party[randomHero].getName() + " and caused " + damage + " damage!\r\n";
                party[randomHero].Subscribe(new Poison(party[randomHero]));
            }

            //Paralyze
            else if (chance == 2)
            {
                message += "It stunned " + party[randomHero].getName() + " and caused " + damage + " damage!\r\n";
                party[randomHero].Subscribe(new Stun(party[randomHero]));
            }

            //Burn
            else
            {
                message += "It burned " + party[randomHero].getName() + " for " + damage + " damage each!\r\n";
                party[randomHero].Subscribe(new Burn(party[randomHero]));
            }

            party[randomHero].setCurHealth(party[randomHero].getCurHealth() - damage);
            mon.setCurMana(mon.getCurMana() - 10);

            return message;
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
        //    BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-Yxkfp_admMs/VV7t2dwTwEI/AAAAAAAAA9k/T6d-8bOC_uU/w506-h360/Slime.jpg"));
        //    imgBrush.ImageSource = image;
        //    return imgBrush;
        //}

        public override Object Clone(int count)
        {
            Monster newMon = new Slime();
            newMon.setName(newMon.getName() + " " + count);
            newMon.modifyStats();
            return newMon;
        }
    }
}
