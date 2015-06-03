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
    class PotionOfRejuvenation : Consumable
    {
        ItemsEffect _effect;

        public PotionOfRejuvenation() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rejuvenation Potion");
            _effect.setEffectName("Restores mana and health by 15 for four turns.");
            this.setEffect(_effect);
            setStatusEffect(new Rejuvenation());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Fullrejuv.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
