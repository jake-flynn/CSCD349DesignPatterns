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
    class EnchantedBoots : Equipment
    {
        ItemsEffect _effect;

        public EnchantedBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Enchanted Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Enchanted boots that increase resistance by 8");
            _effect.setMagicValue(2);
            _effect.setResistanceDefense(2);
            _effect.setManaValue(8);
            _effect.setEffectAmount(3);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/mageBoots.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
