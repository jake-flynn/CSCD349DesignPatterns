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
    class AssassinBoots : Equipment
    {
        ItemsEffect _effect;

        public AssassinBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Assassin Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Silence in flight, increases strength by 10");
            _effect.setStrengthValue(3);
            _effect.setPhysicalDefense(3);
            _effect.setManaValue(6);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Blakthorne_boots.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
