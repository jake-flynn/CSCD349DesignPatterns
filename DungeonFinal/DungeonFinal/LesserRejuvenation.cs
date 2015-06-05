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
    class LesserRejuvenation : StatusEffect
    {
        public LesserRejuvenation()
        {
            setDuration(3);
        }

        public override String Modify()
        {
            getHero().setCurHealth(getHero().getCurHealth() + 10);
            getHero().setCurMana(getHero().getCurMana() + 10);                
            setDuration(getDuration() - 1);

            if(getDuration() > 0)
            {
                return (getHero().getName() + " health and mana are being rejuvenated by 10 for " + getDuration() + " more turn(s)!\r\n");
            }
            
            else
            {
                return (getHero().getName() + " lesser rejuvenation potion has ended!\r\n");
            }

        }
    }
}
