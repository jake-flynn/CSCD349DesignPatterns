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
    class GreaterPotionOfMagic : Consumable
    {
        ItemsEffect _effect;

        public GreaterPotionOfMagic() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Magic Potion");
            _effect.setEffectName("Greatly increase magic by 10 for five turns.");
            _effect.setMagicValue(10);
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new GreaterMagicBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofmagic.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
