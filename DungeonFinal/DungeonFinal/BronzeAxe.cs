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
    class BronzeAxe : Equipment
    {
        ItemsEffect _effect;

        public BronzeAxe() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Axe");
            this.setIsWeapon(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A great two handed axe made of copper and tin, increases health by 10");
            _effect.setStrengthValue(9);
            _effect.setEffectAmount(9);
            _effect.setHealthValue(10);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/giantaxe.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
