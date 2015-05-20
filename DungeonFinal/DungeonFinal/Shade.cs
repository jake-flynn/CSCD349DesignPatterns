using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Shade : Monster
    {
        //this is a Shade monster, it is a tier 1 level, there are 20 points assigned to main stats

       
        public Shade()
        {
            setName("Shade");
            setModHealth(100);
            setMana(100);

            //Main stats are out of 20 points
            setStrength(0);
            setMagic(10);
            setDefense(0);
            setResistance(10);

            setIsPhysical(false);

            
            setIsDefending(false);
            setDefendingDefense(getDefendingDefense());
            setDefendingResistance(getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = getMagic();
            return m;
        }

        //public override void PerformSpecialAttack(Party theParty, int whichHero, Monster mon)
        //{
        //    MessageBox.Show("Cast a dark chill!");
        //}
        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getHeros();

            int rnd = new Random().Next(1, party.Length);
            Hero target = party[rnd];

            return target;
        }

       /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = getDefense() * 1;
            setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = getResistance() * 1;
            setDefendingDefense(dr);

            return dr;
        }
    }
}
