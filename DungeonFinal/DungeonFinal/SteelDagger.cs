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
    class SteelDagger : Equipment
    {
        ItemsEffect _effect;

        public SteelDagger() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Dagger");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A ferocious dagger made of high tensile steel");
            _effect.setStrengthValue(12);
            _effect.setEffectAmount(12);
            //_effect.setHealthValue(12);
            //_effect.setManaValue(-5);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/kriss.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
