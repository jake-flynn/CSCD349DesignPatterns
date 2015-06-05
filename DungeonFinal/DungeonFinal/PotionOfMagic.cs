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
    class PotionOfMagic : Consumable
    {
        ItemsEffect _effect;

        public PotionOfMagic() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Magic Potion");
            _effect.setEffectName("Enhances magic power by 6 for four turns.");
            _effect.setPhysicalDefense(6);
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new MagicBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofmagic.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
