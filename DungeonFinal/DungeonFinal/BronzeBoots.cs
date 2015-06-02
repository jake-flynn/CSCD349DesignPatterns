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
    class BronzeBoots : Equipment
    {
        ItemsEffect _effect;

        public BronzeBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Durable boots made of copper and tin");
            _effect.setPhysicalDefense(4);
            _effect.setEffectAmount(4);
            //_effect.setManaValue(-2);     heavy armor effect?
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/bronzeBoots.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }

    }
}
