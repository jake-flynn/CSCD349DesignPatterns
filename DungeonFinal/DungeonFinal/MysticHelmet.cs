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
    class MysticHelmet : Equipment
    {
        ItemsEffect _effect;

        public MysticHelmet() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mystic Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("A mystic helmet that increases mana by 20");
            _effect.setMagicValue(5);
            _effect.setResistanceDefense(3);
            _effect.setManaValue(21);
            _effect.setEffectAmount(9);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/GodHelm.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
