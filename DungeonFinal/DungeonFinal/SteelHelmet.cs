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
    class SteelHelmet : Equipment
    {
        ItemsEffect _effect;

        public SteelHelmet() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("A well crafted helmet made of steel, increases health by 3");
            _effect.setPhysicalDefense(12);
            _effect.setResistanceDefense(12);
            _effect.setHealthValue(3);
            _effect.setEffectAmount(12);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Assualthelm.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
