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
    class MythrilStaff : Equipment
    {
        ItemsEffect _effect;

        public MythrilStaff() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythril Staff");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A legendary staff made of mythril, increases mana by 40");
            _effect.setMagicValue(25);
            _effect.setManaValue(112);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/The_Tormentor.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
