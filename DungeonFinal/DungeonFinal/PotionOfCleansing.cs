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
    class PotionOfCleansing : StatusEffect
    {
        public PotionOfCleansing(Hero h)
        {
            setHero(h);
            setDuration(1);
        }

        public override string Modify()
        {
            getHero().ClearAllEffects();
            setDuration(getDuration() - 1);

            return ("Potion of Cleansing cleared " + getHero().getName() + " of all their effects!\r\n");
        }
    }
}
