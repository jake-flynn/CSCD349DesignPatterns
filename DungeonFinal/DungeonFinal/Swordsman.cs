using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Swordsman : GameCharacter
    {
        private SpecialAttackBehavior _SpecialAttack = null;

       //DVC
        public Swordsman()
        {
            base.setHealth(100);
            base.setMana(100);
            base.setStrength(10);
            base.setMagic(10);
            base.setDefense(10);
            base.setResistance(10);
            
            base.setIsDefending(false);
            base.setDefendingDefense(this.getDefendingDefense());
            base.setDefendingResistance(this.getDefendingResistance());

            this._SpecialAttack = new BladeSlash();
            base.setSpecialAttack(this._SpecialAttack);
        }

       //EVC
        public Swordsman(int h, int ma, int s, int mg, int d, int r)
        {
            base.setHealth(h);
            base.setMana(ma);
            base.setStrength(s);
            base.setMagic(mg);
            base.setDefense(d);
            base.setResistance(r);

            base.setIsDefending(false);
            base.setDefendingDefense(this.getDefendingDefense());
            base.setDefendingResistance(this.getDefendingResistance());

            this._SpecialAttack = new BladeSlash();
            base.setSpecialAttack(this._SpecialAttack);
        }

        

       /*Battle - Attack*/
        /*This method returns an int based on the attack stat of that character type.*/
        public override string getName()
        {
            return "Swordsman";
        }

        public override int BasicAttack()
        {
            int s = base.getStrength();
            return s;
        }
        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override GameCharacter FindTarget(GameCharacter[] party)
        {
            return null;
        }

       /*Battle - Defend*/
        /*getDefendingDefense returns adjusted defense value when in the defensive stance*/
        public override int getDefendingDefense()
        {
            int dd = base.getDefense() * 2;
            base.setDefendingDefense(dd);

            return dd;
        }
        /*getDefendingResistance returns adjusted resistance value when in the defensive stance*/
        public override int getDefendingResistance()
        {
            int dr = base.getResistance() * 2;
            base.setDefendingDefense(dr);

            return dr;
        }
    }
}
