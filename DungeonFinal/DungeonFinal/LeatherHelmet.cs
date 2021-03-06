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
    class LeatherHelmet : Equipment
    {
        ItemsEffect _effect;

        public LeatherHelmet() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(1);
            _effect.setEffectName("A sturdy leather cap, increases strength by 3");
            _effect.setStrengthValue(5);
            _effect.setPhysicalDefense(2);
            _effect.setManaValue(10);
            _effect.setEffectAmount(4);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/LeatherCap.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
