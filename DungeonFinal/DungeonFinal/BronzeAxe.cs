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
    class BronzeAxe : Equipment
    {
        ItemsEffect _effect;

        public BronzeAxe() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Axe");
            this.setSocketAmount(4);
            _effect.setEffectName("A great two handed axe made of copper and tin");
            _effect.setStrengthValue(13);
            _effect.setEffectAmount(13);
            //_effect.setHealthValue(12);
            //_effect.setManaValue(-5);
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
