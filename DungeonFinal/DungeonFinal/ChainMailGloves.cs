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
    class ChainMailGloves : Equipment
    {
        ItemsEffect _effect;

        public ChainMailGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Chain Mail Gloves");
            this.setIsGloves(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Chain mail gloves made of interlocking steel that increase strength by 6");
            _effect.setPhysicalDefense(7);
            _effect.setStrengthValue(6);
            _effect.setEffectAmount(7);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Chain_Gloves.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
