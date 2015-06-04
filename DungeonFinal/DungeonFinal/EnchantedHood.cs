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
    class EnchantedHood : Equipment
    {
        ItemsEffect _effect;

        public EnchantedHood() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Enchanted Hood");
            this.setIsHelmet(true);
            this.setSocketAmount(2);
            _effect.setEffectName("An enchanted hood that increases mana by 15");
            _effect.setPhysicalDefense(4);
            _effect.setManaValue(15);
            _effect.setEffectAmount(4);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/mageHood.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
