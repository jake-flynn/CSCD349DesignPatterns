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
    class LesserPotionOfRejuvenation : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfRejuvenation() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Rejuvenation Potion");
            _effect.setEffectName("Slightly restores mana and health by 10 for three turns.");
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new LesserRejuvenation());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Fullrejuv.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
