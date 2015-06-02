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
    class ChainMailVest : Equipment
    {
        ItemsEffect _effect;

        public ChainMailVest() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Chain Mail Vest");
            this.setIsTorso(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A sturdy vest made of interlocking steel ringlets bound with leather strips");
            _effect.setPhysicalDefense(6);
            _effect.setEffectAmount(6);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/ChainMail.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
