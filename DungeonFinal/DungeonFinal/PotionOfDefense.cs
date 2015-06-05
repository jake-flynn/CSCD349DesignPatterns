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
    class PotionOfDefense : Consumable
    {
        ItemsEffect _effect;

        public PotionOfDefense() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Defense Potion");
            _effect.setEffectName("Enhances defense by 6 for four turns.");
            _effect.setPhysicalDefense(6);
            this.setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new DefenseBoost());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofdefense.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
