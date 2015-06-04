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
    class LeatherGloves : Equipment
    {
        ItemsEffect _effect;

        public LeatherGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Gloves made from leather straps woven together, increases strength by 4");
            _effect.setPhysicalDefense(4);
            _effect.setStrengthValue(4);
            _effect.setEffectAmount(4);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Heavy_Gloves.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
