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
    class PotionOfResistance : Consumable
    {
        ItemsEffect _effect;
        
        public PotionOfResistance() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Potion of Resistance");
            _effect.setEffectName("Enhances resistance by 6 for four turns.");
            _effect.setResistanceDefense(6);
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new ResistanceBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofresistance.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
