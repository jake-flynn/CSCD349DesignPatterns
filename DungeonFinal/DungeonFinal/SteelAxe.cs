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
    class SteelAxe : Equipment
    {
        ItemsEffect _effect;

        public SteelAxe() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Axe");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A monsterous two handed axe made of tempered steel, increases health by 15");
            _effect.setStrengthValue(16);
            _effect.setEffectAmount(16);
            _effect.setHealthValue(15);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/brainhew.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
