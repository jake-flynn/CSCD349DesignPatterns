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
    class RuneOfHope: Item
    {
        ItemsEffect _effect;

        public RuneOfHope() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Hope");
            this.setSocketable(true);
            _effect.setEffectName("Sheds light upon your dark journey");
            _effect.setStrengthValue(10);
            _effect.setMagicValue(10);
            _effect.setResistanceDefense(10);
            _effect.setPhysicalDefense(10);
            _effect.setHealthValue(10);
            _effect.setManaValue(10);
            _effect.setEffectAmount(10);
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
