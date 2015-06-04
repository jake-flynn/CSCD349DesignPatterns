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
    class BronzeHelmet : Equipment
    {
        ItemsEffect _effect;

        public BronzeHelmet() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("A bronze helmet that increases health by 4");
            _effect.setPhysicalDefense(6);
            _effect.setResistanceDefense(6);
            _effect.setHealthValue(4);
            _effect.setEffectAmount(6);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/bronzehelmet.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
