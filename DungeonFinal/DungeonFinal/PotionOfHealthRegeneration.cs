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
    class PotionOfHealthRegeneration : Consumable
    {
        ItemsEffect _effect;

        public PotionOfHealthRegeneration() : base()
        {
            _effect = new ItemsEffect();
            setItemName("Health Regeneration Potion");
            _effect.setEffectName("Heals by ");
            setEffect(_effect);
            setHasStatusEffect(true);
          //  setStatusEffect(new HealthRegeneration());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Super_Health_Potion.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }


    }
}
