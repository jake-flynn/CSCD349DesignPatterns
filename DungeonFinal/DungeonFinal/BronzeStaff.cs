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
    class BronzeStaff : Equipment
    {
        ItemsEffect _effect;

        public BronzeStaff() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Staff");
            this.setIsWeapon(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A beautiful staff made of copper and tin, increases mana by 20");
            _effect.setMagicValue(10);
            _effect.setManaValue(40);

            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/WarStaff.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
