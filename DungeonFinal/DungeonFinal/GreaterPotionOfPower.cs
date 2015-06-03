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
    class GreaterPotionOfPower : Consumable
    {
        ItemsEffect _effect;

        public GreaterPotionOfPower() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Power Potion");
            _effect.setEffectName("Greatly increase strength by 10 for five turns.");
            this.setEffect(_effect);
            setStatusEffect(new GreaterPowerBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofpower.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
