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
    class SimpleSword : Equipment
    {
        ItemsEffect _effect;

        public SimpleSword() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Simple Sword");
            this.setIsWeapon(true);
            _effect.setEffectName("A simple sword");
            _effect.setStrengthValue(12);
            _effect.setEffectAmount(12);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/2hsword.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
