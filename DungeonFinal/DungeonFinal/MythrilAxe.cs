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
    class MythrilAxe : Equipment
    {
        ItemsEffect _effect;

        public MythrilAxe() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mythril Axe");
            this.setIsWeapon(true);
            this.setSocketAmount(5);
            _effect.setEffectName("A legendary great axe made of mythril, increases health by 20");
            _effect.setStrengthValue(23);
            _effect.setEffectAmount(23);
            _effect.setHealthValue(20);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Master_Great_Axe.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
