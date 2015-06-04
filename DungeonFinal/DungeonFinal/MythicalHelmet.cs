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
    class MythicalHelmet : Equipment
    {
        ItemsEffect _effect;

        public MythicalHelmet() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythical Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("A mythical helmet that increases mana by 20");
            _effect.setPhysicalDefense(9);
            _effect.setManaValue(20);
            _effect.setEffectAmount(9);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/GodHelm.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
