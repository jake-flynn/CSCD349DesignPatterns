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
    class BronzeSword : Equipment
    {
        ItemsEffect _effect;

        public BronzeSword() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Sword");
            this.setIsWeapon(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A well balanced sword made of copper and tin, increases mana by 10");
            _effect.setStrengthValue(11);
            _effect.setEffectAmount(11);
            _effect.setManaValue(10);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/bronzesword.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
