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
    class MythrilDagger : Equipment
    {
        ItemsEffect _effect;

        public MythrilDagger() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythril Dagger");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A legendary dagger made of mythril, increases magic resistance by 12");
            _effect.setStrengthValue(27);
            _effect.setResistanceDefense(12);
            _effect.setEffectAmount(27);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Pig_Sticker.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
