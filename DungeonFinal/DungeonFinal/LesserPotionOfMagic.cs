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
    class LesserPotionOfMagic : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfMagic() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Magic Potion");
            _effect.setEffectName("Slightly increases magic by ");
            _effect.setEffectAmount(3);
            _effect.setMagicValue(3);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofmagic.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
