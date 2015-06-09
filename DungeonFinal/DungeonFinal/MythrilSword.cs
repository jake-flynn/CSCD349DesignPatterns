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
    class MythrilSword : Equipment
    {
        ItemsEffect _effect;

        public MythrilSword() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythril Sword");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A legendary sword made of mythril, increases mana by 20");
            _effect.setHealthValue(60);
            _effect.setStrengthValue(12);
            _effect.setMagicValue(10);
            _effect.setPhysicalDefense(7);
            _effect.setResistanceDefense(7);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Skycutter.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
