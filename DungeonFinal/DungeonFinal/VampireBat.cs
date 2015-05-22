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
    class VampireBat : Monster
    {
        private SpecialAttackBehavior _SpecialAttack = null;

       //DVC - Level 1
        public VampireBat()
        {
            setName("VampireBat");
            setBaseHealth(100);
            setCurHealth(100);
            setMaxHealth(100);
            setBaseMana(100);
            setCurMana(100);
            setMaxMana(100);

            //Main stats are out of 20 points
            setBaseStrength(15);
            setModStrength(15);
            setBaseMagic(0);
            setModMagic(0);
            setBaseDefense(3);
            setModDefense(3);
            setBaseResistance(2);
            setModResistance(2);

            //this._SpecialAttack = new Curse();
            //base.setSpecialAttack(this._SpecialAttack);

            setIsPhysical(true);
            setIsDefeated(false);
            setIsDefending(false);
            setDefendingDefense(this.getDefendingDefense());
            setDefendingResistance(this.getDefendingResistance());
        }


        /*---------------------------------------------------------------------------------------*/
       /*Battle - Attack*/
        /*BasicAttack returns an int based on the attack stat of that character type.*/

        public override int BasicAttack()
        {
            int m = base.getModStrength();
            return m;
        }
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
    }
}
