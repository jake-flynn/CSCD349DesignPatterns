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
    class MythrilHelmet : Equipment
    {
        ItemsEffect _effect;

        public MythrilHelmet() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythril Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("A legendary helmet made of mythril, increases health by 5");
            _effect.setPhysicalDefense(19);
            _effect.setResistanceDefense(19);
            _effect.setHealthValue(5);
            _effect.setEffectAmount(19);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/wormskull.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
