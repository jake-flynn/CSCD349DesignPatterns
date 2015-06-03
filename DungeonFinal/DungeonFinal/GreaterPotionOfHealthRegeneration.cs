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
    class GreaterPotionOfHealthRegeneration : Consumable
    {
        ItemsEffect _effect;

        public GreaterPotionOfHealthRegeneration() : base()
        {
            _effect = new ItemsEffect();
            setItemName("Greater Health Regeneration Potion");
            _effect.setEffectName("Restores health by 20 for four turns.");
            setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new GreaterHealthRegeneration());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Super_Health_Potion.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
