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
    class BronzeGloves : Equipment
    {
        ItemsEffect _effect;

        public BronzeGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(1);
            _effect.setEffectName("Reasonably well crafted from copper and tin, increases health by 3");
            _effect.setPhysicalDefense(2);
            _effect.setResistanceDefense(2);
            _effect.setHealthValue(5);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/bronzegloves.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
