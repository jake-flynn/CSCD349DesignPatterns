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
    class MysticGloves : Equipment
    {
        ItemsEffect _effect;

        public MysticGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mystic Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(4);
            _effect.setEffectName("Mystic gloves that increase mana by 50");
            _effect.setMagicValue(3);
            _effect.setResistanceDefense(3);
            _effect.setManaValue(12);
            _effect.setEffectAmount(7);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Marauder.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
