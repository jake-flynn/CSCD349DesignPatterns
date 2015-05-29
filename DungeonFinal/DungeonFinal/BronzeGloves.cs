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
    class BronzeGloves : Equipment
    {
        ItemsEffect _effect;

        public BronzeGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Gloves");
            this.setSocketAmount(1);
            _effect.setEffectName("Reasonably well crafted from copper and tin");
            _effect.setPhysicalDefense(3);
            _effect.setEffectAmount(3);
            //_effect.setManaValue(-2);     heavy armor effect?
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
