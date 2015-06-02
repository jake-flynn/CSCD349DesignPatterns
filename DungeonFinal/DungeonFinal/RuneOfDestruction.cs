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
    class RuneOfDestruction : Equipment
    {
        ItemsEffect _effect;

        public RuneOfDestruction() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Destruction");
            this.setIsSocketable(true);
            _effect.setEffectName("The fallen angel set fire to the heavens, and this fell from the ashes...");
            _effect.setStrengthValue(100);
            _effect.setMagicValue(100);
            _effect.setEffectAmount(100);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/Ist_Rune.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
