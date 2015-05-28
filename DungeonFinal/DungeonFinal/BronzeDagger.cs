﻿using System;
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
    class BronzeDagger : Item
    {
        ItemsEffect _effect;

        public BronzeDagger()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Dagger");
            this.setEquippable(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A deadly dagger made of copper and tin");
            _effect.setStrengthValue(9);
            _effect.setEffectAmount(9);
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