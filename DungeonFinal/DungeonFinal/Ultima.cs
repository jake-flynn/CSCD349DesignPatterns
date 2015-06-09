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
    class Ultima : Equipment
    {
        ItemsEffect _effect;

        public Ultima() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Ultima");
            this.setIsWeapon(true);
            this.setSocketAmount(15);
            _effect.setEffectName("The Ultimate weapon, guaranteed to increase the power of any warrior or mage");
            _effect.setHealthValue(100);
            _effect.setStrengthValue(40);
            _effect.setMagicValue(40);
            _effect.setPhysicalDefense(14);
            _effect.setResistanceDefense(14);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/busterblade.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
