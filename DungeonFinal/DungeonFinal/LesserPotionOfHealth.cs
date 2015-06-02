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
    class LesserPotionOfHealth : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfHealth() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Health Potion");
            _effect.setEffectName("Slightly heals by ");
            _effect.setEffectAmount(20);
            _effect.setHealthValue(20);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Super_Health_Potion.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
