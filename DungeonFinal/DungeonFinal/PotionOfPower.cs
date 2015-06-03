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
    class PotionOfPower : Consumable
    {
        ItemsEffect _effect;

        public PotionOfPower() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Potion of Power");
            _effect.setEffectName("Enhances power by 6 for four turns.");
            this.setEffect(_effect);
            setStatusEffect(new PowerBoost());
            
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofpower.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
