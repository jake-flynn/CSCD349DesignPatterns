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
    class ClothGloves : Item
    {
        ItemsEffect _effect;

        public ClothGloves() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Cloth Gloves");
            this.setEquippable(true);
            _effect.setEffectName("Cloth gloves that increase mana slightly");
            _effect.setPhysicalDefense(1);
            _effect.setManaValue(1);
            _effect.setEffectAmount(1);
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
