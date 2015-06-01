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
    class Burn : StatusEffect
    {
        public Burn(Hero h)
        {
            setHero(h);
            setDuration(5);
        }

        public override void Modify()
        {
            getHero().setCurHealth(getHero().getCurHealth() - 10);

            if(getDuration() == 5)
            {
                getHero().setModStrength(getHero().getModStrength() - 5);
                getHero().setModMagic(getHero().getModMagic() - 5);
            }

            else if(getDuration() == 1)
            {
                getHero().setModStrength(getHero().getModStrength() + 5);
                getHero().setModMagic(getHero().getModMagic() + 5);
            }

            setDuration(getDuration() - 1);

            int health2 = getHero().getCurHealth();
            MessageBox.Show("Burn took effect! Health is now " + health2);
        }

    }
}
