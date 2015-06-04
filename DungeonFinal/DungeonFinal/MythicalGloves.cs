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
    class MythicalGloves : Equipment
    {
        ItemsEffect _effect;

        public MythicalGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythical Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(4);
            _effect.setEffectName("Mythical gloves that increase mana by 50");
            _effect.setPhysicalDefense(7);
            _effect.setManaValue(50);
            _effect.setEffectAmount(7);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Marauder.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
