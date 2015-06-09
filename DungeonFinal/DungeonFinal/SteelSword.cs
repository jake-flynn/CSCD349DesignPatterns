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
    class SteelSword : Equipment
    {
        ItemsEffect _effect;

        public SteelSword() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Sword");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A razor sharp sword made of folded steel, increases mana by 15");
            _effect.setHealthValue(30);
            _effect.setStrengthValue(7);
            _effect.setMagicValue(6);
            _effect.setPhysicalDefense(4);
            _effect.setResistanceDefense(4);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/warsword.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
