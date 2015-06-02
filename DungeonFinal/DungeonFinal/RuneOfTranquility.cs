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
    class RuneOfTranquility : Equipment
    {
        ItemsEffect _effect;

        public RuneOfTranquility() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Tranquility");
            this.setIsSocketable(true);
            _effect.setEffectName("In the midst of creation and destruction, stood tranquility...");
            _effect.setResistanceDefense(100);
            _effect.setPhysicalDefense(100);
            _effect.setEffectAmount(100);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Jah_Rune.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
