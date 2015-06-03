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
    class SteelChestPlate : Equipment
    {
        ItemsEffect _effect;

        public SteelChestPlate() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Chest Plate");
            this.setIsTorso(true);
            this.setSocketAmount(6);
            _effect.setEffectName("An exceptional piece of work crafted from steel, increases health slightly.");
            _effect.setPhysicalDefense(15);
            _effect.setResistanceDefense(15);
            _effect.setHealthValue(5);
            _effect.setEffectAmount(15);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/FullPlateMail.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
