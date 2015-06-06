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
    class SteelGloves : Equipment
    {
        ItemsEffect _effect;

        public SteelGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Gloves");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Strong gloves made of an alloy of steel, increases health by 3");
            _effect.setPhysicalDefense(3);
            _effect.setResistanceDefense(3);
            _effect.setHealthValue(10);
            _effect.setEffectAmount(10);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/steelgloves.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
