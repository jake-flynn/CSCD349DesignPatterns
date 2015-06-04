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
    class AssassinHood : Equipment
    {
        ItemsEffect _effect;

        public AssassinHood() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Assassin Hood");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Face of darkness, increases strength by 5");
            _effect.setPhysicalDefense(5);
            _effect.setStrengthValue(5);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/darkHood.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
