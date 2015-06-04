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
    class EnchantedRobes : Equipment
    {
        ItemsEffect _effect;

        public EnchantedRobes() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Encanted Robes");
            this.setIsTorso(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Enchanted robes that increase magic power by 10 and mana by 20");
            _effect.setPhysicalDefense(6);
            _effect.setMagicValue(10);
            _effect.setManaValue(20);
            _effect.setEffectAmount(6);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/ThalmorRobes.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
