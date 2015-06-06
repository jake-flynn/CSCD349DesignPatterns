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
    class PlateMailHelmet : Equipment
    {
        ItemsEffect _effect;

        public PlateMailHelmet() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Plate Mail Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Plate mail helmet, increases strength by 7");
            _effect.setPhysicalDefense(5);
            _effect.setResistanceDefense(5);
            _effect.setHealthValue(60);
            _effect.setEffectAmount(14);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/RaekorHelm.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
