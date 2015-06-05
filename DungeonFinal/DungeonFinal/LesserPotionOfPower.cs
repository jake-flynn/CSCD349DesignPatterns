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
    class LesserPotionOfPower : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfPower() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Power Potion");
            _effect.setEffectName("Slightly increases power by 3 for three turns.");
            _effect.setStrengthValue(3);
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new LesserPowerBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofpower.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
