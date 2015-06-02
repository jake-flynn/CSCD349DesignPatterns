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
    class ClothHeadPiece : Equipment
    {
         ItemsEffect _effect;

        public ClothHeadPiece() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Cloth HeadPiece");
            this.setIsHelmet(true);
            this.setSocketAmount(2);
            _effect.setEffectName("A fine cloth made of silk woven into a khimar");
            _effect.setPhysicalDefense(2);
            _effect.setEffectAmount(2);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"Images/Items/busterblade.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
