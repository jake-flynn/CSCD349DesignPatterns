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
    class LeatherVest : Equipment
    {
        ItemsEffect _effect;

        public LeatherVest() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Vest");
            this.setIsTorso(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A vest made of stiff leather, increases strength by 5");
            _effect.setPhysicalDefense(6);
            _effect.setStrengthValue(5);
            _effect.setEffectAmount(6);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Studded.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
