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
    class Poison : StatusEffect
    {
        public Poison(Hero h)
        {
            setHero(h);
            setDuration(10);

            //_Hero.addObserver(this);
        }

        public override void Modify()
        {
            int health1 = getHero().getCurHealth();
            MessageBox.Show("Poison is about to take effect! Health is now " + health1);

            setDuration(getDuration() - 1);
            getHero().setCurHealth(getHero().getCurHealth() - 15);

            int health2 = getHero().getCurHealth();
            MessageBox.Show("Poison took effect! Health is now " + health2);
        }

    }
}
