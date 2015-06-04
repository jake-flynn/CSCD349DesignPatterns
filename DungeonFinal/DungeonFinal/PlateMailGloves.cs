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
    class PlateMailGloves : Equipment
    {
        ItemsEffect _effect;

        public PlateMailGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Plate Mail Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Plate mail gloves that increase strength by 9");
            _effect.setPhysicalDefense(10);
            _effect.setStrengthValue(9);
            _effect.setEffectAmount(10);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/platedGloves.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
