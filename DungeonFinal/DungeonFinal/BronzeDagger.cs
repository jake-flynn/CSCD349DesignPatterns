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
    class BronzeDagger : Equipment
    {
        ItemsEffect _effect;

        public BronzeDagger() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Dagger");
            this.setIsWeapon(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A deadly dagger made of copper and tin");
            _effect.setStrengthValue(9);
            _effect.setEffectAmount(9);
            //_effect.setHealthValue(12);
            //_effect.setManaValue(-5);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/dagger.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
