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
    class ClothBoots: Equipment
    {
        ItemsEffect _effect;

        public ClothBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Cloth Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Cloth boots that increase resistance by 4");
            _effect.setMagicValue(1);
            _effect.setResistanceDefense(1);
            _effect.setManaValue(4);
            _effect.setEffectAmount(1);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/mageBoots.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
