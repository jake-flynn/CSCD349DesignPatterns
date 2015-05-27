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
    class BronzeHelmet : Item
    {
        ItemsEffect _effect;

        public BronzeHelmet()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Helmet");
            this.setEquippable(true);
            this.setSocketAmount(3);
            _effect.setEffectName("A well crafted helmet made of an alloy of copper and tin");
            _effect.setPhysicalDefense(3);
            //_effect.setManaValue(-1);         Decrease mana pool for wearing heavy armor?
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
