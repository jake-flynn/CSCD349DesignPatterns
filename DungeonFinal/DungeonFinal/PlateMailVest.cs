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
    class PlateMailVest : Equipment
    {
        ItemsEffect _effect;

        public PlateMailVest() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Plate Mail Vest");
            this.setIsTorso(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A vest made of plate mail, increases strength by 15");
            _effect.setPhysicalDefense(18);
            _effect.setStrengthValue(15);
            _effect.setEffectAmount(18);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Robes_of_the_Rydraelm.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
