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
    class LesserPotionOfDefense : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfDefense() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Defense Potion");
            _effect.setEffectName("Slightly increases defense by 3 for three turns.");
            this.setEffect(_effect);
            setStatusEffect(new LesserDefenseBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofdefense.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
