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
    class MythrilChestPlate : Equipment
    {
        ItemsEffect _effect;

        public MythrilChestPlate() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythril Chest Plate");
            this.setIsTorso(true);
            this.setSocketAmount(6);
            _effect.setEffectName("A legendary piece of armor, increases health by 15.");
            _effect.setPhysicalDefense(22);
            _effect.setResistanceDefense(22);
            _effect.setHealthValue(15);
            _effect.setEffectAmount(22);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/victorsilk.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
