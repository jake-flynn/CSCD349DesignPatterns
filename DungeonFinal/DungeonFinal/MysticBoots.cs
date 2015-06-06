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
    class MysticBoots : Equipment
    {
        ItemsEffect _effect;

        public MysticBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mystic Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Mystic boots that increase resistance by 12");
            _effect.setMagicValue(3);
            _effect.setResistanceDefense(3);
            _effect.setManaValue(12);
            _effect.setEffectAmount(7);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/boots1.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
