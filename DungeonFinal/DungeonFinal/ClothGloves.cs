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
    class ClothGloves : Equipment
    {
        ItemsEffect _effect;

        public ClothGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Cloth Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(1);
            _effect.setEffectName("Cloth gloves that increase mana by 30");
            _effect.setPhysicalDefense(1);
            _effect.setManaValue(30);
            _effect.setEffectAmount(1);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/busterblade.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
