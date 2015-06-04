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
    class SteelBoots : Equipment
    {
        ItemsEffect _effect;

        public SteelBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Steel Boots");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Durable boots made of steel, increases health by 4");
            _effect.setPhysicalDefense(11);
            _effect.setResistanceDefense(11);
            _effect.setHealthValue(4);
            _effect.setEffectAmount(11);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Light_Plated_Boots.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
