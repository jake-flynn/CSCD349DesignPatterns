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
    class RuneOfCreation : Equipment
    {
        ItemsEffect _effect;

        public RuneOfCreation() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Creation");
            this.setIsSocketable(true);
            _effect.setEffectName("God created the heavens, the earth, and this...");
            _effect.setHealthValue(100);
            _effect.setManaValue(100);
            _effect.setEffectAmount(100);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Ber_Rune.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
