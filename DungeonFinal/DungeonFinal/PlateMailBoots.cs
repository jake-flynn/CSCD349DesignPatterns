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
    class PlateMailBoots : Equipment
    {
        ItemsEffect _effect;

        public PlateMailBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Plate Mail Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Plate Mail boots that increase strength by 8");
            _effect.setPhysicalDefense(4);
            _effect.setResistanceDefense(3);
            _effect.setHealthValue(40);
            _effect.setEffectAmount(40);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Fire_Walkers.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
