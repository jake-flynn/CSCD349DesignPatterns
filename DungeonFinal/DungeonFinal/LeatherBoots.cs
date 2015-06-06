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
    class LeatherBoots : Equipment
    {
        ItemsEffect _effect;

        public LeatherBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Boots made from leather that increase strength by 3");
            _effect.setStrengthValue(1);
            _effect.setPhysicalDefense(1);            
            _effect.setManaValue(2);
            _effect.setEffectAmount(3);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/heavyboots.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
