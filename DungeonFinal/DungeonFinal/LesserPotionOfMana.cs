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
    class LesserPotionOfMana : Consumable
    {
        ItemsEffect _effect;

        public LesserPotionOfMana() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Mana Potion");
            _effect.setEffectName("Slightly restores mana by ");
            _effect.setEffectAmount(20);
            _effect.setManaValue(20);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/full_mana_potion.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
