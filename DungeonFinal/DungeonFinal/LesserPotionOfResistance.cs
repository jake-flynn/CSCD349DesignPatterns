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
    class LesserPotionOfResistance : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfResistance() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Resistance Potion");
            _effect.setEffectName("Slightly increases resistance by 3 for three turns.");
            _effect.setResistanceDefense(3);
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new LesserResistanceBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofresistance.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
