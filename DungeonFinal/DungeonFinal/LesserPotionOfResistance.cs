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
    class LesserPotionOfResistance : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfResistance() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Resistance Potion");
            _effect.setEffectName("Slightly increases resistance by ");
            _effect.setEffectAmount(3);
            _effect.setResistanceDefense(3);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofresistance.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
