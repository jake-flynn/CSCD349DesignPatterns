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
    class GreaterPotionOfRejuvenation : Consumable
    {
        ItemsEffect _effect;

        public GreaterPotionOfRejuvenation() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Rejuvenation Potion");
            _effect.setEffectName("Restores mana and health by 20 for five turns.");
            this.setEffect(_effect);
            setStatusEffect(new GreaterRejuvenation());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Fullrejuv.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
