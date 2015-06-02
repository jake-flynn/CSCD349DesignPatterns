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
            _effect.setEffectName("A well crafted helmet made of an alloy of copper and tin");
            _effect.setPhysicalDefense(5);
            _effect.setEffectAmount(5);
            //_effect.setManaValue(-1);         Decrease mana pool for wearing heavy armor?
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/bronzehelmet.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
