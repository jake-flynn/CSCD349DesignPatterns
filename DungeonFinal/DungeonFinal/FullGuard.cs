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
    class FullGuard : StatusEffect
    {
        public FullGuard(Hero h)
        {
            setHero(h);
            setDuration(3);
        }

        public override String Modify()
        {
            getHero().setModDefense(getHero().getModDefense() + 5);
            getHero().setModResistance(getHero().getModResistance() + 5);

            setDuration(getDuration() - 1);

            return ("");
        }
    }
}
