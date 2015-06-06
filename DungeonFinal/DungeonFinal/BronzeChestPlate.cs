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
    class BronzeChestPlate : Equipment
    {
        ItemsEffect _effect;

        public BronzeChestPlate() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Chest Plate");
            this.setIsTorso(true);
            this.setSocketAmount(6);
            _effect.setEffectName("A bronze chest plate that increases health by 5");
            _effect.setPhysicalDefense(2);
            _effect.setResistanceDefense(1);
            _effect.setHealthValue(10);
            _effect.setEffectAmount(9);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/bronzeTorso.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
