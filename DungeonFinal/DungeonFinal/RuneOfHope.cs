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
    class RuneOfHope : Equipment
    {
        ItemsEffect _effect;

        public RuneOfHope() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Hope");
            this.setIsSocketable(true);
            _effect.setEffectName("Sheds light upon your dark journey");
            _effect.setStrengthValue(10);
            _effect.setMagicValue(10);
            _effect.setResistanceDefense(10);
            _effect.setPhysicalDefense(10);
            _effect.setHealthValue(10);
            _effect.setManaValue(10);
            _effect.setEffectAmount(10);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/chamRune.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
