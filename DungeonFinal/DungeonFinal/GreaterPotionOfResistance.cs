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
    class GreaterPotionOfResistance : Consumable
    {
        ItemsEffect _effect;

        public GreaterPotionOfResistance() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Resistance Potion");
            _effect.setEffectName("Greatly increase resistance by 10 for five turns.");
            _effect.setPhysicalDefense(10);
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new GreaterResistanceBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofresistance.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
