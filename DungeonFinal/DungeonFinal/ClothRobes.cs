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
    class ClothRobes : Equipment
    {
        ItemsEffect _effect;

        public ClothRobes() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Cloth Robes");
            this.setIsTorso(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Finely woven silk robes that increase magic power 2 and mana power 10");
            _effect.setPhysicalDefense(2);
            _effect.setMagicValue(2);
            _effect.setManaValue(10);
            _effect.setEffectAmount(2);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/simpleRobes.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
