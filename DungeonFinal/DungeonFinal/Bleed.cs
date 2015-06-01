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
    class Bleed : StatusEffect
    {
        int _Damage = 0;

        public Bleed(Hero h)
        {
            setHero(h);
            setDuration(1);
        }

        public override void Modify()
        {
            _Damage += 10;

            //setDuration(getDuration() - 1);
            getHero().setCurHealth(getHero().getCurHealth() - _Damage);

            int health2 = getHero().getCurHealth();
            MessageBox.Show("Bleed took effect! Health is now " + health2);
        }

    }
}
