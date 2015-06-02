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
    class NullItemEquipment : Equipment
    {
        ItemsEffect _effect;

        public NullItemEquipment() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Empty slot");
            this.setIsHelmet(true);
            this.setIsGloves(true);
            this.setIsBoots(true);
            this.setIsTorso(true);
            this.setIsWeapon(true);
            _effect.setEffectName(" had no effect");
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/swordoutline.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}