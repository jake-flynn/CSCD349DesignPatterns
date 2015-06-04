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
    class AssassinGloves : Equipment
    {
        ItemsEffect _effect;

        public AssassinGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Assassin Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Swift hands deliver death, increases strength by 20");
            _effect.setPhysicalDefense(5);
            _effect.setStrengthValue(20);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/gloves2.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
