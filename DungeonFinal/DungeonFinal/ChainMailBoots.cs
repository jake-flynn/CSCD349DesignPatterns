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
    class ChainMailBoots : Equipment
    {
        ItemsEffect _effect;

        public ChainMailBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Chain Mail Boots");
            this.setSocketAmount(2);
            _effect.setEffectName("Chain Mail boots made of steel ringlets reinfored with leather strips");
            _effect.setPhysicalDefense(4);
            _effect.setEffectAmount(4);
            this.setEffect(_effect);
        }

        public override ImageBrush getBrush()
        {
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-VE9mF5_fgt4/VV7rvGU76XI/AAAAAAAAA3o/HIMeg3vKuaM/w506-h354/Hellhound.jpg"));
            imgBrush.ImageSource = image;
            return imgBrush;
        }
    }
}
