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
    class RuneOfDespair : Equipment
    {
        ItemsEffect _effect;

        public RuneOfDespair() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Despair");
            this.setIsSocketable(true);
            _effect.setEffectName("Sheds darkness upon your enemies");
            _effect.setStrengthValue(15);
            _effect.setMagicValue(15);
            _effect.setHealthValue(15);
            _effect.setManaValue(15);
            _effect.setEffectAmount(15);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/zodRune.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
