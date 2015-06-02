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
    class SteelStaff : Equipment
    {
        ItemsEffect _effect;

        public SteelStaff() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Staff");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A magnificent staff made of high quality steel");
            _effect.setMagicValue(12);
            _effect.setEffectAmount(12);
            //_effect.setHealthValue(12);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/spireoflazarus.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
