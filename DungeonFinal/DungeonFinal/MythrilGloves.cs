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
    class MythrilGloves : Equipment
    {
        ItemsEffect _effect;

        public MythrilGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythril Gloves");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Legendary gloves made of mythril, increases health by 5");
            _effect.setPhysicalDefense(17);
            _effect.setResistanceDefense(17);
            _effect.setHealthValue(5);
            _effect.setEffectAmount(17);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/AlabasterGlove.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
