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
        }

        public override String Modify()
        {
            setDuration(getDuration() - 1);
            getHero().setCurHealth(getHero().getCurHealth() - 15);

            return (getHero().getName() + " suffered 15 damage from their poison, it will remain in their blood stream for " + getDuration() + " more turn(s)!\r\n");
        }

    }
}
