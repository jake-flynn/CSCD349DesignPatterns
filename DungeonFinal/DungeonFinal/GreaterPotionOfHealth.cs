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
    class GreaterPotionOfHealth : Consumable
    {
        ItemsEffect _effect;

        public GreaterPotionOfHealth() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Health Potion");
            _effect.setEffectName("Greatly heals by ");
            _effect.setEffectAmount(60);
            _effect.setHealthValue(60);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Super_Health_Potion.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
