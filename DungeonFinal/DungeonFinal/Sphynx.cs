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
    class Sphynx : Monster
    {
        private SpecialAttackBehavior _SpecialAttack = null;

       //DVC - Level 2
        public Sphynx()
        {
            setName("Sphynx");
            setBaseHealth(200);
            setCurHealth(200);
            setMaxHealth(200);
            setBaseMana(200);
            setCurMana(200);
            setMaxMana(200);

            //Main stats are out of 40 points
            setBaseStrength(0);
            setModStrength(0);
            setBaseMagic(10);
            setModMagic(10);
            setBaseDefense(15);
            setModDefense(15);
            setBaseResistance(15);
            setModResistance(15);

            //this._SpecialAttack = new Curse();
            //base.setSpecialAttack(this._SpecialAttack);

            setIsPhysical(false);
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
            int m = base.getModMagic();
            return m;
        }
        /*FindTarget receives a party of type GameCharacter and chooses the hero to attack.*/
        public override Hero FindTarget(Party p)
        {
            Hero[] party = p.getHeros();
            Hero target = party[0];

            if (p.getCurrentPartyMembers() == 1)
            {
                return target;
            }

            for (int i = 0; i < (p.getCurrentPartyMembers() - 2); i++)
            {
                if(party[i + 1].getModHealth() < party[i].getModHealth())
                {
                    target = party[i + 1];
                }
            }

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


        public override ImageBrush getBrush()
        {
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-VhVoLwooRXk/VV7qD-Xj7vI/AAAAAAAAA0o/x6HtA5ZPXto/s506/Sphinx.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }
    }
}
